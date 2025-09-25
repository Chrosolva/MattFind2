using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SEALCHK.Model;
using SEALCHK.Data;
using System.Data.Entity; // EF6: AsNoTracking, etc.
using System.Data.SqlClient; // for SqlParameter
using System.IO.Ports;

namespace SEALCHK.View
{
    public partial class HistoryForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        private Timer _debounce;
        private SerialPort SPRegis => Session.GlobalPort;

        // Row model for the DataGridView
        private sealed class HistoryRow
        {
            // NEW: checkbox state in the first column
            public bool Sel { get; set; }  // default false
            // Header (TblRegister)
            public DateTime Tgl_Input { get; set; }
            public string NoPlat { get; set; }
            public string RegTujuan { get; set; }
            public string RegStatus { get; set; }
            public string UserINPUT { get; set; }
            public string UserOUT { get; set; }

            // Detail (TblDetailRegister) + PartIndex from TblDetailMT (left join)
            public int? PartIndex { get; set; }
            public string PartID { get; set; }
            public string Seal { get; set; }
            public string DetailStatus { get; set; }
            public string KodeTujuan { get; set; }
            public string Tujuan { get; set; }
            public DateTime? Tgl_Kirim { get; set; }
            public DateTime? Tgl_Kembali { get; set; }
            public string Keterangan { get; set; }
            public DateTime? Tgl_Keluar { get; set; }
        }

        public HistoryForm()
        {
            InitializeComponent();

            
            // Debounce typing to avoid hammering the DB
            _debounce = new Timer();
            _debounce.Interval = 250;
            _debounce.Tick += delegate { _debounce.Stop(); LoadHistory(); };

            // Wire UI events (assumes controls exist in Designer)
            this.Load += HistoryForm_Load;

            txtSearch.TextChanged += delegate { _debounce.Stop(); _debounce.Start(); };
            cbxSearchBy.SelectedIndexChanged += delegate { LoadHistory(); };
            dtpFrom.ValueChanged += delegate { LoadHistory(); };
            dtpTo.ValueChanged += delegate { LoadHistory(); };
            btnFilter.Click += delegate { LoadHistory(); };

            // Configure the grid a bit
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoGenerateColumns = true;

            // Populate the search-by list (safe defaults if already filled in designer)
            if (cbxSearchBy.Items.Count == 0)
            {
                cbxSearchBy.Items.AddRange(new object[]
                {
                    "All", "NoPlat", "PartID", "Seal", "Tujuan", "Status", "UserINPUT", "KodeTujuan", "Keterangan", "Tgl_Input"
                });
                cbxSearchBy.SelectedIndex = 0;
            }

            
        }

        private void InitSerialUi()
        {
            UpdateUiForPortState(true);
        }

        private void SafeCloseSerial()
        {
            try { if (SPRegis.IsOpen) SPRegis.Close(); }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void UpdateUiForPortState(bool connected)
        {
            lblPortStatus.Text = connected
                ? "Connected: " + SPRegis.PortName + " @ " + SPRegis.BaudRate
                : "Disconnected";
            lblPortStatus.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            InitSerialUi();
            // Reasonable default date window
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today.AddDays(1);

            // If you have a helper, you can style here (optional)
            // try { DataGridViewHelper.ApplyDefaultStyle(dgv); } catch { }

            LoadHistory();
            DataGridViewHelper.ApplyDefaultStyle(dgv, false, true);

        }

        private void LoadHistory()
        {
            // 1) Read filters
            string term = (txtSearch.Text ?? string.Empty).Trim();
            string by = cbxSearchBy.SelectedItem as string ?? "All";

            DateTime dtFrom = dtpFrom.Value;
            DateTime dtTo = dtpTo.Value;
            if (dtFrom > dtTo)
            {
                DateTime tmp = dtFrom; dtFrom = dtTo; dtTo = tmp;
            }
            DateTime dtToExcl = dtTo.AddMinutes(1);

            // 2) Base query: INNER JOIN Register + DetailRegister (by exact Tgl_Input)
            //    LEFT JOIN DetailMT to bring PartIndex (for ordering)
            var q =
                from r in _db.Registers.AsNoTracking()
                join d in _db.DetailRegisters.AsNoTracking()
                    on new { r.NoPlat, r.Tgl_Input } equals new { d.NoPlat, d.Tgl_Input }
                join mJoin in _db.DetailMT.AsNoTracking()
                    on new { d.NoPlat, d.PartID } equals new { mJoin.NoPlat, mJoin.PartID } into mG
                from m in mG.DefaultIfEmpty()
                where r.Tgl_Input >= dtFrom && r.Tgl_Input < dtToExcl
                select new HistoryRow
                {
                    Sel = false,                    // NEW
                    Tgl_Input = r.Tgl_Input,
                    NoPlat = r.NoPlat,
                    RegTujuan = r.Tujuan,
                    RegStatus = r.Status,
                    UserINPUT = r.UserINPUT,

                    PartIndex = m.PartIndex,
                    PartID = d.PartID,
                    Seal = d.Seal,
                    DetailStatus = d.Status,
                    KodeTujuan = d.KodeTujuan,
                    Tujuan = d.Tujuan,
                    Tgl_Kirim = d.Tgl_Kirim,
                    Tgl_Kembali = d.Tgl_Kembali,
                    Keterangan = d.Keterangan,
                    UserOUT = r.UserOUT,
                    Tgl_Keluar = d.Tgl_Keluar
                };


            // 3) Apply search term
            if (term.Length > 0)
            {
                switch (by)
                {
                    case "NoPlat":
                        q = q.Where(x => x.NoPlat.Contains(term));
                        break;

                    case "PartID":
                        q = q.Where(x => (x.PartID ?? "").Contains(term));
                        break;

                    case "Seal":
                        q = q.Where(x => (x.Seal ?? "").Contains(term));
                        break;

                    case "Tujuan": // match header tujuan OR detail tujuan/kode
                        q = q.Where(x =>
                            (x.RegTujuan ?? "").Contains(term) ||
                            (x.Tujuan ?? "").Contains(term) ||
                            (x.KodeTujuan ?? "").Contains(term));
                        break;

                    case "Status": // match header OR detail status
                        q = q.Where(x =>
                            (x.RegStatus ?? "").Contains(term) ||
                            (x.DetailStatus ?? "").Contains(term));
                        break;

                    case "UserINPUT":
                        q = q.Where(x => (x.UserINPUT ?? "").Contains(term));
                        break;

                    case "KodeTujuan":
                        q = q.Where(x => (x.KodeTujuan ?? "").Contains(term));
                        break;

                    case "Keterangan":
                        q = q.Where(x => (x.Keterangan ?? "").Contains(term));
                        break;

                    case "Tgl_Input":
                        DateTime parsed;
                        if (DateTime.TryParse(term, out parsed))
                        {
                            q = q.Where(x => DbFunctions.TruncateTime(x.Tgl_Input) == parsed.Date);
                        }
                        break;


                    default: // "All"
                             // First, handle text fields in SQL
                        var qText = q.Where(x =>
                            x.NoPlat.Contains(term) ||
                            (x.PartID ?? "").Contains(term) ||
                            (x.Seal ?? "").Contains(term) ||
                            (x.RegTujuan ?? "").Contains(term) ||
                            (x.Tujuan ?? "").Contains(term) ||
                            (x.KodeTujuan ?? "").Contains(term) ||
                            (x.RegStatus ?? "").Contains(term) ||
                            (x.DetailStatus ?? "").Contains(term) ||
                            (x.UserINPUT ?? "").Contains(term) ||
                            (x.Keterangan ?? "").Contains(term)
                        );

                        // Try parse the search term as date
                        DateTime parsed2;
                        if (DateTime.TryParse(term, out parsed2))
                        {
                            // extend by 1 day to cover the whole date
                            DateTime start = parsed2.Date;
                            DateTime end = start.AddDays(1);

                            q = q.AsEnumerable()
                                 .Where(x => x.Tgl_Input.ToString("yyyy-MM-dd HH:mm:ss").Contains(term))
                                 .AsQueryable();
                        }
                        else
                        {
                            q = qText;
                        }
                        break;
                }
            }

            // 4) Order: Tgl_Input DESC, PartIndex ASC (nulls last), PartID ASC
            List<HistoryRow> rows = q
                .OrderByDescending(x => x.Tgl_Input)
                .ThenBy(x => x.PartIndex.HasValue ? x.PartIndex.Value : int.MaxValue)
                .ThenBy(x => x.PartID)
                .ToList();

            // 5) Bind
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = rows;

            // 6) Row count
            lblRowCount.Text = "Rows: " + rows.Count;

            // 7) Date/Time display format (optional)
            if (dgv.Columns.Contains("Tgl_Input"))
                dgv.Columns["Tgl_Input"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            if (dgv.Columns.Contains("Tgl_Kirim"))
                dgv.Columns["Tgl_Kirim"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            if (dgv.Columns.Contains("Tgl_Kembali"))
                dgv.Columns["Tgl_Kembali"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            // Optional cosmetics
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.AllowUserToResizeColumns = true;

            EnsureCheckboxAsFirstColumn(dgv);
            EnableOnlyFirstCheckboxColumnClickable(dgv);
        }

        private void EnsureCheckboxAsFirstColumn(DataGridView grid)
        {
            // If already present, ensure it's first and writable
            if (grid.Columns.Contains("Sel"))
            {
                var col = grid.Columns["Sel"];
                if (!(col is DataGridViewCheckBoxColumn))
                {
                    grid.Columns.Remove(col);
                }
                else
                {
                    col.DisplayIndex = 0;
                    col.ReadOnly = false;
                    return;
                }
            }

            var chk = new DataGridViewCheckBoxColumn
            {
                Name = "Sel",
                DataPropertyName = "Sel",
                HeaderText = "",
                Width = 40,
                ReadOnly = false
            };

            grid.Columns.Insert(0, chk);
        }


        // Call this AFTER you bind the grid (so columns exist).
        private void EnableOnlyFirstCheckboxColumnClickable(DataGridView grid)
        {
            if (grid.Columns.Count == 0)
                return;

            // Ensure the first column is a checkbox
            var chkCol = grid.Columns[0] as DataGridViewCheckBoxColumn;
            if (chkCol == null)
                throw new InvalidOperationException("First column must be a DataGridViewCheckBoxColumn.");

            int chkIdx = 0;

            // Apply read-only + styling to all non-first columns
            Action applyLock = () =>
            {
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    var col = grid.Columns[i];
                    bool isCheckbox = (i == chkIdx);

                    col.ReadOnly = !isCheckbox;

                    // Visual hint for locked columns
                    //col.DefaultCellStyle.BackColor = isCheckbox
                    //    ? grid.DefaultCellStyle.BackColor
                    //    : Color.Gainsboro;
                    //col.DefaultCellStyle.ForeColor = isCheckbox
                    //    ? grid.DefaultCellStyle.ForeColor
                    //    : Color.DarkGray;
                }
            };

            // Commit checkbox change immediately
            grid.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (grid.IsCurrentCellDirty)
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // Block editing anywhere except the first column
            grid.CellBeginEdit += (s, e) =>
            {
                if (e.ColumnIndex != chkIdx)
                    e.Cancel = true;
            };

            // If user clicks a non-checkbox cell, jump focus to the checkbox in that row
            grid.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex != chkIdx)
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[chkIdx];
            };

            // Re-apply rule after data binding completes
            grid.DataBindingComplete += (s, e) => applyLock();

            // Make it easy to toggle on focus
            grid.EditMode = DataGridViewEditMode.EditOnEnter;

            // Initial apply
            applyLock();
        }

        private static DateTime TrimToSeconds(DateTime dt)
        {
            return new DateTime(dt.Ticks - (dt.Ticks % TimeSpan.TicksPerSecond), dt.Kind);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Keterangan")
            {
                var txt = Convert.ToString(e.Value);
                var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];

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

        private void btnAppend_Click(object sender, EventArgs e)
        {
            // Commit any pending checkbox changes
            dgv.EndEdit();
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);

            // Read text to append
            string extra = (txtAppend.Text ?? "").Trim();
            if (extra.Length == 0)
            {
                MessageBox.Show("Masukkan teks yang akan ditambahkan ke Keterangan.", "Append",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Collect chosen rows
            var rows = (dgv.DataSource as IEnumerable<HistoryRow>)?.Where(r => r.Sel).ToList() ?? new List<HistoryRow>();
            if (rows.Count == 0)
            {
                MessageBox.Show("Belum ada baris yang dipilih (kolom checkbox).", "Append",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int affected = 0;

            using (var tx = _db.Database.BeginTransaction())
            {
                try
                {
                    foreach (var r in rows)
                    {
                        // key window tolerant to sub-second diffs
                        var keyStart = TrimToSeconds(r.Tgl_Input);
                        var keyEnd = keyStart.AddSeconds(1);

                        var p = new[]
                        {
                    new SqlParameter("@noPlat",   r.NoPlat ?? (object)DBNull.Value),
                    new SqlParameter("@partId",   r.PartID ?? (object)DBNull.Value),
                    new SqlParameter("@keyStart", keyStart),
                    new SqlParameter("@keyEnd",   keyEnd),
                    new SqlParameter("@append",   extra),
                };

                        string sql = @"
                                    UPDATE d
                                       SET d.Keterangan =
                                           CASE
                                               WHEN d.Keterangan IS NULL OR LTRIM(RTRIM(d.Keterangan)) = ''
                                                    THEN @append
                                               ELSE
                                                    -- Take only the first token before first '|' (the base/original status)
                                                    LEFT(d.Keterangan, 
                                                        CASE 
                                                            WHEN CHARINDEX('|', d.Keterangan) > 0 
                                                            THEN CHARINDEX('|', d.Keterangan) - 1 
                                                            ELSE LEN(d.Keterangan)
                                                        END
                                                    ) + N' | ' + @append
                                           END
                                    FROM TblDetailRegister d
                                    WHERE d.NoPlat   = @noPlat
                                      AND d.PartID   = @partId
                                      AND d.Tgl_Input >= @keyStart AND d.Tgl_Input < @keyEnd;";


                        affected += _db.Database.ExecuteSqlCommand(sql, p);
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { /* ignore */ }
                    MessageBox.Show("Gagal meng-update Keterangan.\r\n\r\n" + ex.Message, "Append Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show($"Updated rows: {affected}", "Append", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh and keep UX clean
            LoadHistory();
            txtAppend.Clear();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            var rows = dgv.DataSource as System.Collections.IEnumerable;
            if (rows == null) return;

            bool check = chkAll.Checked;

            // Flip Sel for each bound row
            foreach (var obj in rows)
            {
                var r = obj as HistoryRow;
                if (r != null) r.Sel = check;
            }

            // Refresh grid
            dgv.Refresh();
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            // Ensure there are selected rows
            var selected = (dgv.DataSource as System.Collections.IEnumerable)?
                           .Cast<HistoryRow>()
                           .Where(r => r.Sel)
                           .ToList() ?? new List<HistoryRow>();

            if (selected.Count == 0)
            {
                MessageBox.Show("Pilih baris terlebih dahulu (checkbox).", "Dispose",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Admin verification
            using (var dlg = new VerifyDispose())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
            }

            // Time (use your active timezone)
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);
            string userOut = Session.VerifiedAdmin?.UserID ?? "-";

            // We will update:
            // - Details ONLY if BaseStatus in ('TEPAT WAKTU','TERLAMBAT')
            // - Each affected header's UserOUT

            int updDetails = 0;
            int updHeaders = 0;

            // Distinct header keys for the selected rows
            var headerKeys = selected
                .Select(r => new { r.NoPlat, KeyStart = TrimToSeconds(r.Tgl_Input), KeyEnd = TrimToSeconds(r.Tgl_Input).AddSeconds(1) })
                .Distinct()
                .ToList();

            using (var tx = _db.Database.BeginTransaction())
            {
                try
                {
                    // 1) Update details for each selected row, but ONLY when base status is TW/TL
                    foreach (var r in selected)
                    {
                        // base status extraction happens inside SQL to avoid round-trips
                        DateTime keyStart = TrimToSeconds(r.Tgl_Input);
                        DateTime keyEnd = keyStart.AddSeconds(1);

                        var p = new[]
                        {
                    new SqlParameter("@noPlat",   r.NoPlat),
                    new SqlParameter("@partId",   r.PartID ?? (object)DBNull.Value),
                    new SqlParameter("@keyStart", keyStart),
                    new SqlParameter("@keyEnd",   keyEnd),
                    new SqlParameter("@now",      now)
                };

                        // SQL rules:
                        // - Compute BaseStatus = LEFT(Keterangan, before first '|'), trimmed
                        // - If BaseStatus in ('TEPAT WAKTU','TERLAMBAT'):
                        //      Tgl_Keluar = @now
                        //      Status     = 'DIKELUARKAN'
                        //      Keterangan = 'TELAH DIKELUARKAN | ' + BaseStatus
                        string sql = @"
UPDATE d
   SET d.Tgl_Keluar = @now,
       d.Status     = N'DIKELUARKAN',
       d.Keterangan = N'TELAH DIKELUARKAN | ' + 
                      LTRIM(RTRIM(
                          CASE WHEN CHARINDEX('|', d.Keterangan) > 0
                               THEN LEFT(d.Keterangan, CHARINDEX('|', d.Keterangan) - 1)
                               ELSE d.Keterangan
                          END))
FROM TblDetailRegister d
WHERE d.NoPlat    = @noPlat
  AND d.PartID    = @partId
  AND d.Tgl_Input >= @keyStart AND d.Tgl_Input < @keyEnd
  AND UPPER(LTRIM(RTRIM(
          CASE WHEN CHARINDEX('|', d.Keterangan) > 0
               THEN LEFT(d.Keterangan, CHARINDEX('|', d.Keterangan) - 1)
               ELSE d.Keterangan
          END))) IN (N'TEPAT WAKTU', N'TERLAMBAT');";

                        updDetails += _db.Database.ExecuteSqlCommand(sql, p);
                    }

                    // 2) Update header UserOUT for each affected register once
                    foreach (var hk in headerKeys)
                    {
                        var p = new[]
                        {
                    new SqlParameter("@noPlat", hk.NoPlat),
                    new SqlParameter("@keyStart", hk.KeyStart),
                    new SqlParameter("@keyEnd", hk.KeyEnd),
                    new SqlParameter("@userOut", userOut)
                };

                        string sqlHeader = @"
UPDATE TblRegister
   SET UserOUT = @userOut
WHERE NoPlat = @noPlat
  AND Tgl_Input >= @keyStart AND Tgl_Input < @keyEnd;";

                        updHeaders += _db.Database.ExecuteSqlCommand(sqlHeader, p);
                    }

                    tx.Commit();

                    if(SPRegis.IsOpen)
                    {
                        SPRegis.Write("*1#");
                    }
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { /* ignore */ }
                    MessageBox.Show("Gagal memproses Dispose.\r\n\r\n" + ex.Message,
                        "Dispose Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show($"Dispose selesai.\r\nDetail updated: {updDetails}\r\nHeader updated: {updHeaders}",
                "Dispose", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the grid
            LoadHistory();
        }
    }
}
