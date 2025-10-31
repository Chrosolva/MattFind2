using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DEPTHCHK.Data;
using DEPTHCHK.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace DEPTHCHK.Views
{
    /// <summary>
    /// A brand new shipment form that merges the listing/search UI and the data entry UI
    /// into a single screen.  This form listens on two serial ports: one for RFID tags
    /// identifying a tank truck and a second port for depth measurements.  When an
    /// RFID tag is scanned the current truck info and its detail compartments are
    /// loaded into a live grid.  The operator can then click Get Data to begin
    /// acquiring measurement values for each compartment.  Once all compartments
    /// are measured the operator can Save and Print to persist the shipment and
    /// produce a ticket.
    /// </summary>
    public partial class PengirimanFormNew : MaterialForm
    {
        private readonly depthchkDBContext _db;

        // binding for shipment list
        private readonly BindingSource _bsPeng = new BindingSource();

        // live measurement rows
        private List<LiveRow> _liveRows;

        // index of the compartment being measured
        private int _currentPartIndex;

        // state
        private string _lastRfid;
        private string _lastNoPlat;
        private bool _listening;

        // references to the global serial ports defined in Session
        private SerialPort _rfidPort { get { return Session.GlobalPort; } }
        private SerialPort _measPort { get { return Session.GlobalPort2; } }

        // event handlers to remove on close
        private SerialDataReceivedEventHandler _rfidHandler;
        private SerialDataReceivedEventHandler _measHandler;

        /// <summary>
        /// row shape for the live measurement grid
        /// </summary>
        private class LiveRow
        {
            public string PartID { get; set; }
            public string NoPlat { get; set; }
            public int DataBacaan { get; set; }
            public int DataKalibrasi { get; set; }
            public string Satuan { get; set; }
            public string Keterangan { get; set; }
            public int Kalibrasi { get; set; }
            public bool Positive { get; set; }
            public decimal Suhu { get; set; }
        }

        /// <summary>
        /// combo item class for search combo
        /// </summary>
        private class ComboItem
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public PengirimanFormNew()
        {
            InitializeComponent();
            _db = new depthchkDBContext();

            SetupSearchCombo();
            SetupGrids();
            InitSerial();

            // default dates
            dtpPengFrom.Value = DateTime.Today.AddDays(-14);
            dtpPengTo.Value = DateTime.Today;

            // hook up events using named handlers to be compatible with older C#
            dtpPengFrom.ValueChanged += DateRangeChanged;
            dtpPengTo.ValueChanged += DateRangeChanged;
            cbxPengSearchBy.SelectedIndexChanged += SearchChanged;
            txtSearchPeng.KeyDown += TxtSearchPeng_KeyDown;
            dgvPengiriman.SelectionChanged += DgvPengiriman_SelectionChanged;
            chkAll.CheckedChanged += ChkAll_CheckedChanged;
            btnFilter.Click += BtnFilter_Click;
            btnGetData.Click += BtnGetData_Click;
            btnSavePrint.Click += BtnSavePrint_Click;
            btnPrint.Click += BtnPrint_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        #region Setup

        private void SetupSearchCombo()
        {
            var items = new List<ComboItem>();
            items.Add(new ComboItem { Key = "ID Pengiriman", Value = "IDPengiriman" });
            items.Add(new ComboItem { Key = "No Plat", Value = "NoPlat" });
            items.Add(new ComboItem { Key = "Tujuan", Value = "Tujuan" });
            items.Add(new ComboItem { Key = "Status", Value = "Status" });
            items.Add(new ComboItem { Key = "User ID", Value = "UserID" });

            cbxPengSearchBy.DisplayMember = "Key";
            cbxPengSearchBy.ValueMember = "Value";
            cbxPengSearchBy.DataSource = items;
            cbxPengSearchBy.SelectedValue = "IDPengiriman";
        }

        private void SetupGrids()
        {
            dgvPengiriman.AutoGenerateColumns = false;
            dgvPengiriman.Columns.Clear();
            // Checkbox column
            var chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Select";
            chk.Width = 30;
            dgvPengiriman.Columns.Add(chk);
            dgvPengiriman.Columns.Add(new DataGridViewTextBoxColumn { Name = "IDPengiriman", DataPropertyName = "IDPengiriman", HeaderText = "ID", ReadOnly = true });
            dgvPengiriman.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tgl_Input", DataPropertyName = "Tgl_Input", HeaderText = "Tanggal", ReadOnly = true, DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm:ss.fff" } });
            dgvPengiriman.Columns.Add(new DataGridViewTextBoxColumn { Name = "NoPlat", DataPropertyName = "NoPlat", HeaderText = "NoPlat", ReadOnly = true });
            dgvPengiriman.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Status", ReadOnly = true });
            dgvPengiriman.DataSource = _bsPeng;

            // Live grid for measurements
            dgvPengirimanLive.AutoGenerateColumns = false;
            dgvPengirimanLive.Columns.Clear();
            dgvPengirimanLive.Columns.Add(new DataGridViewTextBoxColumn { Name = "PartID", DataPropertyName = "PartID", HeaderText = "PartID", ReadOnly = true });
            dgvPengirimanLive.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataBacaan", DataPropertyName = "DataBacaan", HeaderText = "Bacaan", ReadOnly = true });
            dgvPengirimanLive.Columns.Add(new DataGridViewTextBoxColumn { Name = "Kalibrasi", DataPropertyName = "Kalibrasi", HeaderText = "Kalib", ReadOnly = true, Visible = false });
            dgvPengirimanLive.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataKalibrasi", DataPropertyName = "DataKalibrasi", HeaderText = "Hasil", ReadOnly = true });
            // ✅ ComboBox for Keterangan
            var comboCol = new DataGridViewComboBoxColumn
            {
                Name = "Keterangan",
                DataPropertyName = "Keterangan",
                HeaderText = "Density",
                ReadOnly = false,
                FlatStyle = FlatStyle.Popup
            };
            comboCol.Items.AddRange("Pertamax", "Pertamax Turbo", "Pertalite", "Dex", "Dexlite", "Solar");
            dgvPengirimanLive.Columns.Add(comboCol);
            dgvPengirimanLive.Columns.Add(new DataGridViewTextBoxColumn { Name = "Satuan", DataPropertyName = "Satuan", HeaderText = "Unit", ReadOnly = true, Visible = false });
            dgvPengirimanLive.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Positive", DataPropertyName = "Positive", HeaderText = "Pos", ReadOnly = false, Visible = false });
            dgvPengirimanLive.Columns.Add(new DataGridViewTextBoxColumn { Name = "Suhu", DataPropertyName = "Suhu", HeaderText = "Suhu", ReadOnly = false, Visible = true });
        }

        private void InitSerial()
        {
            // attach handlers once
            if (_rfidPort != null && _rfidHandler == null)
            {
                _rfidHandler = new SerialDataReceivedEventHandler(RfidPort_DataReceived);
                _rfidPort.DataReceived += _rfidHandler;
            }
            if (_measPort != null && _measHandler == null)
            {
                _measHandler = new SerialDataReceivedEventHandler(MeasPort_DataReceived);
                _measPort.DataReceived += _measHandler;
            }

            UpdatePortStatus();
        }

        #endregion

        #region RFID and measurement processing

        private void RfidPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = _rfidPort;
            try
            {
                while (sp.IsOpen && sp.BytesToRead >= 8)
                {
                    byte[] frame = new byte[8];
                    int read = sp.Read(frame, 0, 8);
                    if (read == 8)
                    {
                        // header 07 00 EE 00
                        string fullframe = "";
                        foreach(byte x in frame)
                        {
                            fullframe += x.ToString("X2") + " ";
                        }

                        if (frame[0] == 0x07 && frame[1] == 0x00 && frame[2] == 0xEE && frame[3] == 0x00)
                        {
                            string tag = frame[4].ToString("X2") + frame[5].ToString("X2");
                            BeginInvoke(new MethodInvoker(delegate { OnRfidReceived(tag, fullframe); }));
                        }
                        else
                        {
                            sp.DiscardInBuffer();
                        }
                    }
                }
            }
            catch
            {
                // ignore or log errors
            }
        }

        private void OnRfidReceived(string rfid, string fullrfid)
        {
            // log
            txtSerialLog.AppendText("RECEIVED: "+ fullrfid + ", RFID: " + rfid + Environment.NewLine);
            txtSerialLog.AppendText("Start Listening Compartment 1" + Environment.NewLine);
            // find MobilTangki by RFID
            TblMobilTangki mt = null;
            // use AsNoTracking to avoid unnecessary tracking
            foreach (var item in _db.MobilTangkis.AsNoTracking().Where(m => m.RfidData == rfid))
            {
                mt = item;
                break;
            }
            if (mt == null)
            {
                MessageBox.Show("RFID not recognized.");
                return;
            }
            // update labels
            lblCurrentNoPlat.Text = mt.NoPlat;
            lblCurrentType.Text = mt.Type;
            lblCurrentJlhCompartment.Text = mt.JlhCompartment != null ? mt.JlhCompartment.Value.ToString() : "";
            lblCurrentCapacity.Text = mt.Capacity != null ? mt.Capacity.Value.ToString() : "";
            // if new truck, populate live grid
            bool isNew = (_lastRfid == null) || (!_lastRfid.Equals(rfid, StringComparison.OrdinalIgnoreCase));
            if (isNew)
            {
                PopulateLiveGrid(mt.NoPlat);
                _currentPartIndex = 0;
                _lastRfid = rfid;
                _lastNoPlat = mt.NoPlat;
            }
        }

        private void MeasPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // measurement lines like *45000#
            var sp = _measPort;
            try
            {
                while (sp.IsOpen)
                {
                    string line = sp.ReadLine().Trim(); // trim to avoid \r\n issues

                    // Check if measurement
                    Match m = Regex.Match(line, @"\*(\d+)#");
                    if (m.Success)
                    {
                        int val;
                        if (int.TryParse(m.Groups[1].Value, out val))
                        {
                            BeginInvoke(new MethodInvoker(delegate { OnMeasurementReceived(val); }));
                        }
                        continue;
                    }

                    // ✅ Check if it's the save command signal
                    if (line == "[1]")
                    {
                        BeginInvoke(new MethodInvoker(delegate
                        {
                            txtSerialLog.AppendText("Received Order to Save and Print" + Environment.NewLine);
                            SaveAndPrint();
                        }));
                        continue;
                    }
                }
            }
            catch
            {
                // ignore timeouts or errors
            }
        }

        private void OnMeasurementReceived(int value)
        {
            if (_liveRows == null || _currentPartIndex < 0 || _currentPartIndex >= _liveRows.Count)
                return;
            var row = _liveRows[_currentPartIndex];
            row.DataBacaan = value;
            // compute calibrated
            if (row.Positive)
                row.DataKalibrasi = value + row.Kalibrasi;
            else
                row.DataKalibrasi = value - row.Kalibrasi;
            row.Keterangan = "";
            dgvPengirimanLive.Refresh();
            _currentPartIndex++;
            if (_currentPartIndex >= _liveRows.Count)
            {
                _listening = false;
            }
            txtSerialLog.AppendText("Measurement complete. VALUE = " + value.ToString("N0") + "NEXT COMP " + Environment.NewLine);
        }

        private void PopulateLiveGrid(string noPlat)
        {
            _liveRows = new List<LiveRow>();
            var details = _db.DetailMTs.AsNoTracking().Where(d => d.NoPlat == noPlat).OrderBy(d => d.PartID).ToList();
            foreach (var d in details)
            {
                LiveRow row = new LiveRow();
                row.PartID = d.PartID;
                row.NoPlat = d.NoPlat;
                row.DataBacaan = 0;
                row.DataKalibrasi = 0;
                row.Satuan = "mm";
                row.Keterangan = ""; // ✅ default value
                row.Kalibrasi = d.Kalibrasi.HasValue ? d.Kalibrasi.Value : 0;
                row.Positive = d.Positive.HasValue ? d.Positive.Value : false;
                row.Suhu = 0;
                _liveRows.Add(row);
            }
            dgvPengirimanLive.DataSource = null;
            dgvPengirimanLive.DataSource = _liveRows;
            dgvPengirimanLive.Columns["PartID"].Width = 145;
            dgvPengirimanLive.Columns["DataBacaan"].Width = 45;
            dgvPengirimanLive.Columns["DataKalibrasi"].Width = 45;
            dgvPengirimanLive.Columns["Keterangan"].Width = 110;
            dgvPengirimanLive.Columns["Suhu"].Width = 52;
        }

        private void UpdatePortStatus()
        {
            List<string> parts = new List<string>();
            if (_rfidPort != null)
            {
                if (_rfidPort.IsOpen)
                {
                    parts.Add("RFID " + _rfidPort.PortName);
                }
                else
                {
                    parts.Add("RFID closed");
                }
            }
            if (_measPort != null)
            {
                if (_measPort.IsOpen)
                {
                    parts.Add("MEAS " + _measPort.PortName);
                }
                else
                {
                    parts.Add("MEAS closed");
                }
            }
            lblPortStatus.Text = string.Join(" | ", parts.ToArray());
        }

        #endregion

        #region Database queries

        private void ReloadPengiriman()
        {
            DateTime from = dtpPengFrom.Value.Date;
            DateTime to = dtpPengTo.Value.Date.AddDays(1);
            string term = (txtSearchPeng.Text != null) ? txtSearchPeng.Text.Trim() : "";
            object selValue = cbxPengSearchBy.SelectedValue;
            string field = (selValue != null) ? selValue.ToString() : "";
            var q = _db.Pengirimans.AsNoTracking().Where(p => p.Tgl_Input >= from && p.Tgl_Input < to);
            if (!string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(field))
            {
                if (field == "IDPengiriman") q = q.Where(p => p.IDPengiriman.Contains(term));
                else if (field == "NoPlat") q = q.Where(p => p.NoPlat.Contains(term));
                else if (field == "Status") q = q.Where(p => p.Status.Contains(term));
                else if (field == "UserID") q = q.Where(p => p.UserID.Contains(term));
            }
            var data = q.OrderByDescending(p => p.Tgl_Input).Select(p => new
            {
                p.IDPengiriman,
                p.Tgl_Input,
                p.NoPlat,
                p.Status
            }).ToList();
            _bsPeng.DataSource = data;
            LoadDetailForSelected();
            dgvPengiriman.Columns[0].Width = 30;
            dgvPengiriman.Columns["Tgl_Input"].Width = 200;
        }

        private void LoadDetailForSelected()
        {
            if (dgvPengiriman.CurrentRow == null)
            {
                FLDetailPengiriman.Controls.Clear();
                return;
            }

            object cellVal = dgvPengiriman.CurrentRow.Cells["IDPengiriman"].Value;
            if (cellVal == null) return;
            string id = cellVal.ToString();

            var details = _db.DetailPengirimans.AsNoTracking().Where(d => d.IDPengiriman == id).OrderBy(d => d.PartID).ToList();
            FLDetailPengiriman.Controls.Clear();
            foreach (var det in details)
            {
                var uc = new DEPTHCHK.UserControls.UCDetailPengiriman();
                Label lblPart = uc.Controls["lblPartID"] as Label;
                Label lblPlat = uc.Controls["lblNoPlat"] as Label;
                Label lblBacaan = uc.Controls["lblDataBacaan"] as Label;
                Label lblKalib = uc.Controls["lblDataKalibrasi"] as Label;
                Label lblKet = uc.Controls["lblKeterangan"] as Label;
                Label lblSuhu = uc.Controls["lblSuhu"] as Label;
                if (lblPart != null) lblPart.Text = det.PartID;
                if (lblPlat != null) lblPlat.Text = det.NoPlat;
                if (lblKet != null) lblKet.Text = det.Keterangan;
                if (lblBacaan != null) lblBacaan.Text = det.DataBacaan.HasValue ? det.DataBacaan.Value.ToString() : "-";
                if (lblKalib != null) lblKalib.Text = det.DataKalibrasi.HasValue ? det.DataKalibrasi.Value.ToString() : "-";
                if (lblSuhu != null) lblSuhu.Text = det.Suhu.HasValue ? det.Suhu.Value.ToString("#,0.##") : "-";
                FLDetailPengiriman.Controls.Add(uc);
            }
        }

        #endregion

        #region Actions

        private void ToggleSelectAll(bool isChecked)
        {
            foreach (DataGridViewRow row in dgvPengiriman.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = isChecked;
                }
            }
        }

        private void SendAckGet()
        {
            // send "?" to measurement port and start listening
            if (_measPort == null || !_measPort.IsOpen)
            {
                MessageBox.Show("Measurement port not open.");
                return;
            }
            try
            {
                _measPort.Write("?" + Environment.NewLine);
                _listening = true;
                txtSerialLog.AppendText("GET DATA." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send ACK: " + ex.Message);
            }
        }

        private void SaveAndPrint()
        {
            // stop measurement by sending [2]
            if (_measPort != null && _measPort.IsOpen)
            {
                try
                {
                    //_measPort.Write("SAVE DATA AND PRINT");
                    //txtSerialLog.AppendText("SAVE DATA AND PRINT." + Environment.NewLine);
                }
                catch
                {
                    // ignore errors
                }
            }
            // ensure there is data
            if (_liveRows == null || _liveRows.Count == 0)
            {
                MessageBox.Show("No measurement data.");
                return;
            }
            // generate id
            string newId = GenerateNewId();
            DateTime now = DateTime.Now;
            TblPengiriman master = new TblPengiriman();
            master.IDPengiriman = newId;
            master.Tgl_Input = now;
            master.NoPlat = lblCurrentNoPlat.Text;
            master.RfidData = _lastRfid;
            master.Status = "DIKIRIM";
            master.UserID = (Session.CurrentUser != null) ? Session.CurrentUser.UserID : null;
            master.Keterangan = null;
            _db.Pengirimans.Add(master);
            foreach (var row in _liveRows)
            {
                TblDetailPengiriman detail = new TblDetailPengiriman();
                detail.IDPengiriman = newId;
                detail.Tgl_Input = now;
                detail.NoPlat = row.NoPlat;
                detail.PartID = row.PartID;
                detail.DataBacaan = row.DataBacaan;
                detail.DataKalibrasi = row.DataKalibrasi;
                detail.Satuan = row.Satuan;
                detail.Keterangan = row.Keterangan;
                detail.Suhu = row.Suhu;
                _db.DetailPengirimans.Add(detail);
            }
            _db.SaveChanges();

            // print only the new record
            List<string> selectedIds = new List<string>();
            selectedIds.Add(newId);
            PrintIds(selectedIds);

            // reset
            if (_liveRows != null)
            {
                _liveRows.Clear();
            }
            dgvPengirimanLive.DataSource = null;
            _lastRfid = null;
            _lastNoPlat = null;
            lblCurrentNoPlat.Text = "";
            lblCurrentType.Text = "";
            lblCurrentJlhCompartment.Text = "";
            lblCurrentCapacity.Text = "";
            txtSerialLog.AppendText("Saved and printed." + Environment.NewLine);
            ReloadPengiriman();
        }

        private void PrintSelected()
        {
            List<string> ids = new List<string>();
            foreach (DataGridViewRow row in dgvPengiriman.Rows)
            {
                bool check = false;
                object cellVal = row.Cells["Select"].Value;
                if (cellVal != null)
                {
                    bool.TryParse(cellVal.ToString(), out check);
                }
                if (check)
                {
                    ids.Add(row.Cells["IDPengiriman"].Value.ToString());
                }
            }
            if (ids.Count == 0)
            {
                MessageBox.Show("No shipments selected.");
                return;
            }
            PrintIds(ids);
        }

        private void PrintIds(List<string> ids)
        {
            // Build dataset and open report viewer
            DataSet ds = new DataSet();
            DataTable dtHeader = new DataTable("Header");
            dtHeader.Columns.Add("IDPengiriman");
            dtHeader.Columns.Add("Tgl_Input", typeof(DateTime));
            dtHeader.Columns.Add("NoPlat");
            dtHeader.Columns.Add("Type");
            dtHeader.Columns.Add("JlhCompartment", typeof(int));
            dtHeader.Columns.Add("Capacity", typeof(int));
            dtHeader.Columns.Add("Tujuan");
            DataTable dtDetail = new DataTable("Detail");
            dtDetail.Columns.Add("IDPengiriman");
            dtDetail.Columns.Add("PartID");
            dtDetail.Columns.Add("DataBacaan", typeof(int));
            dtDetail.Columns.Add("Kalibrasi", typeof(int));
            dtDetail.Columns.Add("DataKalibrasi", typeof(int));
            dtDetail.Columns.Add("Satuan");
            dtDetail.Columns.Add("Keterangan");
            dtDetail.Columns.Add("Suhu", typeof(decimal));
            ds.Tables.Add(dtHeader);
            ds.Tables.Add(dtDetail);

            foreach (string id in ids)
            {
                TblPengiriman header = null;
                foreach (var p in _db.Pengirimans.Where(p => p.IDPengiriman == id))
                {
                    header = p;
                    break;
                }
                if (header != null)
                {
                    TblMobilTangki mt = null;
                    foreach (var mt1 in _db.MobilTangkis.AsNoTracking().Where(m => m.NoPlat == header.NoPlat))
                    {
                        mt = mt1;
                        break;
                    }
                    dtHeader.Rows.Add(header.IDPengiriman,
                                      header.Tgl_Input,
                                      header.NoPlat,
                                      (mt != null ? mt.Type : null),
                                      (mt != null ? (object)mt.JlhCompartment ?? 0 : 0),
                                      (mt != null ? (object)mt.Capacity ?? 0 : 0));
                }

                var details = _db.DetailPengirimans.Include("DetailMT").AsNoTracking().Where(d => d.IDPengiriman == id).OrderBy(d => d.PartID).ToList();
                foreach (var d in details)
                {
                    int kalib = 0;
                    if (d.DetailMT != null && d.DetailMT.Kalibrasi.HasValue)
                        kalib = d.DetailMT.Kalibrasi.Value;
                    int dataBacaan = d.DataBacaan.HasValue ? d.DataBacaan.Value : 0;
                    int dataKalibrasi = d.DataKalibrasi.HasValue ? d.DataKalibrasi.Value : 0;
                    decimal suhu = d.Suhu.HasValue ? d.Suhu.Value : 0m;

                    dtDetail.Rows.Add(id,
                                      d.PartID,
                                      dataBacaan,
                                      kalib,
                                      dataKalibrasi,
                                      d.Satuan,
                                      d.Keterangan,
                                      suhu);
                }
            }
            if (ds.Relations["Header_Detail"] == null)
            {
                ds.Relations.Add("Header_Detail", dtHeader.Columns["IDPengiriman"], dtDetail.Columns["IDPengiriman"]);
            }
            // Use existing report classes if available.  This form references TicketReport and ReportViewer from the legacy form.
            var report = new DEPTHCHK.Reports.TicketReport();
            report.SetDataSource(ds);


            if(chkPrintPreview.Checked)
            {
                var viewer = new DEPTHCHK.Views.ReportViewer();
                viewer.LoadReport(report);
                viewer.ShowDialog();
            }

            // Print to default printer
            report.PrintToPrinter(1, false, 0, 0);
        }

        private void DeleteSelected()
        {
            // Only superadmin can delete; check like legacy form
            TblUser cur = Session.CurrentUser;
            if (cur == null || !string.Equals(cur.TipeUser, "SUPERADMIN", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Delete allowed only for SUPERADMIN and within 24 hours.");
                return;
            }
            List<string> ids = new List<string>();
            foreach (DataGridViewRow row in dgvPengiriman.Rows)
            {
                bool check = false;
                object cellVal = row.Cells["Select"].Value;
                if (cellVal != null)
                    bool.TryParse(cellVal.ToString(), out check);
                if (check)
                {
                    ids.Add(row.Cells["IDPengiriman"].Value.ToString());
                }
            }
            if (ids.Count == 0)
            {
                MessageBox.Show("Select records to delete.");
                return;
            }
            string msg = (ids.Count == 1) ? ("Delete shipment " + ids[0] + "?") : ("Delete " + ids.Count + " shipments?");
            DialogResult ans = MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ans != DialogResult.Yes)
                return;
            using (var tx = _db.Database.BeginTransaction())
            {
                foreach (string id in ids)
                {
                    TblPengiriman peng = _db.Pengirimans.Include("DetailPengiriman").FirstOrDefault(p => p.IDPengiriman == id);
                    if (peng != null)
                    {
                        foreach (var det in peng.DetailPengiriman.ToList())
                        {
                            _db.DetailPengirimans.Remove(det);
                        }
                        _db.Pengirimans.Remove(peng);
                    }
                }
                _db.SaveChanges();
                tx.Commit();
            }
            ReloadPengiriman();
        }

        /// <summary>
        /// Generates a new shipment ID like D-yy-MM-00001
        /// </summary>
        /// <returns></returns>
        private string GenerateNewId()
        {
            DateTime now = DateTime.Now;
            string prefix = "D-" + now.ToString("yy-MM") + "-";
            List<string> ids = _db.Pengirimans
                                  .Where(p => p.IDPengiriman.StartsWith(prefix))
                                  .Select(p => p.IDPengiriman)
                                  .ToList();
            int max = 0;
            foreach (string id in ids)
            {
                string[] parts = id.Split('-');
                if (parts.Length == 4)
                {
                    int n;
                    if (int.TryParse(parts[3], out n))
                    {
                        if (n > max)
                        {
                            max = n;
                        }
                    }
                }
            }
            return prefix + (max + 1).ToString("D5");
        }

        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // detach serial handlers
            if (_rfidPort != null && _rfidHandler != null)
                _rfidPort.DataReceived -= _rfidHandler;
            if (_measPort != null && _measHandler != null)
                _measPort.DataReceived -= _measHandler;
            base.OnFormClosed(e);
        }

        #region Event handlers

        private void DateRangeChanged(object sender, EventArgs e)
        {
            ReloadPengiriman();
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            ReloadPengiriman();
        }

        private void TxtSearchPeng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReloadPengiriman();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DgvPengiriman_SelectionChanged(object sender, EventArgs e)
        {
            LoadDetailForSelected();
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelectAll(chkAll.Checked);
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            ReloadPengiriman();
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            SendAckGet();
        }

        private void BtnSavePrint_Click(object sender, EventArgs e)
        {
            SaveAndPrint();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintSelected();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        public void PrepareToClose()
        {
            try
            {
                // Port 1 (RFID)
                if (_rfidHandler != null && _rfidPort != null)
                {
                    try
                    {
                        _rfidPort.DataReceived -= _rfidHandler;
                    }
                    catch { /* ignore */ }
                    _rfidHandler = null;
                }

                // Port 2 (Measurement)
                if (_measHandler != null && _measPort != null)
                {
                    try
                    {
                        _measPort.DataReceived -= _measHandler;
                    }
                    catch { /* ignore */ }
                    _measHandler = null;
                }
            }
            catch
            {
                // swallow top-level exceptions to avoid crash during form close
            }
        }
        #endregion

        private void PengirimanFormNew_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.ApplyDefaultStyle(dgvPengiriman, false);
            DataGridViewHelper.ApplyDefaultStyle(dgvPengirimanLive, false);
            BtnFilter_Click(null, null);
            txtSerialLog.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
            dgvPengiriman.Font = new Font("Segoe UI", 12f);
            dgvPengirimanLive.Font = new Font("Segoe UI", 12f);
        }

        
    }
}
