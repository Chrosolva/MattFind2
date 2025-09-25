using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEALCHK.Data;
using SEALCHK.Model;
using System.Text.RegularExpressions;
using System.Data.Entity; // for EF6 AsNoTracking, etc.
using System.Globalization;
using System.Data.SqlClient; // for SqlParameter


namespace SEALCHK.View
{
    public partial class CollectSealForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        private SerialDataReceivedEventHandler _dataReceivedHandler;
        private System.Windows.Forms.Timer _regSearchTimer;
        private bool _listening = false;
        // store the exact key from DB for the currently selected register
        private DateTime _currentTglInputKey;
        private string _currentNoPlat;
        private SerialPort SPRegis => Session.GlobalPort;

        private BindingList<CollectItem> _collectItems;
        // Add at class level in CollectSealForm
        private readonly HashSet<string> _scannedSeals = new HashSet<string>(StringComparer.OrdinalIgnoreCase);


        public sealed class CollectItem
        {
            public int? PartIndex { get; set; }
            public string PartID { get; set; }
            public string Seal { get; set; }
            public string Status { get; set; }
            public string KodeTujuan { get; set; }
            public string Tujuan { get; set; }
            public DateTime? Tgl_Kirim { get; set; }
            public DateTime? Tgl_Kembali { get; set; }
            public string Keterangan { get; set; }
        }

        public CollectSealForm()
        {
            InitializeComponent();
            
        }

        private void InitSerialUi()
        {
            btnStartListen.Click += btnStartListen_Click;
            btnSave.Click += btnSave_Click;

            if (_dataReceivedHandler == null)
            {
                _dataReceivedHandler = SPRegis_DataReceived;
                SPRegis.DataReceived += _dataReceivedHandler;
                SPRegis.ErrorReceived += SPRegis_ErrorReceived;
                SPRegis.PinChanged += SPRegis_PinChanged;
            }

            UpdateUiForPortState(true);
        }

        private void btnStartListen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblNoPlat.Text) || lblNoPlat.Text == "-")
            {
                MessageBox.Show("Pilih Register di tab pertama lalu klik Collect agar data terisi.",
                                "Collect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Only validate when we are about to START listening
            if (!_listening && !EnsureCanStartCollectListening()) return;

            _listening = !_listening;
            lblPortStatus.Text = _listening ? "Listening (collect)..." : "Stopped";
            lblPortStatus.ForeColor = _listening ? Color.DodgerBlue : Color.DarkOrange;
        }

        private bool EnsureCanStartCollectListening()
        {
            // Header status (label) check
            var headerIsDikirim = string.Equals(lblStatus.Text?.Trim(), "DIKIRIM", StringComparison.OrdinalIgnoreCase);

            // Detail rows check: anything still to collect?
            bool anyToCollect = dgvCollectDetail.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Any(r =>
                {
                    var status = Convert.ToString(r.Cells["Status"].Value);
                    var tglObj = r.Cells["Tgl_Kembali"]?.Value;

            // Has return date?
            DateTime dt;
                    bool hasReturn = (tglObj is DateTime) || DateTime.TryParse(Convert.ToString(tglObj), out dt);

            // Collectable if explicitly DIKIRIM or no return yet and not already DIKEMBALIKAN
            return string.Equals(status, "DIKIRIM", StringComparison.OrdinalIgnoreCase)
                           || (!hasReturn && !string.Equals(status, "DIKEMBALIKAN", StringComparison.OrdinalIgnoreCase));
                });

            if (!headerIsDikirim)
            {
                //var ask = MessageBox.Show(
                //    "Status register bukan DIKIRIM. Mulai listening tetap?",
                //    "Collect", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (ask != DialogResult.Yes) return false;

                MessageBox.Show("Status Bukan Dikirim , proses listening code Gagal !!!");
                return false;
            }

            if (!anyToCollect)
            {
                MessageBox.Show("Tidak ada item berstatus DIKIRIM untuk dikoleksi.", "Collect",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void UpdateUiForPortState(bool connected)
        {
            lblPortStatus.Text = connected
                ? "Connected: " + SPRegis.PortName + " @ " + SPRegis.BaudRate
                : "Disconnected";
            lblPortStatus.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
        }

        private void SPRegis_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;

            try
            {
                while (sp.IsOpen)
                {
                    string line;
                    try
                    {
                        line = sp.ReadLine(); // waits for NewLine or times out
                    }
                    catch (TimeoutException)
                    {
                        break; // partial line, wait next event
                    }

                    BeginInvoke(new Action(() => OnLineReceived(line)));

                    if (sp.BytesToRead == 0) break;
                }
            }
            catch (IOException)
            {
                BeginInvoke(new Action(() =>
                {
                    lblPortStatus.Text = "I/O error (disconnected?)";
                    lblPortStatus.ForeColor = Color.DarkOrange;
                }));
            }
            catch (InvalidOperationException)
            {
                // Port closed between reads
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    lblPortStatus.Text = "Read error: " + ex.Message;
                    lblPortStatus.ForeColor = Color.DarkOrange;
                }));
            }
        }

        private void SPRegis_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                lblPortStatus.Text = "Serial error: " + e.EventType;
                lblPortStatus.ForeColor = Color.DarkOrange;
            }));
        }

        private void SPRegis_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                txtSerialLog.AppendText("PinChanged: " + e.EventType + Environment.NewLine);
            }));
        }

        private void OnLineReceived(string line)
        {
            txtSerialLog.AppendText(line + Environment.NewLine);
            if (!_listening) return;

            string seal;
            if (TryExtractCollectSeal(line, out seal))
            {
                // If we’ve seen this seal already, send ACK but log it
                if (_scannedSeals.Contains(seal))
                {
                    AppendLog($"Duplicate scan ignored: {seal}\r\n", Color.DarkGoldenrod);
                    return;
                }

                if (ApplyCollectScan(seal))
                {
                    try { if (SPRegis.IsOpen) SPRegis.Write("*2#"); } catch { /* ignore */ }
                }
                else
                {
                    MessageBox.Show($"SealCode '{seal}' tidak cocok dengan daftar tujuan.",
                                    "Collect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AppendLog($"Mismatch: {seal}\r\n", Color.Red);
                }
            }
        }

        private void AppendLog(string msg, Color? color = null)
        {
            if (!color.HasValue)
            {
                txtSerialLog.AppendText(msg);
                return;
            }

            int start = txtSerialLog.TextLength;
            txtSerialLog.AppendText(msg);
            txtSerialLog.Select(start, msg.Length);
            txtSerialLog.SelectionColor = color.Value;
            txtSerialLog.SelectionLength = 0;
            txtSerialLog.SelectionColor = txtSerialLog.ForeColor;
        }

        private bool TryExtractCollectSeal(string line, out string seal)
        {
            seal = null;
            if (string.IsNullOrWhiteSpace(line)) return false;

            var s = line.Trim();
            if (s.Length >= 3 && s.StartsWith("*") && s.EndsWith("#"))
            {
                var inner = s.Substring(1, s.Length - 2).Trim();
                //if (inner.All(char.IsDigit))
                //{
                //    seal = inner;
                //    return true;
                //}

                seal = inner;
                return true;
            }
            return false;
        }

        private bool ApplyCollectScan(string seal)
        {
            if (dgvCollectDetail.Rows.Count == 0) return false;

            // find the row with matching seal
            var row = dgvCollectDetail.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => !r.IsNewRow &&
                                     string.Equals(Convert.ToString(r.Cells["Seal"].Value), seal, StringComparison.OrdinalIgnoreCase));
            if (row == null) return false;

            // Already returned?  Still ACK but log as duplicate and skip changes
            var curStatus = Convert.ToString(row.Cells["Status"].Value);
            if (string.Equals(curStatus, "DIKEMBALIKAN", StringComparison.OrdinalIgnoreCase))
            {
                AppendLog($"Duplicate scan (already returned): {seal}\r\n", Color.DarkGoldenrod);
                return true;  // still let OnLineReceived send *2#
            }

            // Use active timezone
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);

            // Determine lateness
            DateTime tglInput;
            DateTime.TryParse(lblTglInput.Text, out tglInput);
            bool isLate = tglInput != default(DateTime) && (now - tglInput).TotalHours > 48.0;

            // update the grid’s visual cells
            row.Cells["Tgl_Kembali"].Value = now;
            row.Cells["Status"].Value = "DIKEMBALIKAN";
            row.Cells["Keterangan"].Value = isLate ? "TERLAMBAT" : "TEPAT WAKTU";
            var ketCell = row.Cells["Keterangan"];
            ketCell.Style.BackColor = isLate ? Color.Orange : Color.LightGreen;
            ketCell.Style.ForeColor = Color.Black;

            // update the bound object
            var bound = row.DataBoundItem as CollectItem;
            if (bound != null)
            {
                bound.Tgl_Kembali = now;
                bound.Status = "DIKEMBALIKAN";
                bound.Keterangan = isLate ? "TERLAMBAT" : "TEPAT WAKTU";
                var cm = (CurrencyManager)this.BindingContext[dgvCollectDetail.DataSource];
                cm?.Refresh();
            }

            // remember this seal as processed
            _scannedSeals.Add(seal);

            AppendLog($"OK: {seal} -> DIKEMBALIKAN ({(isLate ? "TERLAMBAT" : "TEPAT WAKTU")})\r\n");
            return true;
        }



        private void AppendLog(string text)
        {
            try { txtSerialLog.AppendText(text); } catch { /* ignore */ }
        }

        // Marks any row with no Tgl_Kembali as HILANG / TIDAK PERNAH KEMBALI and colors it red.
        private void FlagUnreturnedAsMissing()
        {
            // NOTE: if your grid is named differently, change dgvCollectDetail accordingly
            var grid = dgvCollectDetail;
            if (grid == null || grid.Rows.Count == 0) return;

            int marked = 0;
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (r.IsNewRow) continue;

                var status = Convert.ToString(r.Cells["Status"].Value);
                if (string.Equals(status, "DIKEMBALIKAN", StringComparison.OrdinalIgnoreCase))
                    continue;

                DateTime tmp;
                bool hasReturn = TryGetCellDateTime(r.Cells["Tgl_Kembali"].Value, out tmp);
                if (!hasReturn)
                {
                    r.Cells["Status"].Value = "HILANG";
                    r.Cells["Keterangan"].Value = "TIDAK PERNAH KEMBALI";

                    var sCell = r.Cells["Status"];
                    var kCell = r.Cells["Keterangan"];
                    sCell.Style.BackColor = Color.IndianRed;
                    sCell.Style.ForeColor = Color.White;
                    kCell.Style.BackColor = Color.IndianRed;
                    kCell.Style.ForeColor = Color.White;

                    marked++;
                }
            }

            if (marked > 0) AppendLog("Marked " + marked + " unreturned as HILANG.\r\n", Color.IndianRed);
            else AppendLog("No missing items to mark.\r\n");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Push any pending UI edits
            dgvCollectDetail.EndEdit();
            dgvCollectDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            (dgvCollectDetail.DataSource as BindingSource)?.EndEdit();

            // 1) Mark unreturned rows as HILANG before saving (updates grid cells)
            FlagUnreturnedAsMissing();

            // 2) Validate header
            string noPlat = (lblNoPlat.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(noPlat))
            {
                MessageBox.Show("Header belum lengkap (NoPlat).", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse Tgl_Input from label (use your shown format, with fallback)
            DateTime tglInput;
            string rawTgl = (lblTglInput.Text ?? string.Empty).Trim();
            if (!DateTime.TryParseExact(rawTgl, "yyyy-MM-dd HH:mm:ss",
                                        CultureInfo.InvariantCulture, DateTimeStyles.None, out tglInput) &&
                !DateTime.TryParse(rawTgl, out tglInput))
            {
                MessageBox.Show("Header belum lengkap / format tanggal tidak valid (Tgl_Input).", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use a 1-second window to avoid precision mismatch (datetime2 vs label)
            DateTime keyStart = TrimToSeconds(tglInput);
            DateTime keyEnd = keyStart.AddSeconds(1);

            // 3) Read the latest values from the GRID (source of truth)
            var rowsToPersist = dgvCollectDetail.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(RowToCollectItem)   // your helper
                .ToList();

            int updatedDetails = 0;
            int updatedHeader = 0;

            using (var tx = _db.Database.BeginTransaction())
            {
                try
                {
                    // 4) Update each detail row via raw SQL
                    foreach (var it in rowsToPersist)
                    {
                        if (string.IsNullOrWhiteSpace(it.PartID)) continue;

                        // NULL-safe params; keep existing Status/Keterangan if incoming is null/empty
                        var p = new[]
                        {
                    new SqlParameter("@noPlat",    noPlat),
                    new SqlParameter("@partId",    it.PartID),
                    new SqlParameter("@keyStart",  keyStart),
                    new SqlParameter("@keyEnd",    keyEnd),
                    new SqlParameter("@tglKembali",(object)it.Tgl_Kembali ?? DBNull.Value),
                    new SqlParameter("@status",    (object)it.Status ?? DBNull.Value),
                    new SqlParameter("@ket",       (object)it.Keterangan ?? DBNull.Value),
                };

                        // COALESCE(NULLIF(@status,''), d.Status) => keep old if @status is NULL or ''
                        var sql = @"
                            UPDATE d
                               SET d.Tgl_Kembali = @tglKembali,
                                   d.Status      = COALESCE(NULLIF(@status, ''), d.Status),
                                   d.Keterangan  = COALESCE(NULLIF(@ket,    ''), d.Keterangan)
                            FROM TblDetailRegister d
                            WHERE d.NoPlat   = @noPlat
                              AND d.PartID   = @partId
                              AND d.Tgl_Input >= @keyStart AND d.Tgl_Input < @keyEnd;";

                        int n = _db.Database.ExecuteSqlCommand(sql, p);
                        updatedDetails += n;
                    }

                    // 5) Update header status to DIKEMBALIKAN (same key window)
                    {
                        var p = new[]
                        {
                    new SqlParameter("@noPlat",   noPlat),
                    new SqlParameter("@keyStart", keyStart),
                    new SqlParameter("@keyEnd",   keyEnd),
                };

                        var sql = @"
                        UPDATE TblRegister
                           SET Status = 'DIKEMBALIKAN'
                        WHERE NoPlat = @noPlat
                          AND Tgl_Input >= @keyStart AND Tgl_Input < @keyEnd;";

                        updatedHeader = _db.Database.ExecuteSqlCommand(sql, p);
                    }

                    // 6) Reset TblDetailMT for this NoPlat (same TX so all-or-nothing)
                    _db.Database.ExecuteSqlCommand(
                        "UPDATE TblDetailMT SET SealCode='-', Status='-' WHERE NoPlat=@p0",
                        new SqlParameter("@p0", noPlat));

                    // 7) Commit
                    tx.Commit();

                    MessageBox.Show(
                        $"Saved detail rows affected: {updatedDetails}. " +
                        (updatedHeader > 0 ? "Header ditandai DIKEMBALIKAN." : "Header tidak ditemukan."),
                        "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 8) Refresh UI from DB
                    LoadRegister();
                    LoadDetailRegister(noPlat, tglInput);
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { /* ignore */ }
                    MessageBox.Show("Gagal menyimpan data pengembalian.\r\n\r\n" + ex.Message,
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // 9) Switch back to Register tab
                TCRegisterSeal.SelectedTab = TPRegister;

                // 10) Clear Collect tab (labels + grid)
                lblNoPlat.Text = "-";
                lblTglInput.Text = "-";
                lblTujuan.Text = "-";
                lblUserInput.Text = "-";
                lblStatus.Text = "-";

                _collectItems?.Clear();
                dgvCollectDetail.DataSource = null;
                dgvCollectDetail.Rows.Clear();
            }
        }


        private static CollectItem RowToCollectItem(DataGridViewRow r)
        {
            DateTime dt;

            CollectItem ci = new CollectItem();
            ci.PartID = Convert.ToString(r.Cells["PartID"].Value);
            ci.Seal = Convert.ToString(r.Cells["Seal"].Value);
            ci.Status = Convert.ToString(r.Cells["Status"].Value);
            ci.KodeTujuan = Convert.ToString(r.Cells["KodeTujuan"].Value);
            ci.Tujuan = Convert.ToString(r.Cells["Tujuan"].Value);

            if (TryGetCellDateTime(r.Cells["Tgl_Kirim"].Value, out dt))
                ci.Tgl_Kirim = dt;
            else
                ci.Tgl_Kirim = null;

            if (TryGetCellDateTime(r.Cells["Tgl_Kembali"].Value, out dt))
                ci.Tgl_Kembali = dt;
            else
                ci.Tgl_Kembali = null;

            ci.Keterangan = Convert.ToString(r.Cells["Keterangan"].Value);
            return ci;
        }

        private static bool TryGetCellDateTime(object value, out DateTime dt)
        {
            if (value is DateTime)
            {
                dt = (DateTime)value;
                return true;
            }
            return DateTime.TryParse(Convert.ToString(value), out dt);
        }


        private void SafeCloseSerial()
        {
            try { if (SPRegis.IsOpen) SPRegis.Close(); }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void LoadRegister()
        {
            // READ FILTERS
            string term = (txtRegSearch.Text ?? "").Trim();
            string searchBy = cbxRegSearchBy.SelectedItem as string ?? "All";

            DateTime from = dtpRegFrom.Value.Date;
            DateTime toExcl = dtpRegTo.Value.Date.AddDays(1);   // end-exclusive to include the whole "to" day
            if (from > toExcl) { var t = from; from = toExcl.AddDays(-1); toExcl = t.AddDays(1); }

            // BUILD QUERY
            var q = _db.Registers
                .AsNoTracking()
                .Where(r => r.Tgl_Input >= from && r.Tgl_Input < toExcl);

            if (term.Length > 0)
            {
                switch (searchBy)
                {
                    case "NoPlat":
                        q = q.Where(r => r.NoPlat.Contains(term));
                        break;
                    case "Tujuan":
                        q = q.Where(r => r.Tujuan.Contains(term));
                        break;
                    case "Status":
                        q = q.Where(r => r.Status.Contains(term));
                        break;
                    case "UserINPUT":
                        q = q.Where(r => r.UserINPUT.Contains(term));
                        break;
                    default: // "All"
                        q = q.Where(r =>
                            r.NoPlat.Contains(term) ||
                            (r.Tujuan ?? "").Contains(term) ||
                            (r.Status ?? "").Contains(term) ||
                            (r.UserINPUT ?? "").Contains(term));
                        break;
                }
            }

            var registerlist = q
                .OrderBy(r => r.NoPlat)
                .ThenByDescending(r => r.Tgl_Input)
                .ToList();

            // BIND
            dgvRegister.AutoGenerateColumns = true;
            dgvRegister.DataSource = registerlist;

            dgvRegister.SelectionChanged -= dgvRegister_SelectionChanged;
            dgvRegister.SelectionChanged += dgvRegister_SelectionChanged;



            HideRegisterNavColumns();

            if (dgvRegister.Rows.Count > 0)
                dgvRegister.Rows[0].Selected = true;
            DataGridViewHelper.ApplyDefaultStyle(dgvRegister);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailRegister);
            dgvRegister.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvRegister.AllowUserToResizeColumns = true;
            dgvDetailRegister.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDetailRegister.AllowUserToResizeColumns = true;
        }

        private void HideRegisterNavColumns()
        {
            if (dgvRegister.Columns.Contains("MobilTangki"))
                dgvRegister.Columns["MobilTangki"].Visible = false;
            if (dgvRegister.Columns.Contains("User"))
                dgvRegister.Columns["User"].Visible = false;
            if (dgvRegister.Columns.Contains("DetailRegisters"))
                dgvRegister.Columns["DetailRegisters"].Visible = false;
        }

        private void CollectSealForm_Load(object sender, EventArgs e)
        {
            InitRegisterSearchUi();
            InitSerialUi();
            LoadRegister();
            DataGridViewHelper.ApplyDefaultStyle(dgvRegister);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailRegister);
            DataGridViewHelper.ApplyDefaultStyle(dgvCollectDetail, true, true);
            dgvCollectDetail.CellFormatting += (s, ev) => dgvCollectDetail_CellFormatting(s, ev);
            
        }

        private void dgvRegister_SelectionChanged(object sender, EventArgs e)
        {
            var item = dgvRegister.CurrentRow?.DataBoundItem as TblRegister;
            if (item == null) return;

            // If exact DateTime equality fails in your DB, use the day-range version below
            LoadDetailRegister(item.NoPlat, item.Tgl_Input);
        }

        private void dgvCollectDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCollectDetail.Columns[e.ColumnIndex].DataPropertyName == "Keterangan")
            {
                var txt = Convert.ToString(e.Value);
                var cell = dgvCollectDetail.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (txt.Contains("TERLAMBAT"))
                {
                    cell.Style.BackColor = Color.Orange;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (txt.Contains("TEPAT WAKTU"))
                {
                    cell.Style.BackColor = Color.LightGreen;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (txt.Contains("TIDAK PERNAH KEMBALI"))
                {
                    cell.Style.BackColor = Color.IndianRed;   // good warning red
                    cell.Style.ForeColor = Color.White;
                }
            }
        }

        private void dgvDetailRegister_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDetailRegister.Columns[e.ColumnIndex].DataPropertyName == "Keterangan")
            {
                var txt = Convert.ToString(e.Value);
                var cell = dgvDetailRegister.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (txt.Contains("TERLAMBAT"))
                {
                    cell.Style.BackColor = Color.Orange;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (txt.Contains("TEPAT WAKTU"))
                {
                    cell.Style.BackColor = Color.LightGreen;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (txt.Contains("TIDAK PERNAH KEMBALI"))
                {
                    cell.Style.BackColor = Color.IndianRed;   // good warning red
                    cell.Style.ForeColor = Color.White;
                }
            }
        }

        private void LoadDetailRegister(string noPlat, DateTime tglInput)
        {
            //var start = tglInput.Date;
            //var end = start.AddDays(1);

            var key = TrimToSeconds(tglInput); // see helper below

            var details =
                    (from d in _db.DetailRegisters.AsNoTracking()
                     where d.NoPlat == noPlat
                        && DbFunctions.DiffSeconds(d.Tgl_Input, key) == 0
                     join m in _db.DetailMT.AsNoTracking()
                       on new { d.NoPlat, d.PartID } equals new { m.NoPlat, m.PartID } into gj
                     from m in gj.DefaultIfEmpty()
                     orderby (m.PartIndex ?? int.MaxValue), d.PartID
                     select new
                     {
                         PartIndex = (int?)m.PartIndex,
                         d.PartID,
                         d.Seal,
                         d.Status,
                         d.KodeTujuan,
                         d.Tujuan,
                         d.Tgl_Kirim,
                         d.Tgl_Kembali,
                         d.Keterangan
                     })
                    .ToList();

            dgvDetailRegister.AutoGenerateColumns = true;
            dgvDetailRegister.DataSource = details;
            if (dgvDetailRegister.Rows.Count > 0)
            {
                dgvDetailRegister.ClearSelection();
                dgvDetailRegister.Rows[0].Selected = true;
            }
            DataGridViewHelper.ApplyDefaultStyle(dgvRegister);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailRegister);
            dgvRegister.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvRegister.AllowUserToResizeColumns = true;
            dgvDetailRegister.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDetailRegister.AllowUserToResizeColumns = true;
        }

        private static DateTime TrimToSeconds(DateTime dt)
        {
            // drop sub-second ticks, keep Kind (Unspecified/Local/UTC)
            return new DateTime(dt.Ticks - (dt.Ticks % TimeSpan.TicksPerSecond), dt.Kind);
        }

        private void InitRegisterSearchUi()
        {
            // Search-by options
            cbxRegSearchBy.Items.Clear();
            cbxRegSearchBy.Items.AddRange(new object[] { "All", "NoPlat", "Tujuan", "Status", "UserINPUT" });
            cbxRegSearchBy.SelectedIndex = 0;

            // Default date range (last 7 days)
            dtpRegFrom.Value = DateTime.Today.AddDays(-7);
            dtpRegTo.Value = DateTime.Today;

            // Small debounce so we don't hammer the DB while typing
            _regSearchTimer = new System.Windows.Forms.Timer { Interval = 300 };
            _regSearchTimer.Tick += (s, e) => { _regSearchTimer.Stop(); LoadRegister(); };

            // Events
            txtRegSearch.TextChanged += (s, e) => { _regSearchTimer.Stop(); _regSearchTimer.Start(); };
            cbxRegSearchBy.SelectedIndexChanged += (s, e) => LoadRegister();
            dtpRegFrom.ValueChanged += (s, e) => LoadRegister();
            dtpRegTo.ValueChanged += (s, e) => LoadRegister();
        }

        

        private void UpCard_Paint(object sender, PaintEventArgs e)
        {

        }

        // ================== CLEAR LOG ==================
        private void btnClearLog_Click(object sender, EventArgs e) => txtSerialLog.Text = "";

        private void btnCollect_Click(object sender, EventArgs e)
        {
            var sel = dgvRegister.CurrentRow?.DataBoundItem as TblRegister;
            if (sel == null)
            {
                MessageBox.Show("Select a register row first.", "Collect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadDataRegisternDetail(sel.NoPlat, sel.Tgl_Input);
            TCRegisterSeal.SelectedTab = TPCollectSeal; // navigate to the Collect tab
        }

        /// <summary>
        /// Fills Collect tab header labels and binds detail rows.
        /// Uses day-range matching for Tgl_Input to handle precision.
        /// </summary>
        private void LoadDataRegisternDetail(string noPlat, DateTime tglInput)
        {
            // 1) Fetch the register row (within same day)
            //var start = tglInput.Date;
            //var end = start.AddDays(1);
            var key = TrimToSeconds(tglInput); // see helper below

            var reg = _db.Registers
                         .AsNoTracking()
                         .Where(r => r.NoPlat == noPlat && DbFunctions.DiffSeconds(r.Tgl_Input, key) == 0)
                         .OrderByDescending(r => r.Tgl_Input)
                         .FirstOrDefault();

            if (reg != null)
            {
                _currentNoPlat = reg.NoPlat;
                _currentTglInputKey = reg.Tgl_Input;                 // exact value from DB
            }
            else
            {
                _currentNoPlat = noPlat;
                _currentTglInputKey = TrimToSeconds(tglInput);       // fallback
            }

            // 2) Fill labels (fallbacks to "-")
            lblNoPlat.Text = reg?.NoPlat ?? "-";
            lblTglInput.Text = (reg?.Tgl_Input ?? tglInput).ToString("yyyy-MM-dd HH:mm:ss");
            lblTujuan.Text = string.IsNullOrWhiteSpace(reg?.Tujuan) ? "-" : reg.Tujuan;
            lblUserInput.Text = string.IsNullOrWhiteSpace(reg?.UserINPUT) ? "-" : reg.UserINPUT;
            lblStatus.Text = string.IsNullOrWhiteSpace(reg?.Status) ? "-" : reg.Status;

            // Load Details
            var details =(from d in _db.DetailRegisters.AsNoTracking()
                             where d.NoPlat == noPlat && DbFunctions.DiffSeconds(d.Tgl_Input, key) == 0
                          join m in _db.DetailMT.AsNoTracking()
                                on new { d.NoPlat, d.PartID } equals new { m.NoPlat, m.PartID } into gj
                             from m in gj.DefaultIfEmpty()
                             orderby (m.PartIndex ?? int.MaxValue), d.PartID
                             select new CollectItem
                             {
                                 PartIndex = m.PartIndex,
                                 PartID = d.PartID,
                                 Seal = d.Seal,
                                 Status = d.Status,
                                 KodeTujuan = d.KodeTujuan,
                                 Tujuan = d.Tujuan,
                                 Tgl_Kirim = d.Tgl_Kirim,
                                 Tgl_Kembali = d.Tgl_Kembali,
                                 Keterangan = d.Keterangan
                             })
                            .ToList();

            _collectItems = new BindingList<CollectItem>(details);
            dgvCollectDetail.AutoGenerateColumns = true;
            dgvCollectDetail.DataSource = _collectItems;

            // nice readable date/time in the grid
            if (dgvCollectDetail.Columns.Contains("Tgl_Kembali"))
                dgvCollectDetail.Columns["Tgl_Kembali"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";


            // Optional cosmetics
            dgvCollectDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCollectDetail.AllowUserToResizeColumns = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var dlg = new FindRegisterForm(_db)
            {
                InitialTerm = txtRegSearch.Text,
                InitialSearchBy = cbxRegSearchBy.SelectedItem as string ?? "All",
                InitialFrom = dtpRegFrom.Value.Date,
                InitialTo = dtpRegTo.Value.Date
            })
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    // Same as btnCollect_Click, but no tab switch (we are already on TPCollectSeal)
                    LoadDataRegisternDetail(dlg.SelectedNoPlat, dlg.SelectedTglInput);
                }
            }
        }

        private void btnDisposeSeal_Click(object sender, EventArgs e)
        {
            var sel = dgvRegister.CurrentRow?.DataBoundItem as TblRegister;
            if (sel == null)
            {
                MessageBox.Show("Select a register row first.", "Collect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadDataRegisternDetail(sel.NoPlat, sel.Tgl_Input);
            TCRegisterSeal.SelectedTab = TPCollectSeal; // navigate to the Collect tab
        }

       
    }
}
