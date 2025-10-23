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
using DEPTHCHK.Reports;

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

        private SerialPort _serialPortRfid => Session.GlobalPort;  // port 1
        private SerialPort _serialPortMeas => Session.GlobalPort2;  // port 2

        private SerialDataReceivedEventHandler _rfidReceivedHandler;
        private SerialDataReceivedEventHandler _measReceivedHandler;
        private bool _listening = false;

        private StringBuilder _serialBuffer = new StringBuilder();
        private string _currentPartID;      // PartID of the last selected compartment
        private int _currentPartIndex = 0;       // index into _liveRows for measurement order
        private List<LiveRow> _liveRows;    // holds rows shown in dgvPengirimanLive

        // row shape for dgvPengirimanLive
        private class LiveRow
        {
            public string IDPengiriman { get; set; }
            public DateTime? Tgl_Input { get; set; }
            public string NoPlat { get; set; }
            public string PartID { get; set; }
            public int DataBacaan { get; set; }
            public int DataKalibrasi { get; set; }
            public string Satuan { get; set; }
            public string Keterangan { get; set; }
            public string KodeTujuan { get; set; }
            public int Kalibrasi { get; set; }
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
            // RFID port
            if (_rfidReceivedHandler == null && Session.GlobalPort != null)
            {
                _rfidReceivedHandler = RfidPort_DataReceived;
                _serialPortRfid.DataReceived += _rfidReceivedHandler;
                _serialPortRfid.ErrorReceived += _serialPort_ErrorReceived;
                _serialPortRfid.PinChanged += _serialPort_PinChanged;
            }

            // Measurement port
            if (_measReceivedHandler == null && Session.GlobalPort2 != null)
            {
                _measReceivedHandler = MeasPort_DataReceived;
                _serialPortMeas.DataReceived += _measReceivedHandler;
                _serialPortMeas.ErrorReceived += _serialPort_ErrorReceived;
                _serialPortMeas.PinChanged += _serialPort_PinChanged;
            }

            UpdateUiForPortState(Session.IsPortOpen);
            // Optionally: update a second status label for port2

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

            DataGridViewHelper.ApplyDefaultStyle(dgvPengiriman, false);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailPengiriman);
            DataGridViewHelper.ApplyDefaultStyle(dgvPengirimanLive, false);

            // When initialising the grid (e.g. in Load):
            dgvPengirimanLive.AllowUserToAddRows = false;
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

            // add a checkbox column for selection
            var chkCol = new DataGridViewCheckBoxColumn();
            chkCol.HeaderText = "";
            chkCol.Width = 30;
            chkCol.Name = "Select";
            chkCol.TrueValue = true;
            chkCol.FalseValue = false;
            chkCol.ReadOnly = false;
            dgvPengiriman.Columns.Insert(0, chkCol);
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

            foreach (DataGridViewColumn col in dgvPengiriman.Columns)
            {
                if (col.Name != "Select")
                    col.ReadOnly = true;
            }
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

        private void RfidPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = _serialPortRfid;
            try
            {
                while (sp.IsOpen && sp.BytesToRead >= 8)
                {
                    byte[] frame = new byte[8];
                    int read = sp.Read(frame, 0, 8);
                    if (read == 8)
                    {
                        // Validate header: 07 00 EE 00
                        if (frame[0] == 0x07 && frame[1] == 0x00 &&
                            frame[2] == 0xEE && frame[3] == 0x00)
                        {
                            string rfid = frame[4].ToString("X2") + frame[5].ToString("X2");
                            BeginInvoke(new Action(() => OnRfidReceived(rfid)));
                        }
                        else
                        {
                            // discard the remaining bytes so the next read starts fresh
                            try { sp.DiscardInBuffer(); }
                            catch (Exception ex)
                            {
                                // handle exception if port is closed or in error state
                            }
                        }
                    }
                }
            }
            catch (IOException)
            {
                BeginInvoke(new Action(() =>
                {
                    lblPortStatus.Text = "I/O error (disconnected?)";
                    lblPortStatus.ForeColor = Color.DarkOrange;
                }));

                BeginInvoke(new Action(() => TryReconnectPort(_serialPortRfid, "RFID")));
            }
            catch (InvalidOperationException)
            {
                // Port closed between reads

                BeginInvoke(new Action(() => TryReconnectPort(_serialPortRfid, "RFID")));
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    lblPortStatus.Text = "Read error: " + ex.Message;
                    lblPortStatus.ForeColor = Color.DarkOrange;
                }));

                BeginInvoke(new Action(() => TryReconnectPort(_serialPortRfid, "RFID")));
            }
        }

        // Keep track of the last RFID / NoPlat seen
        private string _lastRfid = null;
        private string _lastNoPlat = null;

        private void OnRfidReceived(string rfid)
        {
            // Look up the truck by RFID
            var mt = _db.MobilTangkis
                        .AsNoTracking()
                        .FirstOrDefault(m => m.RfidData == rfid);

            if (mt == null)
            {
                MessageBox.Show("RFID not recognized.");
                return;
            }

            // Show truck info in your labels
            lblNoPlat.Text = mt.NoPlat;
            lblType.Text = mt.Type ?? "";
            lblJlhCompartment.Text = mt.JlhCompartment?.ToString();
            lblJlhCapacity.Text = mt.Capacity?.ToString("N2");
            lblRFID.Text = mt.RfidData ?? "";

            // If this RFID (or truck) is new, re-populate the grid.
            // Otherwise, keep the current rows/measurements.
            bool isNewTruck = _lastRfid == null ||
                              !_lastRfid.Equals(rfid, StringComparison.OrdinalIgnoreCase);

            if (isNewTruck)
            {
                PopulateLiveGrid(mt.NoPlat);
                _currentPartIndex = 0;      // start measuring from the first compartment
                _lastRfid = rfid;
                _lastNoPlat = mt.NoPlat;
            }

            // If there are rows, set the current PartID based on the current index
            if (_liveRows != null && _currentPartIndex < _liveRows.Count)
                _currentPartID = _liveRows[_currentPartIndex].PartID;
            txtSerialLog.AppendText(rfid + "\n");
        }

        private void MeasPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = _serialPortMeas;
            try
            {
                while (sp.IsOpen)
                {
                    string line;
                    try { line = sp.ReadLine(); }
                    catch (TimeoutException) { break; }

                    // expected format: *45000#
                    Match m = Regex.Match(line, @"\*(\d+(\.\d+)?)#");
                    if (m.Success)
                    {
                        int val;
                        if (int.TryParse(m.Groups[1].Value, out val))
                            BeginInvoke(new Action(() => OnMeasurementReceived(val)));
                    }
                }
            }
            catch { /* handle errors */ }
        }

        private void OnMeasurementReceived(int bacaan)
        {
            // Fill the current row
            if (_liveRows == null || _currentPartIndex < 0 || _currentPartIndex >= _liveRows.Count)
                return;

            _currentPartID = _liveRows[_currentPartIndex].PartID;
            HandleMeasurementMessage(bacaan); // uses _currentPartID and the row’s Kalibrasi/Positive

            // Advance to next part
            _currentPartIndex++;
            if (_currentPartIndex < _liveRows.Count)
            {
                _currentPartID = _liveRows[_currentPartIndex].PartID;
            }
            else
            {
                // All parts measured
                _currentPartID = null;
                _listening = false;
                lblPortStatus.Text = "Measurement complete.";
            }
            txtSerialLog.AppendText(bacaan.ToString() + "\n");
        }

        // add a new field
        private string _currentNoPlat;

        // modify HandleCompartmentMessage:
        private void HandleCompartmentMessage(string compId)
        {
            //var detail = _db.DetailMTs.AsNoTracking()
            //                  .FirstOrDefault(d => d.CompartmentID == compId);
            //if (detail == null)
            //{
            //    MessageBox.Show("Compartment not found: " + compId);
            //    return;
            //}

            //// check if this is a new truck
            //if (!string.Equals(_currentNoPlat, detail.NoPlat, StringComparison.Ordinal))
            //{
            //    _currentNoPlat = detail.NoPlat;
            //    // load the truck and all its compartments
            //    var truck = _db.MobilTangkis.AsNoTracking()
            //                       .FirstOrDefault(t => t.NoPlat == _currentNoPlat);
            //    if (truck != null)
            //    {
            //        lblNoPlat.Text = truck.NoPlat;
            //        lblType.Text = truck.Type ?? "";
            //        lblJlhCompartment.Text = truck.JlhCompartment?.ToString();
            //        lblJlhCapacity.Text = truck.Capacity?.ToString("N2");
            //    }
            //    PopulateLiveGrid(_currentNoPlat);
            //}

            //// update the current part ID regardless
            //_currentPartID = detail.PartID;

            //// optional: highlight the row in dgvPengirimanLive for this part
            //var index = _liveRows.FindIndex(r => r.PartID == _currentPartID);
            //if (index >= 0)
            //{
            //    dgvPengirimanLive.ClearSelection();
            //    dgvPengirimanLive.Rows[index].Selected = true;
            //}
        }


        private void PopulateLiveGrid(string noPlat)
        {
            _liveRows = new List<LiveRow>();

            var details = _db.DetailMTs.AsNoTracking()
                              .Where(d => d.NoPlat == noPlat)
                              .OrderBy(d => d.PartID)
                              .ToList();

            foreach (var d in details)
            {
                var row = new LiveRow
                {
                    IDPengiriman = null,
                    Tgl_Input = null,
                    NoPlat = d.NoPlat,
                    PartID = d.PartID,
                    DataBacaan = 0,
                    DataKalibrasi = 0,
                    Satuan = "MM",
                    Keterangan = "INACTIVE",
                    KodeTujuan = "",            // fill later via btnSetTujuan
                    Kalibrasi = d.Kalibrasi ?? 0,
                    positive = d.Positive ?? false
                };
                _liveRows.Add(row);
            }

            dgvPengirimanLive.DataSource = null;
            dgvPengirimanLive.AutoGenerateColumns = true;
            dgvPengirimanLive.DataSource = _liveRows;
            dgvPengirimanLive.Columns["Kalibrasi"].DefaultCellStyle.Format = "0.##";
            dgvPengirimanLive.Columns["DataKalibrasi"].DefaultCellStyle.Format = "0.##";

            dgvPengirimanLive.AutoGenerateColumns = true;
            dgvPengirimanLive.DataSource = null;
            dgvPengirimanLive.DataSource = _liveRows;

            // Make every column read‑only except KodeTujuan (if you still want to edit that)
            foreach (DataGridViewColumn col in dgvPengirimanLive.Columns)
            {
                // You can set col.Name == "KodeTujuan" to false if you allow editing KodeTujuan
                col.ReadOnly = (col.Name != "Satuan" ? true : false);
            }

            // Optional: turn off row additions/deletions and set EditMode to programmatic
            dgvPengirimanLive.AllowUserToAddRows = false;
            dgvPengirimanLive.AllowUserToDeleteRows = false;
            dgvPengirimanLive.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        // Change the signature and body of HandleMeasurementMessage
        private void HandleMeasurementMessage(int bacaan)
        {
            // Find the row matching the current PartID
            if (_liveRows == null || string.IsNullOrEmpty(_currentPartID))
                return;

            LiveRow row = _liveRows.FirstOrDefault(r => r.PartID == _currentPartID);
            if (row == null) return;

            // Update the raw reading
            row.DataBacaan = bacaan;

            // Use the calibration and sign stored in the row instead of any flag from the input
            int kalib = row.Kalibrasi;
            bool positiveFlag = row.positive;

            // Add or subtract calibration based on the 'positive' column
            row.DataKalibrasi = positiveFlag ? bacaan + kalib : bacaan - kalib;

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



        private void TryReconnectPort(SerialPort port, string tag)
        {
            try
            {
                if (port == null)
                    throw new InvalidOperationException($"{tag} port is null.");

                if (port.IsOpen)
                    port.Close();

                port.Open();
                UpdateUiForPortState(true);
            }
            catch (Exception ex)
            {
                UpdateUiForPortState(false);
                txtSerialLog.AppendText($"Failed to reopen {tag} port: {ex.Message}{Environment.NewLine}");
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
            string rfid = _serialPortRfid?.IsOpen == true
                        ? $"RFID: {_serialPortRfid.PortName} @ {_serialPortRfid.BaudRate}"
                        : "RFID: Disconnected";

            string meas = _serialPortMeas?.IsOpen == true
                        ? $"MEAS: {_serialPortMeas.PortName} @ {_serialPortMeas.BaudRate}"
                        : "MEAS: Disconnected";

            lblPortStatus.Text = $"{rfid}   |   {meas}";
            lblPortStatus.ForeColor =
                (_serialPortRfid?.IsOpen == true || _serialPortMeas?.IsOpen == true)
                ? Color.ForestGreen
                : Color.Firebrick;
        }

        private void btnStartListen_Click(object sender, EventArgs e)
        {
            if (!_serialPortRfid.IsOpen)
            {
                _serialPortRfid.Open();
            }

            if(!_serialPortMeas.IsOpen)
            {
                _serialPortMeas.Open();
            }
            _listening = true;
            
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
            master.RfidData = lblRFID.Text.Trim().PadRight(4).Substring(0, 4); // or use a field storing the scanned RFID
            master.Status = "DIKIRIM";    // or another status
            master.UserID = Session.CurrentUser.UserID;     // set your current user id
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
                det.DataBacaan = lr.DataBacaan;
                det.DataKalibrasi = lr.DataKalibrasi;
                det.Satuan = lr.Satuan;
                det.Keterangan = lr.Keterangan;
                _db.DetailPengirimans.Add(det);
            }

            _db.SaveChanges();

            // After saving and clearing the live rows:
            _liveRows.Clear();
            dgvPengirimanLive.DataSource = new List<LiveRow>();
            _currentPartID = null;
            _currentNoPlat = null;
            _lastRfid = null;          // or _lastNoPlat, depending on your implementation
            _currentPartIndex = 0;
            _listening = false;        // optional: stop listening until the user restarts


            ReloadPengiriman();
            MessageBox.Show("Pengiriman saved successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtSerialLog.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TCPengiriman.SelectedTab = TPAddPengiriman;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var selectedIds = new List<string>();
            foreach (DataGridViewRow row in dgvPengiriman.Rows)
            {
                bool isChecked = false;
                if (row.Cells["Select"].Value != null)
                    bool.TryParse(row.Cells["Select"].Value.ToString(), out isChecked);
                if (isChecked)
                {
                    var bound = row.DataBoundItem as PengirimanRow;
                    if (bound != null) selectedIds.Add(bound.IDPengiriman);
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Tidak ada pengiriman yang dipilih untuk dicetak.");
                return;
            }

            // Build ONE DataSet for all selected IDs
            DataSet ds = new DataSet();

            // Header table
            DataTable dtHeader = new DataTable("Header");
            dtHeader.Columns.Add("IDPengiriman");
            dtHeader.Columns.Add("Tgl_Input", typeof(DateTime));
            dtHeader.Columns.Add("NoPlat");
            dtHeader.Columns.Add("Type");
            dtHeader.Columns.Add("JlhCompartment");
            dtHeader.Columns.Add("Capacity");
            dtHeader.Columns.Add("Tujuan");

            // Detail table (without CompartmentID)
            DataTable dtDetail = new DataTable("Detail");
            dtDetail.Columns.Add("IDPengiriman");         // link back to header
            dtDetail.Columns.Add("PartID");
            dtDetail.Columns.Add("DataBacaan", typeof(decimal));
            dtDetail.Columns.Add("Kalibrasi", typeof(decimal));  // or typeof(int) if you prefer
            dtDetail.Columns.Add("DataKalibrasi", typeof(decimal));
            dtDetail.Columns.Add("Satuan");
            dtDetail.Columns.Add("Keterangan");
            dtDetail.Columns.Add("KodeTujuan");

            ds.Tables.Add(dtHeader);
            ds.Tables.Add(dtDetail);

            foreach (string id in selectedIds)
            {
                var header = _db.Pengirimans
                                .FirstOrDefault(p => p.IDPengiriman == id);

                if (header != null)
                {
                    // Look up the truck by NoPlat
                    var mobil = _db.MobilTangkis
                                   .AsNoTracking()
                                   .FirstOrDefault(mt => mt.NoPlat == header.NoPlat);

                    dtHeader.Rows.Add(
                        header.IDPengiriman,
                        header.Tgl_Input,
                        header.NoPlat,
                        mobil?.Type,
                        mobil?.JlhCompartment ?? (object)DBNull.Value,
                        mobil?.Capacity ?? (object)DBNull.Value
                    );
                }

                var details = _db.DetailPengirimans
                                 .Include(d => d.DetailMT)
                                 .AsNoTracking()
                                 .Where(d => d.IDPengiriman == id)
                                 .OrderBy(d => d.PartID)
                                 .ToList();

                foreach (var d in details)
                {
                    dtDetail.Rows.Add(
                        id,
                        d.PartID,
                        d.DataBacaan ?? 0m,
                        // if your model defines Kalibrasi as int? then cast:
                        d.DetailMT != null ? (decimal?)d.DetailMT.Kalibrasi ?? 0 : 0m,
                        d.DataKalibrasi ?? 0m,
                        d.Satuan,
                        d.Keterangan
                    );
                }
            }

            // Add the relation so Crystal can see the master-detail link
            if (ds.Relations["Header_Detail"] == null)
            {
                ds.Relations.Add(
                    "Header_Detail",
                    ds.Tables["Header"].Columns["IDPengiriman"],
                    ds.Tables["Detail"].Columns["IDPengiriman"]
                );
            }

            // Load the report once with the whole dataset
            var report = new TicketReport();
            report.SetDataSource(ds);

            // Show in your viewer form (preview first)
            var viewer = new ReportViewer();
            viewer.LoadReport(report);
            viewer.ShowDialog();
        }


        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            SetAllChecks(dgvPengiriman, chkAll.Checked);
        }

        private void SetAllChecks(DataGridView dgv, bool isChecked)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            var chkCol = dgv.Columns[0] as DataGridViewCheckBoxColumn;
            if (chkCol == null) throw new InvalidOperationException("First column is not a CheckBox column.");

            dgv.EndEdit();
            dgv.SuspendLayout();
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    var cell = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (cell != null) cell.Value = isChecked;
                }
                dgv.EndEdit();
            }
            finally { dgv.ResumeLayout(); }
        }

        public void PrepareToClose()
        {
            try
            {
                // Port 1 (RFID)
                if (_rfidReceivedHandler != null && _serialPortRfid != null)
                {
                    try
                    {
                        _serialPortRfid.DataReceived -= _rfidReceivedHandler;
                        _serialPortRfid.ErrorReceived -= _serialPort_ErrorReceived;
                        _serialPortRfid.PinChanged -= _serialPort_PinChanged;
                    }
                    catch { /* ignore */ }
                    _rfidReceivedHandler = null;
                }

                // Port 2 (Measurement)
                if (_measReceivedHandler != null && _serialPortMeas != null)
                {
                    try
                    {
                        _serialPortMeas.DataReceived -= _measReceivedHandler;
                        _serialPortMeas.ErrorReceived -= _serialPort_ErrorReceived;
                        _serialPortMeas.PinChanged -= _serialPort_PinChanged;
                    }
                    catch { /* ignore */ }
                    _measReceivedHandler = null;
                }
            }
            catch
            {
                // swallow top-level exceptions to avoid crash during form close
            }
        }

        private void btnRelistenAll_Click(object sender, EventArgs e)
        {
            if (_liveRows == null || _liveRows.Count == 0) return;

            foreach (var row in _liveRows)
            {
                row.DataBacaan = 0;
                row.DataKalibrasi = 0;
                row.Keterangan = "INACTIVE";
            }
            _currentPartIndex = 0;
            _listening = true;
            dgvPengirimanLive.Refresh();
        }

        private void btnReListen_Click(object sender, EventArgs e)
        {
            // Get the selected row in the live grid
            DataGridViewRow cur = dgvPengirimanLive.CurrentRow;
            if (cur == null) return;                 // nothing selected

            int rowIndex = cur.Index;
            if (rowIndex < 0 || rowIndex >= _liveRows.Count) return;

            // Reset the measurement data
            var row = _liveRows[rowIndex];
            row.DataBacaan = 0;
            row.DataKalibrasi = 0;
            row.Keterangan = "INACTIVE";

            // Restart measurement from this part
            _currentPartIndex = rowIndex;
            _listening = true;

            // Refresh the grid to show the changes
            dgvPengirimanLive.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TCPengiriman.SelectedTab = TPPengiriman;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser.TipeUser != "SUPERADMIN")
            {
                MessageBox.Show("Anda Tidak Memiliki Hak Akses Untuk Tombol ini , Hubungi SUPERADMIN. Delete hanya bisa digunakan oleh SUPERADMIN & kurang dari 24 jam");
                return;
            }

            // Gather all selected IDs from the first (checkbox) column
            var selectedIds = new List<string>();
            foreach (DataGridViewRow row in dgvPengiriman.Rows)
            {
                bool isChecked = false;
                if (row.Cells["Select"].Value != null)
                    bool.TryParse(row.Cells["Select"].Value.ToString(), out isChecked);

                if (isChecked)
                {
                    var bound = row.DataBoundItem as PengirimanRow;
                    if (bound != null && !string.IsNullOrWhiteSpace(bound.IDPengiriman))
                        selectedIds.Add(bound.IDPengiriman);
                }
            }

            // No rows checked? Warn and exit
            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Pilih data pengiriman terlebih dahulu.");
                return;
            }

            // Confirm deletion
            string msg = (selectedIds.Count == 1)
                ? "Hapus pengiriman ID: " + selectedIds[0] + " ?"
                : "Hapus " + selectedIds.Count + " data pengiriman?";
            DialogResult confirm = MessageBox.Show(msg,
                                                   "Konfirmasi Hapus",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var tx = _db.Database.BeginTransaction())
                {
                    foreach (var id in selectedIds)
                    {
                        // Load master and its details
                        var pengiriman = _db.Pengirimans
                                            .Include(p => p.DetailPengiriman)
                                            .SingleOrDefault(p => p.IDPengiriman == id);
                        if (pengiriman == null)
                            continue;

                        // Delete detail records first (no cascade assumed)
                        foreach (var det in pengiriman.DetailPengiriman.ToList())
                        {
                            _db.DetailPengirimans.Remove(det);
                        }

                        // Delete master
                        _db.Pengirimans.Remove(pengiriman);
                    }

                    _db.SaveChanges();
                    tx.Commit();
                }

                // Refresh UI: reload list and clear detail grid
                ReloadPengiriman();
                _bsDetail.DataSource = null;

                MessageBox.Show("Data pengiriman berhasil dihapus.",
                                "Hapus",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message,
                                "Hapus",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        // This assumes the measurement port is Session.GlobalPort2.
        private void btnSendACK_Click(object sender, EventArgs e)
        {
            var measPort = Session.GlobalPort2;  // your measurement port
            if (measPort == null || !measPort.IsOpen)
            {
                MessageBox.Show(
                    "Measurement port is not open. Please connect the measurement port first.",
                    "Port Not Connected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Send the ASCII question mark without newline
                measPort.Write("?");

                // Optionally log what you sent
                txtSerialLog.AppendText("Sent: ?\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to send ACK: " + ex.Message,
                    "Serial Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
