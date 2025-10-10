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
using DEPTHCHK.Data;
using DEPTHCHK.Models;
using System.Text.RegularExpressions; // <— add this
using System.Data.Entity;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using System.Timers;
using System.Threading;

namespace DEPTHCHK.Views
{

    public partial class PengirimanForm : Form
    {
        private depthchkDBContext _db;
        private BindingSource _bsPeng = new BindingSource();
        private BindingSource _bsDetail = new BindingSource();
        private bool _loadingMaster;
        private string[] _compartmentKodeTujuan;
        private string[] _compartmentNamaTujuan;

        private SerialPort _serialPort => Session.GlobalPort;
        private SerialDataReceivedEventHandler _dataReceivedHandler;
        private bool _listening = false;

        private StringBuilder _serialBuffer = new StringBuilder();
        private string _currentPartID;      // PartID of the last selected compartment
        private List<LiveRow> _liveRows;    // holds rows shown in dgvPengirimanLive

        // row shape for dgvPengirimanLive
        private class LiveRow
        {
            public string IDPengiriman { get; set; }
            public DateTime? Tgl_Input { get; set; }
            public string NoPlat { get; set; }
            public string PartID { get; set; }
            public string CompartmentID { get; set; }
            public decimal DataBacaan { get; set; }
            public decimal DataKalibrasi { get; set; }
            public string Satuan { get; set; }
            public string Keterangan { get; set; }
            public string KodeTujuan { get; set; }
            public decimal Kalibrasi { get; set; }
            public bool positive { get; set; }
        }



        // simple combo item type (avoid anonymous types binding)
        private class ComboItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
        }

        // grid row shapes (POCOs)
        private class PengirimanRow
        {
            public string IDPengiriman { get; set; }
            public DateTime? Tgl_Input { get; set; }
            public string NoPlat { get; set; }
            public string Tujuan { get; set; }
            public string Status { get; set; }
            public string UserID { get; set; }
            public string UserName { get; set; }
            public string Keterangan { get; set; }
            public int DetailCount { get; set; }
        }

        private class DetailPengirimanRow
        {
            public string IDPengiriman { get; set; }
            public DateTime? Tgl_Input { get; set; }
            public string NoPlat { get; set; }
            public string PartID { get; set; }
            public string CompartmentID { get; set; }
            public decimal? DataBacaan { get; set; }
            public decimal? DataKalibrasi { get; set; }
            public string Satuan { get; set; }
            public string Keterangan { get; set; }
        }

        private void InitSerialUi()
        {
            if (_dataReceivedHandler == null)
            {
                _dataReceivedHandler = _serialPort_DataReceived;
                _serialPort.DataReceived += _dataReceivedHandler;
                _serialPort.ErrorReceived += _serialPort_ErrorReceived;
                _serialPort.PinChanged += _serialPort_PinChanged;
            }

            if (_serialPort.IsOpen)
            {
                UpdateUiForPortState(true);
            }
            else
            {
                UpdateUiForPortState(false);
            }

            // Buttons
            btnStartListen.Click += btnStartListen_Click;
            btnSave.Click += btnSave_Click;
        }

        public PengirimanForm()
        {
            InitializeComponent();
        }

        private void PengirimanForm_Load(object sender, EventArgs e)
        {
            InitSerialUi();
            _db = new depthchkDBContext();

            SetupSearchCombo();
            SetupGrids();

            // default dates
            dtpPengFrom.Value = DateTime.Today.AddDays(-14);
            dtpPengTo.Value = DateTime.Today;

            // hook events (named handlers; no lambdas)
            cbxPengSearchBy.SelectedIndexChanged += cbxPengSearchBy_SelectedIndexChanged;
            dtpPengFrom.ValueChanged += dtpPengFrom_ValueChanged;
            dtpPengTo.ValueChanged += dtpPengTo_ValueChanged;
            txtSearchPeng.KeyDown += txtSearchPeng_KeyDown;
            dgvPengiriman.SelectionChanged += dgvPengiriman_SelectionChanged;

            DataGridViewHelper.ApplyDefaultStyle(dgvPengiriman);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailPengiriman);
            DataGridViewHelper.ApplyDefaultStyle(dgvPengirimanLive, false);

            ReloadPengiriman();


        }

        private void SetupSearchCombo()
        {
            List<ComboItem> items = new List<ComboItem>();
            items.Add(new ComboItem { Text = "ID Pengiriman", Value = "IDPengiriman" });
            items.Add(new ComboItem { Text = "No Plat", Value = "NoPlat" });
            items.Add(new ComboItem { Text = "Tujuan", Value = "Tujuan" });
            items.Add(new ComboItem { Text = "Status", Value = "Status" });
            items.Add(new ComboItem { Text = "User ID", Value = "UserID" });

            cbxPengSearchBy.DisplayMember = "Text";
            cbxPengSearchBy.ValueMember = "Value";
            cbxPengSearchBy.DataSource = items;
            cbxPengSearchBy.SelectedValue = "IDPengiriman";
        }

        private void SetupGrids()
        {
            dgvPengiriman.AutoGenerateColumns = true;
            dgvPengiriman.DataSource = _bsPeng;
            dgvPengiriman.ReadOnly = true;
            dgvPengiriman.MultiSelect = false;
            dgvPengiriman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengiriman.DataBindingComplete += dgvPengiriman_DataBindingComplete;

            dgvDetailPengiriman.AutoGenerateColumns = true;
            dgvDetailPengiriman.DataSource = _bsDetail;
            dgvDetailPengiriman.ReadOnly = true;
            dgvDetailPengiriman.MultiSelect = false;
            dgvDetailPengiriman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailPengiriman.DataBindingComplete += dgvDetailPengiriman_DataBindingComplete;
        }

        private void dgvPengiriman_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TryFormatColumn(dgvPengiriman, "Tgl_Input", "yyyy-MM-dd HH:mm:ss.fff");
            AutoFit(dgvPengiriman);
        }

        private void dgvDetailPengiriman_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TryFormatColumn(dgvDetailPengiriman, "Tgl_Input", "yyyy-MM-dd HH:mm:ss.fff");
            TryFormatColumn(dgvDetailPengiriman, "DataBacaan", "0.##");
            TryFormatColumn(dgvDetailPengiriman, "DataKalibrasi", "0.##");
            TryFormatColumn(dgvDetailPengiriman, "Kalibrasi", "0.##");
            AutoFit(dgvDetailPengiriman);
        }

        private static void TryFormatColumn(DataGridView dgv, string columnName, string format)
        {
            if (dgv.Columns.Contains(columnName))
                dgv.Columns[columnName].DefaultCellStyle.Format = format;
        }

        private static void AutoFit(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (dgv.Columns.Count > 0)
                dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ReloadPengiriman()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _loadingMaster = true;

                DateTime from = dtpPengFrom.Value.Date;
                DateTime toExclusive = dtpPengTo.Value.Date.AddDays(1);

                string term = (txtSearchPeng.Text == null) ? "" : txtSearchPeng.Text.Trim();
                string by = (cbxPengSearchBy.SelectedValue == null) ? null : cbxPengSearchBy.SelectedValue.ToString();

                IQueryable<TblPengiriman> q = _db.Pengirimans
                    .AsNoTracking()
                    .Include(p => p.User)
                    .Where(p => p.Tgl_Input >= from && p.Tgl_Input < toExclusive)
                    .OrderByDescending(p => p.Tgl_Input)
                    .ThenBy(p => p.IDPengiriman);

                if (!string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(by))
                {
                    if (by == "IDPengiriman")
                        q = q.Where(p => p.IDPengiriman.Contains(term));
                    else if (by == "NoPlat")
                        q = q.Where(p => p.NoPlat.Contains(term));
                    else if (by == "Tujuan")
                        q = q.Where(p => p.Tujuan.Contains(term));
                    else if (by == "Status")
                        q = q.Where(p => p.Status.Contains(term));
                    else if (by == "UserID")
                        q = q.Where(p => p.UserID.Contains(term));
                }

                List<PengirimanRow> data =
                    q.Select(p => new PengirimanRow
                    {
                        IDPengiriman = p.IDPengiriman,
                        Tgl_Input = p.Tgl_Input,
                        NoPlat = p.NoPlat,
                        Tujuan = p.Tujuan,
                        Status = p.Status,
                        UserID = p.UserID,
                        UserName = (p.User != null ? p.User.UserName : null),
                        Keterangan = p.Keterangan,
                        DetailCount = p.DetailPengiriman.Count()
                    })
                    .ToList();

                _bsPeng.DataSource = data;

                if (dgvPengiriman.Rows.Count > 0)
                {
                    dgvPengiriman.ClearSelection();
                    dgvPengiriman.Rows[0].Selected = true;
                }

                LoadDetailForSelected();
            }
            finally
            {
                _loadingMaster = false;
                Cursor = Cursors.Default;
            }

            DataGridViewHelper.FitOnceThenUnlock(dgvPengiriman);
            DataGridViewHelper.FitOnceThenUnlock(dgvDetailPengiriman);
        }

        private void LoadDetailForSelected()
        {
            if (dgvPengiriman.CurrentRow == null)
            {
                _bsDetail.DataSource = null;
                return;
            }

            object bound = dgvPengiriman.CurrentRow.DataBoundItem;
            PengirimanRow row = bound as PengirimanRow;
            if (row == null || string.IsNullOrEmpty(row.IDPengiriman))
            {
                _bsDetail.DataSource = null;
                return;
            }

            string id = row.IDPengiriman;

            List<DetailPengirimanRow> det = _db.DetailPengirimans
                .AsNoTracking()
                .Where(d => d.IDPengiriman == id)
                .OrderBy(d => d.PartID)
                .Select(d => new DetailPengirimanRow
                {
                    IDPengiriman = d.IDPengiriman,
                    Tgl_Input = d.Tgl_Input,
                    NoPlat = d.NoPlat,
                    PartID = d.PartID,
                    CompartmentID = d.CompartmentID,
                    DataBacaan = d.DataBacaan,
                    DataKalibrasi = d.DataKalibrasi,
                    Satuan = d.Satuan,
                    Keterangan = d.Keterangan
                })
                .ToList();

            _bsDetail.DataSource = det;
        }

        // ----- Event handlers (named) -----
        private void cbxPengSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadPengiriman();
        }

        private void dtpPengFrom_ValueChanged(object sender, EventArgs e)
        {
            ReloadPengiriman();
        }

        private void dtpPengTo_ValueChanged(object sender, EventArgs e)
        {
            ReloadPengiriman();
        }

        private void txtSearchPeng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReloadPengiriman();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dgvPengiriman_SelectionChanged(object sender, EventArgs e)
        {
            if (_loadingMaster) return;
            LoadDetailForSelected();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (_db != null) _db.Dispose();
        }

        private void UpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public sealed class RegionOption
        {
            public int Id { get; set; }       // value (1, 2, 3)
            public string Name { get; set; }  // display ("Wilayah Sumatra", etc.)
                                              // Composite text shown in the ComboBox
            public string Display => $"{Id}. {Name}";
        }

        public sealed class OwnedOption
        {
            public int Id { get; set; }       // value (1, 2, 3)
            public string Name { get; set; }  // display ("Wilayah Sumatra", etc.)
                                              // Composite text shown in the ComboBox
            public string Display => $"{Id}. {Name}";
        }

        private void btnSetTujuan_Click(object sender, EventArgs e)
        {
            int jlhComp = 0;
            int.TryParse(lblJlhCompartment.Text, out jlhComp);
            if (jlhComp <= 0)
            {
                MessageBox.Show("Jumlah compartment tidak valid.", "Tujuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var regions = new List<RegionOption>
            {
                new RegionOption { Id = 1, Name = "Wilayah Sumatra"},
                new RegionOption { Id = 2, Name = "Wilayah Sumatra"},
                new RegionOption { Id = 3, Name = "Wilayah Jakarta / Jawa Barat"},
                new RegionOption { Id = 4, Name = "Wilayah Jawa Tengah / DIY"},
                new RegionOption { Id = 5, Name = "Wilayah Jawa Timur / Bali/ Nusa Tenggara"},
                new RegionOption { Id = 6, Name = "Wilayah Kalimantan"},
                new RegionOption { Id = 7, Name = "Wilayah Sulawesi"},
                new RegionOption { Id = 8, Name = "Wilayah Papua dan Maluku"},
            };

            var owners = new List<OwnedOption>
            {
                new OwnedOption { Id = 1, Name = "COCO (Corporate Owner, Corporate Operate)"},
                new OwnedOption { Id = 3, Name = "CODO (Corporate Owner, Dealer Operate)"},
                new OwnedOption { Id = 4, Name = "DODO (Dealer Owned Dealer Operate)"},
            };

            string[] initial = _compartmentKodeTujuan; // reuse previous picks if any

            using (var dlg = new PilihTujuan(jlhComp, regions, owners, initial))
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _compartmentKodeTujuan = dlg.SelectedKodeTujuan ?? new string[jlhComp];
                    _compartmentNamaTujuan = dlg.SelectedNamaSPBU ?? new string[jlhComp];

                    // Show a compact summary: "C1: 531234 | C2: 531111 | ..."
                    txtTujuan.Text = ComposeTujuanSummaryText(_compartmentKodeTujuan);

                    // Show a compact summary: "C1: 531234 | C2: 531111 | ..."
                    txtTujuan.Text = ComposeTujuanSummaryText(_compartmentKodeTujuan);

                    // NEW: update KodeTujuan in the live grid
                    if (_liveRows != null && _liveRows.Count > 0)
                    {
                        for (int i = 0; i < _liveRows.Count; i++)
                        {
                            if (_compartmentKodeTujuan != null && i < _compartmentKodeTujuan.Length)
                                _liveRows[i].KodeTujuan = _compartmentKodeTujuan[i];
                            else
                                _liveRows[i].KodeTujuan = null;
                        }
                        dgvPengirimanLive.Refresh(); // reflect changes in the UI
                    }
                }
            }
        }

        // Helper to display a friendly summary in txtTujuan
        private static string ComposeTujuanSummaryText(string[] arr)
        {
            if (arr == null || arr.Length == 0) return string.Empty;
            var parts = new List<string>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                var val = string.IsNullOrWhiteSpace(arr[i]) ? "-" : arr[i].Trim();
                parts.Add($"C{i + 1}: {val}");
            }
            return string.Join(" | ", parts);
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //EnsureOpen();

            var sp = (SerialPort)sender;

            try
            {
                while (sp.IsOpen && sp.BytesToRead > 0)
                {
                    string line;
                    try
                    {
                        line = sp.ReadLine(); // NewLine-based read
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

                BeginInvoke(new Action(() => TryReconnectPort()));
            }
            catch (InvalidOperationException)
            {
                // Port closed between reads

                BeginInvoke(new Action(() => TryReconnectPort()));
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    lblPortStatus.Text = "Read error: " + ex.Message;
                    lblPortStatus.ForeColor = Color.DarkOrange;
                }));

                BeginInvoke(new Action(() => TryReconnectPort()));
            }
        }

        private void OnLineReceived(string line)
        {
            txtSerialLog.AppendText(line + Environment.NewLine);

            // ignore data when not listening
            if (!_listening) return;

            // detect [CompartmentID]
            Match m = Regex.Match(line, @"\[(.*?)\]");
            if (m.Success)
            {
                string compId = m.Groups[1].Value.Trim();
                HandleCompartmentMessage(compId);
                return;
            }

            // detect *BACAAN&POSITIVE#
            m = Regex.Match(line, @"\*(\d+)&(\d)#");
            if (m.Success)
            {
                decimal bacaan;
                int positiveFlag;
                if (decimal.TryParse(m.Groups[1].Value, out bacaan) &&
                    int.TryParse(m.Groups[2].Value, out positiveFlag))
                {
                    HandleMeasurementMessage(bacaan, positiveFlag);
                }
            }
        }

        // add a new field
        private string _currentNoPlat;

        // modify HandleCompartmentMessage:
        private void HandleCompartmentMessage(string compId)
        {
            var detail = _db.DetailMTs.AsNoTracking()
                              .FirstOrDefault(d => d.CompartmentID == compId);
            if (detail == null)
            {
                MessageBox.Show("Compartment not found: " + compId);
                return;
            }

            // check if this is a new truck
            if (!string.Equals(_currentNoPlat, detail.NoPlat, StringComparison.Ordinal))
            {
                _currentNoPlat = detail.NoPlat;
                // load the truck and all its compartments
                var truck = _db.MobilTangkis.AsNoTracking()
                                   .FirstOrDefault(t => t.NoPlat == _currentNoPlat);
                if (truck != null)
                {
                    lblNoPlat.Text = truck.NoPlat;
                    lblType.Text = truck.Type ?? "";
                    lblJlhCompartment.Text = truck.JlhCompartment?.ToString();
                    lblJlhCapacity.Text = truck.Capacity?.ToString("N2");
                }
                PopulateLiveGrid(_currentNoPlat);
            }

            // update the current part ID regardless
            _currentPartID = detail.PartID;

            // optional: highlight the row in dgvPengirimanLive for this part
            var index = _liveRows.FindIndex(r => r.PartID == _currentPartID);
            if (index >= 0)
            {
                dgvPengirimanLive.ClearSelection();
                dgvPengirimanLive.Rows[index].Selected = true;
            }
        }


        private void PopulateLiveGrid(string noPlat)
        {
            _liveRows = new List<LiveRow>();

            var details = _db.DetailMTs.AsNoTracking()
                              .Where(d => d.NoPlat == noPlat)
                              .OrderBy(d => d.PartID)
                              .ToList();

            for (int i = 0; i < details.Count; i++)
            {
                var d = details[i];
                var row = new LiveRow();
                row.IDPengiriman = null;
                row.Tgl_Input = null;
                row.NoPlat = d.NoPlat;
                row.PartID = d.PartID;
                row.CompartmentID = d.CompartmentID;
                row.DataBacaan = 0m;
                row.DataKalibrasi = 0m;
                row.Satuan = "LTR";
                row.Keterangan = "INACTIVE";
                if (_compartmentKodeTujuan != null &&
                    i < _compartmentKodeTujuan.Length)
                {
                    row.KodeTujuan = _compartmentKodeTujuan[i];
                }
                row.Kalibrasi = Convert.ToDecimal(d.Kalibrasi);
                row.positive = Convert.ToBoolean(d.Positive);
                _liveRows.Add(row);
            }

            dgvPengirimanLive.AutoGenerateColumns = true;
            dgvPengirimanLive.DataSource = null;
            dgvPengirimanLive.DataSource = _liveRows;

            // Apply dynamic decimal formatting to DataKalibrasi and Kalibrasi columns
            if (dgvPengirimanLive.Columns.Contains("DataKalibrasi"))
                dgvPengirimanLive.Columns["DataKalibrasi"].DefaultCellStyle.Format = "0.##";
            if (dgvPengirimanLive.Columns.Contains("Kalibrasi"))
                dgvPengirimanLive.Columns["Kalibrasi"].DefaultCellStyle.Format = "0.##";
        }

        private void HandleMeasurementMessage(decimal bacaan, int positiveFlag)
        {
            if (_liveRows == null || string.IsNullOrEmpty(_currentPartID))
                return;

            var row = _liveRows.FirstOrDefault(r => r.PartID == _currentPartID);
            if (row == null) return;

            row.DataBacaan = bacaan;

            var detail = _db.DetailMTs.AsNoTracking()
                             .FirstOrDefault(d => d.PartID == _currentPartID);
            decimal kalib = (detail != null && detail.Kalibrasi.HasValue)
                              ? detail.Kalibrasi.Value : 0m;

            // positiveFlag=1 → add; otherwise subtract
            row.DataKalibrasi = positiveFlag == 1
                                   ? bacaan + kalib
                                   : bacaan - kalib;

            row.Keterangan = "ACTIVE";
            dgvPengirimanLive.Refresh();
        }

        private string GenerateNewIDPengiriman()
        {
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);
            string year = now.ToString("yy");
            string month = now.ToString("MM");
            string prefix = "D-" + year + "-" + month + "-";

            var ids = _db.Pengirimans
                         .Where(p => p.IDPengiriman.StartsWith(prefix))
                         .Select(p => p.IDPengiriman)
                         .ToList();

            int maxSeq = 0;
            foreach (var id in ids)
            {
                // expect D-YY-MM-XXXXX
                string[] parts = id.Split('-');
                if (parts.Length == 4)
                {
                    int seq;
                    if (int.TryParse(parts[3], out seq) && seq > maxSeq)
                    {
                        maxSeq = seq;
                    }
                }
            }
            int newSeq = maxSeq + 1;
            return prefix + newSeq.ToString("D5");
        }



        private void TryReconnectPort()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _serialPort.Open();
                UpdateUiForPortState(true);
            }
            catch (Exception ex)
            {
                UpdateUiForPortState(false);
                txtSerialLog.AppendText("Failed to reopen serial port: " + ex.Message);
            }
        }

        private void _serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                lblPortStatus.Text = "Serial error: " + e.EventType;
                lblPortStatus.ForeColor = Color.DarkOrange;
            }));
        }

        private void _serialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                txtSerialLog.AppendText("PinChanged: " + e.EventType + Environment.NewLine);
            }));
        }

        private void UpdateUiForPortState(bool connected)
        {

            lblPortStatus.Text = connected
                ? "Connected: " + _serialPort.PortName + " @ " + _serialPort.BaudRate
                : "Disconnected";
            lblPortStatus.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
        }

        private void btnStartListen_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }
            _listening = true;
            ProListen.Value = 0; // reset the progress bar if you’re using it
            lblPortStatus.Text = "Listening...  Waiting for compartmentID & MeasurementData";
            lblPortStatus.ForeColor = Color.DodgerBlue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_liveRows == null || _liveRows.Count == 0)
            {
                MessageBox.Show("No data to save.", "Save",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check for active rows that are missing a KodeTujuan
            int missingDest = 0;
            foreach (LiveRow row in _liveRows)
            {
                // Compare ignoring case; you can also use row.Keterangan == "ACTIVE" if you prefer
                if (!string.IsNullOrEmpty(row.Keterangan) &&
                    string.Equals(row.Keterangan, "ACTIVE", StringComparison.OrdinalIgnoreCase) &&
                    string.IsNullOrWhiteSpace(row.KodeTujuan))
                {
                    missingDest++;
                }
            }

            if (missingDest > 0)
            {
                MessageBox.Show(
                    "Set KodeTujuan terlebih dahulu, terdapat " + missingDest +
                    " KodeTujuan yang belum di set.",
                    "Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string newId = GenerateNewIDPengiriman();
            lblIDPengiriman.Text = newId;

            // create master record
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);
            TblPengiriman master = new TblPengiriman();
            master.IDPengiriman = newId;
            master.Tgl_Input = now;
            master.NoPlat = lblNoPlat.Text;
            master.Tujuan = txtTujuan.Text;
            master.Status = "DIKIRIM";    // or another status
            master.UserID = null;     // set your current user id
            master.Keterangan = null;

            _db.Pengirimans.Add(master);

            // create detail records
            foreach (LiveRow lr in _liveRows)
            {
                TblDetailPengiriman det = new TblDetailPengiriman();
                det.IDPengiriman = newId;
                det.Tgl_Input = now;
                det.NoPlat = lr.NoPlat;
                det.PartID = lr.PartID;
                det.CompartmentID = lr.CompartmentID;
                det.DataBacaan = lr.DataBacaan;
                det.DataKalibrasi = lr.DataKalibrasi;
                det.Satuan = lr.Satuan;
                det.Keterangan = lr.Keterangan;
                det.KodeTujuan = lr.KodeTujuan;
                _db.DetailPengirimans.Add(det);
            }

            _db.SaveChanges();

            // reset for next entry
            _liveRows.Clear();
            dgvPengirimanLive.DataSource = null;
            txtSerialLog.Clear();
            lblIDPengiriman.Text = "";
            _currentPartID = null;
            _listening = false;

            ReloadPengiriman();
            MessageBox.Show("Pengiriman saved successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtSerialLog.Clear();
        }

    }
}
