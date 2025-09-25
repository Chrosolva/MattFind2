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
using System.Text.RegularExpressions; // <— add this
using System.Data.Entity;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using System.Timers;
using System.Threading;

namespace SEALCHK.View
{
    public partial class RegisterSealForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        private TblMobilTangki selectedMT = null;
        private SerialDataReceivedEventHandler _dataReceivedHandler;
        private string[] _compartmentKodeTujuan;
        private string[] _compartmentNamaTujuan;

        private bool _listening = false;
        private DateTime _captureTime;
        private Queue<PartPick> _partsQueue;
        private HashSet<string> _seenSeals;
        private BindingList<RegisLiveItem> _liveItems;
        private System.Windows.Forms.Timer _regSearchTimer;
        private SerialPort SPRegis => Session.GlobalPort;

        private enum FormMode { AddNew, EditExisting }
        private FormMode _mode = FormMode.AddNew;

        private string _editNoPlat;
        private DateTime _editTglInput;

        //Collect Seal 
        private BindingList<CollectItem> _collectBuffer;
        private bool _collectListening = false;
        private HashSet<string> _collectSeenSeals;  // avoid duplicates during a session

        // Add below your existing fields in RegisterSealForm
        private readonly object _serialLock = new object();

        // Optional: track if we’re currently sending an ACK
        private volatile bool _sendingAck = false;

        private FrmMainMenu _parent;


        public RegisterSealForm()
        {
            InitializeComponent();
            
        }

        public RegisterSealForm(FrmMainMenu parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        // ------- Small DTOs -------
        private sealed class PartPick
        {
            public int PartIndex { get; set; }
            public string PartID { get; set; }
        }
        private sealed class RegisLiveItem
        {
            public int PartIndex { get; set; }
            public string PartID { get; set; }
            public string NoPlat { get; set; }
            public DateTime Tgl_Input { get; set; }
            public string Seal { get; set; }
            public string Status { get; set; }  // "REG"
            public string KodeTujuan { get; set; }
            public string Tujuan { get; set; }
            public DateTime? Tgl_Kirim { get; set; }
            public DateTime? Tgl_Kembali { get; set; }
            public string Keterangan { get; set; }
        }

        private sealed class CollectItem
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
            public string NoPlat { get; set; }         // NEW
            public DateTime Tgl_Input { get; set; }    // NEW (full timestamp)
        }



        // ================== INIT / UI ==================
        private void InitSerialUi()
        {
            if (_dataReceivedHandler == null)
            {
                _dataReceivedHandler = SPRegis_DataReceived;
                SPRegis.DataReceived += _dataReceivedHandler;
                SPRegis.ErrorReceived += SPRegis_ErrorReceived;
                SPRegis.PinChanged += SPRegis_PinChanged;
            }

            if(SPRegis.IsOpen)
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

        private void InitCollectUi()    
        {
            btnStartCollect.Click += btnStartCollect_Click;
            btnStopCollect.Click += btnStopCollect_Click;
            btnClearCollect.Click += (s, e) => txtCollect.Clear();
            btnSaveCollect.Click += btnSaveCollect_Click;

            // disable Stop/Save until listening begins
            btnStopCollect.Enabled = false;
            btnSaveCollect.Enabled = false;
        }


        private void UpdateUiForPortState(bool connected)
        {

            lblPortStatus.Text = connected
                ? "Connected: " + SPRegis.PortName + " @ " + SPRegis.BaudRate
                : "Disconnected";
            lblPortStatus.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
        }

        // ================== SERIAL OPEN/CLOSE ==================

        // ================== SERIAL READ ==================
        private void SPRegis_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            EnsureOpen();

            var sp = (SerialPort)sender;

            try
            {
                while (sp.IsOpen && sp.BytesToRead > 0)
                {
                    string line;
                    try
                    {
                        lock (_serialLock)
                        {
                            // wait if we are in the middle of writing an ACK (optional step 5)
                            if (_sendingAck) txtCollect.AppendText("serial lock is sending ACK");

                            line = sp.ReadLine(); // NewLine-based read
                        } // waits for NewLine or times out
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

        private void TryReconnectPort()
        {
            ResetArduino();

            lock (_serialLock)
            {
                try
                {
                    if (SPRegis.IsOpen)
                    {
                        SPRegis.Close();
                    }
                    SPRegis.Open();
                    UpdateUiForPortState(true);
                }
                catch (Exception ex)
                {
                    UpdateUiForPortState(false);
                    txtCollect.AppendText("Failed to reopen serial port: " + ex.Message);
                }
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
            txtCollect.AppendText(line + Environment.NewLine);
            //if (!_listening) return;

            if(_listening)
            {
                string seal;
                if (TryExtractSeal(line, out seal))
                {
                    if (_seenSeals.Contains(seal)) return;              // in-session duplicate
                    if (CheckDuplicateSealInDb(seal)) return;           // historical duplicate

                    _seenSeals.Add(seal);
                    AssignSealToNextPart(seal);
                }
            }

            // New: collect logic
            if (_collectListening)
            {
                string code;
                if (TryExtractCollectSeal(line, out code))
                {
                    TryAddCollectItem(code);
                }
            }
        }

        // "[1234567]" -> "1234567"
        private bool TryExtractSeal(string line, out string seal)
        {
            seal = null;
            if (string.IsNullOrWhiteSpace(line)) return false;

            line = line.Trim();
            if (line.Length >= 3 && line.StartsWith("[") && line.EndsWith("]"))
            {
                var inner = line.Substring(1, line.Length - 2).Trim();
                if (inner.Length > 0)
                {
                    seal = inner;
                    return true;
                }
            }
            return false;
        }

        private void AssignSealToNextPart(string seal)
        {
            if (_partsQueue == null || _partsQueue.Count == 0)
            {
                lblPortStatus.Text = "All parts already filled.";
                lblPortStatus.ForeColor = Color.ForestGreen;
                return;
            }

            var part = _partsQueue.Dequeue();
            var noPlat = cbxNoPlat.SelectedValue != null ? cbxNoPlat.SelectedValue.ToString()
                         : (selectedMT != null ? selectedMT.NoPlat : "");

            string tujuanCode = null;
            string tujuanName = null;
            var compIdx = TryGetCompartmentIndexFromPartId(part.PartID);
            if (compIdx.HasValue && _compartmentKodeTujuan != null &&
                compIdx.Value >= 0 && compIdx.Value < _compartmentKodeTujuan.Length)
            {
                tujuanCode = _compartmentKodeTujuan[compIdx.Value];
                tujuanName = _compartmentNamaTujuan[compIdx.Value];
            }

            _liveItems.Add(new RegisLiveItem
            {
                PartIndex = part.PartIndex,
                PartID = part.PartID,
                NoPlat = noPlat,
                Tgl_Input = _captureTime,
                Seal = seal,
                Status = "DIKIRIM",
                KodeTujuan = string.IsNullOrWhiteSpace(tujuanCode) ? null : tujuanCode.Trim(),
                Tujuan = string.IsNullOrWhiteSpace(tujuanName) ? null : tujuanName.Trim(),
                Tgl_Kirim = _captureTime,
                Keterangan = null
            });

            if (ProListen.Value < ProListen.Maximum) ProListen.Value++;

            if (_partsQueue.Count == 0)
            {
                _listening = false;
                lblPortStatus.Text = "Capture complete.";
                lblPortStatus.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblPortStatus.Text = "Captured " + ProListen.Value + "/" + ProListen.Maximum;
                lblPortStatus.ForeColor = Color.DodgerBlue;
            }
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


        // ================== LOAD LISTS ==================
        private void RegisterSealForm_Load(object sender, EventArgs e)
        {
            InitSerialUi();
            InitCollectUi();
            DataGridViewHelper.ApplyDefaultStyle(dgvManComPart, false, true);
            DataGridViewHelper.ApplyDefaultStyle(dgvBotLoadPart, false, true);
            DataGridViewHelper.ApplyDefaultStyle(dgvPCovPart, false, true);
            DataGridViewHelper.ApplyDefaultStyle(dgvRegisLive);
            DataGridViewHelper.ApplyDefaultStyle(dgvCollectBuffer);

            InitRegisterSearchUi();
            LoadRegister();
            LoadNoPlatCombo();

            SPRegis.ReadTimeout = 500;

            // make rows taller and the checkbox column wider
            dgvManComPart.RowTemplate.Height = 40;
            dgvBotLoadPart.RowTemplate.Height = 40;
            dgvPCovPart.RowTemplate.Height = 40;

            dgvManComPart.Columns[0].Width = 50;
            dgvBotLoadPart.Columns[0].Width = 50;
            dgvPCovPart.Columns[0].Width = 50;

            _collectBuffer = new BindingList<CollectItem>();
            _collectSeenSeals = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            dgvCollectBuffer.DataSource = _collectBuffer;

            

        }



        private void LoadRegister()
        {
            // READ FILTERS
            string term = (txtRegSearch.Text ?? "").Trim();
            string searchBy = cbxRegSearchBy.SelectedItem as string ?? "All";

            DateTime from = dtpRegFrom.Value;
            DateTime toExcl = dtpRegTo.Value.AddDays(1);   // end-exclusive to include the whole "to" day
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
                .OrderByDescending(r => r.Tgl_Input)
                .ThenBy(r => r.NoPlat)
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


        private void LoadNoPlatCombo()
        {
            var items = _db.MobilTangki
                .OrderBy(x => x.NoPlat)
                .Select(x => new { x.NoPlat, x.Type, x.JlhCompartment, x.CoverBoxPanel, x.DetailStatus })
                .ToList();

            cbxNoPlat.DisplayMember = "NoPlat";
            cbxNoPlat.ValueMember = "NoPlat";
            cbxNoPlat.DataSource = items;
        }

        private void dgvRegister_SelectionChanged(object sender, EventArgs e)
        {
            var item = dgvRegister.CurrentRow?.DataBoundItem as TblRegister;
            if (item == null) return;

            // If exact DateTime equality fails in your DB, use the day-range version below
            LoadDetailRegister(item.NoPlat, item.Tgl_Input);
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

        private void EnterAddMode()
        {
            _mode = FormMode.AddNew;
            _editNoPlat = null;

            //_captureTime = DateTime.Now;
            _captureTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);
            _seenSeals = new HashSet<string>(StringComparer.Ordinal);

            ResetLiveGrid();
            ProListen.Value = 0;

            SetPartSelectorsEnabled(true);
            cbxNoPlat.Enabled = true;

            TCRegisterSeal.SelectedTab = TPAddEditSeal;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnterAddMode();
        }

        private void cbxNoPlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNoPlat.SelectedValue == null) return;

            var noPlat = cbxNoPlat.SelectedValue.ToString();
            UpdateMobilTangkiLabels(noPlat);
            LoadDetailMTGrids(noPlat);
            chkAllManCom.Checked = false;
            chkAllBotLoad.Checked = false;
            chkAllPCov.Checked = false;
        }

        private void UpdateMobilTangkiLabels(string noPlat)
        {
            var mt = _db.MobilTangki.AsNoTracking().FirstOrDefault(x => x.NoPlat == noPlat);
            if (mt == null)
            {
                lblType.Text = "-";
                lblJlhCompartment.Text = "-";
                lblPanelCover.Text = "-";
                return;
            }
            lblType.Text = mt.Type ?? "-";
            lblJlhCompartment.Text = (mt.JlhCompartment ?? 0).ToString();
            lblPanelCover.Text = (mt.CoverBoxPanel ?? 0).ToString();
            selectedMT = mt;
        }

        private void LoadDetailMTGrids(string noPlat)
        {
            var allParts = _db.DetailMT
                .AsNoTracking()
                .Where(d => d.NoPlat == noPlat)
                .Select(d => new { d.PartID, d.SealCode, d.Status, d.PartIndex })
                .ToList();

            Func<int?, int> orderKey = pi => pi ?? int.MaxValue;

            var manCom = allParts.Where(p => p.PartID.Contains("_ManCom"))
                                 .OrderBy(p => orderKey(p.PartIndex)).ThenBy(p => p.PartID).ToList();
            var botLoad = allParts.Where(p => p.PartID.Contains("_BotLoad"))
                                  .OrderBy(p => orderKey(p.PartIndex)).ThenBy(p => p.PartID).ToList();
            var panelCover = allParts.Where(p => p.PartID.Contains("_PCover") || p.PartID.Contains("_PanelCover"))
                                     .OrderBy(p => orderKey(p.PartIndex)).ThenBy(p => p.PartID).ToList();

            dgvManComPart.AutoGenerateColumns = true; dgvManComPart.DataSource = manCom;
            dgvBotLoadPart.AutoGenerateColumns = true; dgvBotLoadPart.DataSource = botLoad;
            dgvPCovPart.AutoGenerateColumns = true; dgvPCovPart.DataSource = panelCover;

            if (dgvManComPart.Columns.Count > 0) dgvManComPart.Columns[0].ReadOnly = false;
            if (dgvBotLoadPart.Columns.Count > 0) dgvBotLoadPart.Columns[0].ReadOnly = false;
            if (dgvPCovPart.Columns.Count > 0) dgvPCovPart.Columns[0].ReadOnly = false;
        }

        // ================== SELECT-ALL CHECKBOXES ==================
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

        private void chkAllManCom_CheckedChanged(object sender, EventArgs e) => SetAllChecks(dgvManComPart, chkAllManCom.Checked);
        private void chkAllBotLoad_CheckedChanged(object sender, EventArgs e) => SetAllChecks(dgvBotLoadPart, chkAllBotLoad.Checked);
        private void chkAllPCov_CheckedChanged(object sender, EventArgs e) => SetAllChecks(dgvPCovPart, chkAllPCov.Checked);

        // ================== CLEAR LOG ==================
        private void btnClearLog_Click(object sender, EventArgs e) => txtSerialLog.Text = "";

        // ================== FORM CLOSE ==================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        // ================== CAPTURE FLOW ==================
        private void btnStartListen_Click(object sender, EventArgs e)
        {
            if (_mode == FormMode.EditExisting)
            {
                MessageBox.Show("Start Listening is only for adding new captures.", "Edit Mode",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!SPRegis.IsOpen)
            {
                MessageBox.Show("Connect the serial port first.", "Serial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Require destinations set (optional but recommended)
            if (_compartmentKodeTujuan == null || _compartmentKodeTujuan.Length == 0)
            {
                MessageBox.Show("Set destination (KodeTujuan) per compartment terlebih dahulu.",
                                "Tujuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            dgvManComPart.EndEdit();
            dgvBotLoadPart.EndEdit();
            dgvPCovPart.EndEdit();
            dgvManComPart.Enabled = false;
            dgvBotLoadPart.Enabled = false;
            dgvPCovPart.Enabled = false;
            chkAllManCom.Enabled = false;
            chkAllBotLoad.Enabled = false;
            chkAllPCov.Enabled = false;

            // NEW: ensure checked parts are empty
            if (!ValidateSelectedPartsAreEmpty()) return;

            var picks = CollectSelectedParts();
            if (picks.Count == 0)
            {
                MessageBox.Show("Check at least one part.", "Capture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //_captureTime = DateTime.Now;
            _captureTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);
            _partsQueue = new Queue<PartPick>(picks);
            _seenSeals = new HashSet<string>(StringComparer.Ordinal);
            _liveItems = new BindingList<RegisLiveItem>();

            dgvRegisLive.AutoGenerateColumns = true;
            dgvRegisLive.DataSource = _liveItems;
            dgvRegisLive.ReadOnly = false;

            foreach (DataGridViewColumn col in dgvRegisLive.Columns)
            {
                var name = col.DataPropertyName;
                if (name == "PartIndex" || name == "PartID" || name == "NoPlat"
                    || name == "Tgl_Input" || name == "Seal" || name == "Status" || name == "KodeTujuan" || name == "Tujuan")
                {
                    col.ReadOnly = true;
                }
            }

            ProListen.Maximum = picks.Count;
            ProListen.Value = 0;

            _listening = true;
            lblPortStatus.Text = "Listening... waiting " + picks.Count + " unique seal(s)";
            lblPortStatus.ForeColor = Color.DodgerBlue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_liveItems == null || _liveItems.Count == 0)
            {
                MessageBox.Show("No captured rows to save.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var noPlat = cbxNoPlat.SelectedValue?.ToString() ?? selectedMT?.NoPlat;
            if (string.IsNullOrWhiteSpace(noPlat))
            {
                MessageBox.Show("NoPlat is required.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tglInput = _captureTime == default(DateTime) ? DateTime.Now : _captureTime;

            try
            {
                using (var tx = _db.Database.BeginTransaction())
                {
                    // block if the exact composite key already exists
                    bool registerExists = _db.Registers.AsNoTracking()
                        .Any(r => r.NoPlat == noPlat && DbFunctions.DiffSeconds(r.Tgl_Input, tglInput) == 0);

                    if (registerExists)
                    {
                        MessageBox.Show(
                            "A Register with the same NoPlat and exact Tgl_Input already exists.\r\n" +
                            "Insert-only mode blocks overwriting. Start a new capture to create a new Register.",
                            "Save blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // create register and assign current user
                    var register = new TblRegister
                    {
                        NoPlat = noPlat,
                        Tgl_Input = tglInput,
                        Tujuan = txtTujuan.Text?.Trim(),
                        Status = "DIKIRIM",
                        UserINPUT = Session.CurrentUser?.UserID ?? Environment.UserName
                    };
                    _db.Registers.Add(register);

                    // deduplicate _liveItems by PartID (all share same NoPlat and Tgl_Input)
                    var uniqueDetails = _liveItems
                        .GroupBy(it => it.PartID)
                        .Select(g => g.First())
                        .ToList();

                    int inserted = 0, skipped = 0;

                    foreach (var it in uniqueDetails)
                    {
                        bool exists = _db.DetailRegisters.AsNoTracking()
                            .Any(dr => dr.NoPlat == noPlat && dr.PartID == it.PartID &&
                                       DbFunctions.DiffSeconds(dr.Tgl_Input, tglInput) == 0);
                        if (exists)
                        {
                            skipped++;
                            continue;
                        }

                        var d = new TblDetailRegister
                        {
                            // set composite FK values explicitly
                            NoPlat = register.NoPlat,
                            Tgl_Input = register.Tgl_Input,

                            PartID = it.PartID,
                            Seal = it.Seal,
                            Status = it.Status,
                            KodeTujuan = it.KodeTujuan,
                            Tujuan = it.Tujuan,
                            Tgl_Kirim = it.Tgl_Kirim,
                            Tgl_Kembali = it.Tgl_Kembali,
                            Keterangan = it.Keterangan,
                            // still set the navigation property if you need it
                            Register = register
                        };
                        _db.DetailRegisters.Add(d);
                        inserted++;

                        //var mt = _db.DetailMT.FirstOrDefault(x => x.PartID == it.PartID && x.NoPlat == noPlat);
                        //if (mt != null)
                        //{
                        //    mt.SealCode = it.Seal;
                        //    mt.Status = "DIKIRIM";
                        //}
                    }

                    _db.SaveChanges();
                    tx.Commit();

                    MessageBox.Show(
                        $"Saved Register.\r\nDetails inserted: {inserted}\r\nDetails skipped (already exist): {skipped}",
                        "Save successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _listening = false;
                    _liveItems?.Clear();
                    _partsQueue?.Clear();
                    _seenSeals?.Clear();
                    ProListen.Value = 0;

                    SetPartSelectorsEnabled(true);
                    cbxNoPlat.Enabled = true;
                    TCRegisterSeal.SelectedTab = TPRegister;

                    LoadRegister();
                    LoadDetailRegister(noPlat, tglInput);
                    cbxNoPlat.SelectedIndex = 0;
                    UpdateMobilTangkiLabels(noPlat);
                    LoadDetailMTGrids(noPlat);
                    TCRegisterSeal.SelectedTab = TPRegister;
                }
            }
            catch (Exception ex)
            {
                // build full error message with inner exceptions
                var sb = new StringBuilder();
                sb.AppendLine("Save failed:");
                sb.AppendLine(ex.Message);
                var inner = ex.InnerException;
                while (inner != null)
                {
                    sb.AppendLine("Inner exception: " + inner.Message);
                    inner = inner.InnerException;
                }

                MessageBox.Show(sb.ToString(), "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    // ================== HELPERS ==================
    private List<PartPick> CollectSelectedParts()
        {
            var result = new List<PartPick>(16);
            CollectFromGrid(result, dgvManComPart);
            CollectFromGrid(result, dgvBotLoadPart);
            CollectFromGrid(result, dgvPCovPart);

            return result
                .OrderBy(p => p.PartIndex == 0 ? int.MaxValue : p.PartIndex)
                .ThenBy(p => p.PartID)
                .ToList();
        }

        private void CollectFromGrid(List<PartPick> result, DataGridView dgv)
        {
            if (dgv == null || dgv.Rows.Count == 0) return;

            bool hasPartId = dgv.Columns.Contains("PartID");
            bool hasPartIdx = dgv.Columns.Contains("PartIndex");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                // first column: checkbox
                bool isChecked = false;
                object v = row.Cells[0].Value;
                if (v is bool) isChecked = (bool)v; else if (v != null) bool.TryParse(v.ToString(), out isChecked);
                if (!isChecked) continue;

                object partIdObj = hasPartId ? row.Cells["PartID"].Value : GetCellValue(row, "PartID");
                object partIdxObj = hasPartIdx ? row.Cells["PartIndex"].Value : GetCellValue(row, "PartIndex");
                if (partIdObj == null) continue;

                int partIndex = 0;
                if (partIdxObj != null) int.TryParse(partIdxObj.ToString(), out partIndex);

                result.Add(new PartPick { PartID = partIdObj.ToString(), PartIndex = partIndex });
            }
        }

        // Fallback for when DataGridViewColumn.Name != DataPropertyName
        private static object GetCellValue(DataGridViewRow row, string columnName)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                var col = cell.OwningColumn;
                if (string.Equals(col.DataPropertyName, columnName, StringComparison.OrdinalIgnoreCase))
                    return cell.Value;
            }
            return null;
        }

        private bool CheckDuplicateSealInDb(string seal)
        {
            if (string.IsNullOrWhiteSpace(seal)) return false;

            try
            {
                bool existsInDetail = _db.DetailRegisters.AsNoTracking().Any(d => d.Seal == seal);
                bool existsInMt = _db.DetailMT.AsNoTracking().Any(m => m.SealCode == seal);

                if (existsInDetail || existsInMt)
                {
                    string msg = "SealCode '" + seal + "' has already been registered.";
                    if (existsInDetail) msg += " (DetailRegister)";
                    if (existsInMt) msg += " (DetailMT)";
                    MessageBox.Show(msg, "Duplicate Seal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking duplicate seal:\r\n" + ex.Message, "Duplicate Seal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Be conservative: block the seal if we cannot verify
                return true;
            }

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelListeningAndClear();
        }

        private void CancelListeningAndClear()
        {
            _listening = false;

            if (_partsQueue != null) _partsQueue.Clear();
            if (_seenSeals != null) _seenSeals.Clear();
            if (_liveItems != null) _liveItems.Clear();

            ProListen.Value = 0;
            lblPortStatus.Text = "Listening canceled.";
            lblPortStatus.ForeColor = Color.DarkOrange;

            //// Optional: also clear serial buffer
            //try { if (SPRegis.IsOpen) SPRegis.DiscardInBuffer(); } catch { }

            dgvManComPart.Enabled = true;
            dgvBotLoadPart.Enabled = true;
            dgvPCovPart.Enabled = true;
            chkAllManCom.Enabled = true;
            chkAllBotLoad.Enabled = true;
            chkAllPCov.Enabled = true;
        }

        // Call before starting to listen. Ensures all CHECKED rows in the 3 grids have SealCode == "-" (or empty).
        // Shows a single error listing offending PartIDs. Returns false if any are not empty.
        private bool ValidateSelectedPartsAreEmpty()
        {
            var occupied = new List<string>();

            ValidateGridForEmptySeal(dgvManComPart, occupied);
            ValidateGridForEmptySeal(dgvBotLoadPart, occupied);
            ValidateGridForEmptySeal(dgvPCovPart, occupied);

            if (occupied.Count > 0)
            {
                string msg = "These parts already have a SealCode and cannot be captured:\r\n" +
                             string.Join("\r\n", occupied);
                MessageBox.Show(msg, "Slots not empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ValidateGridForEmptySeal(DataGridView dgv, List<string> occupied)
        {
            if (dgv == null || dgv.Rows.Count == 0) return;

            bool hasPartId = dgv.Columns.Contains("PartID");
            bool hasSealCol = dgv.Columns.Contains("SealCode");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                // first column is your checkbox
                bool isChecked = false;
                object v = row.Cells[0].Value;
                if (v is bool) isChecked = (bool)v; else if (v != null) bool.TryParse(v.ToString(), out isChecked);
                if (!isChecked) continue;

                object partIdObj = hasPartId ? row.Cells["PartID"].Value : GetCellValue(row, "PartID");
                object sealObj = hasSealCol ? row.Cells["SealCode"].Value : GetCellValue(row, "SealCode");

                string partId = partIdObj == null ? "(unknown)" : partIdObj.ToString();
                string seal = sealObj == null ? null : sealObj.ToString();

                // empty if null/whitespace or exactly "-"
                bool isEmpty = string.IsNullOrWhiteSpace(seal) || seal.Trim() == "-";
                if (!isEmpty) occupied.Add(partId + " -> " + seal);
            }
        }

        // Add to RegisterSealForm (class body)
        public void PrepareToClose()
        {
            // stop listening UI-side
            _listening = false;
            _collectListening = false;

            // unsubscribe events first
            try
            {
                if (_dataReceivedHandler != null && SPRegis != null)
                {
                    SPRegis.DataReceived -= _dataReceivedHandler;
                    SPRegis.ErrorReceived -= SPRegis_ErrorReceived;
                    SPRegis.PinChanged -= SPRegis_PinChanged;
                    _dataReceivedHandler = null;
                }
            }
            catch { /* ignore */ }

            //// close & dispose the port
            //try
            //{
            //    if (SPRegis != null)
            //    {
            //        if (SPRegis.IsOpen) SPRegis.Close();
            //        SPRegis.Dispose(); // release handle
            //    }
            //}
            //catch { /* ignore */ }
        }

        // Ensure cleanup when the embedded form/control is destroyed
        //protected override void OnHandleDestroyed(EventArgs e)
        //{
        //    if (!this.RecreatingHandle)
        //        PrepareToClose();
        //    base.OnHandleDestroyed(e);
        //}

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

        // Tries to extract the compartment index (0-based) from a PartID.
        // Supports "..._ManCom3" or "..._BotLoad3". Returns null if unknown.
        private int? TryGetCompartmentIndexFromPartId(string partId)
        {
            if (string.IsNullOrWhiteSpace(partId)) return null;

            // Looks for _ManCom{n} or _BotLoad{n}
            Match m = Regex.Match(partId, @"_(?:ManCom|BotLoad)(\d+)\b", RegexOptions.IgnoreCase);
            if (!m.Success) return null;

            int oneBased;
            if (int.TryParse(m.Groups[1].Value, out oneBased) && oneBased > 0)
                return oneBased - 1; // 0-based for array index

            return null;
        }

        private void ResetLiveGrid()
        {
            _liveItems = new BindingList<RegisLiveItem>();
            dgvRegisLive.AutoGenerateColumns = true;
            dgvRegisLive.DataSource = _liveItems;

            // Keys & computed fields should not be edited
            foreach (DataGridViewColumn col in dgvRegisLive.Columns)
            {
                var n = col.DataPropertyName;
                col.ReadOnly = n == "PartIndex" || n == "PartID" || n == "NoPlat" || n == "Tgl_Input" || n == "Seal" || n == "Status";
            }
        }

        private void SetPartSelectorsEnabled(bool on)
        {
            dgvManComPart.Enabled = on;
            dgvBotLoadPart.Enabled = on;
            dgvPCovPart.Enabled = on;
            chkAllManCom.Enabled = on;
            chkAllBotLoad.Enabled = on;
            chkAllPCov.Enabled = on;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var sel = dgvRegister.CurrentRow?.DataBoundItem as TblRegister;
            if (sel == null) { MessageBox.Show("Select a register row first."); return; }

            EnterEditMode(sel.NoPlat, sel.Tgl_Input);
            TCRegisterSeal.SelectedTab = TPAddEditSeal;
        }

        private void EnterEditMode(string noPlat, DateTime tglInput)
        {
            _mode = FormMode.EditExisting;
            _editNoPlat = noPlat;
            _editTglInput = tglInput;
            _captureTime = tglInput;    // keep original timestamp

            // lock NoPlat while editing this register
            cbxNoPlat.SelectedValue = noPlat;
            cbxNoPlat.Enabled = false;

            ResetLiveGrid();
            SetPartSelectorsEnabled(false);  // editing existing rows; not selecting parts

            // Load existing details ordered by PartIndex
            var start = tglInput.Date;
            var end = start.AddDays(1);

            var list =
                (from d in _db.DetailRegisters.AsNoTracking()
                 where d.NoPlat == noPlat && d.Tgl_Input >= start && d.Tgl_Input < end
                 join m in _db.DetailMT.AsNoTracking()
                     on new { d.NoPlat, d.PartID } equals new { m.NoPlat, m.PartID } into gj
                 from m in gj.DefaultIfEmpty()
                 orderby (m.PartIndex ?? int.MaxValue), d.PartID
                 select new RegisLiveItem
                 {
                     PartIndex = m.PartIndex ?? int.MaxValue,
                     PartID = d.PartID,
                     NoPlat = d.NoPlat,
                     Tgl_Input = d.Tgl_Input,
                     Seal = d.Seal,
                     Status = d.Status,
                     KodeTujuan = d.KodeTujuan,
                     Tujuan = d.Tujuan,
                     Tgl_Kirim = d.Tgl_Kirim,
                     Tgl_Kembali = d.Tgl_Kembali,
                     Keterangan = d.Keterangan
                 }).ToList();

            foreach (var row in list) _liveItems.Add(row);

            ProListen.Maximum = _liveItems.Count;
            ProListen.Value = _liveItems.Count;
            _listening = false;
        }

        private void btnApplyTujuan_Click(object sender, EventArgs e)
        {
            ApplyCurrentTujuanToLiveGrid(updateOnlyIfBlank: false);  // set true to only fill blanks
        }

        /// <summary>
        /// Re-applies _compartmentKodeTujuan / _compartmentNamaTujuan to dgvRegisLive rows
        /// by mapping PartID -> compartment index (via TryGetCompartmentIndexFromPartId).
        /// </summary>
        private void ApplyCurrentTujuanToLiveGrid(bool updateOnlyIfBlank)
        {
            if (_compartmentKodeTujuan == null || _compartmentKodeTujuan.Length == 0)
            {
                MessageBox.Show("Set destination per compartment terlebih dahulu (Set Data Tujuan).",
                                "Tujuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvRegisLive.Rows.Count == 0)
            {
                MessageBox.Show("No rows to update in the live grid.", "Tujuan",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Sanity: required columns?
            if (!dgvRegisLive.Columns.Contains("PartID") ||
                !dgvRegisLive.Columns.Contains("KodeTujuan") ||
                !dgvRegisLive.Columns.Contains("Tujuan"))
            {
                MessageBox.Show("Live grid is missing required columns (PartID, KodeTujuan, Tujuan).",
                                "Tujuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int updated = 0;

            foreach (DataGridViewRow row in dgvRegisLive.Rows)
            {
                if (row.IsNewRow) continue;

                var partIdObj = row.Cells["PartID"].Value;
                var partId = partIdObj?.ToString();
                if (string.IsNullOrWhiteSpace(partId)) continue;

                var compIdx = TryGetCompartmentIndexFromPartId(partId);
                if (!compIdx.HasValue) continue; // e.g. Panel Cover rows (no compartment)
                int idx = compIdx.Value;

                if (idx < 0 || idx >= _compartmentKodeTujuan.Length) continue;

                // Pull new values from arrays
                string kode = _compartmentKodeTujuan[idx];
                string nama = (_compartmentNamaTujuan != null && idx < _compartmentNamaTujuan.Length)
                                ? _compartmentNamaTujuan[idx]
                                : null;

                if (updateOnlyIfBlank)
                {
                    var curKode = Convert.ToString(row.Cells["KodeTujuan"].Value);
                    var curNama = Convert.ToString(row.Cells["Tujuan"].Value);

                    if (string.IsNullOrWhiteSpace(curKode) && !string.IsNullOrWhiteSpace(kode))
                        row.Cells["KodeTujuan"].Value = kode.Trim();

                    if (string.IsNullOrWhiteSpace(curNama) && !string.IsNullOrWhiteSpace(nama))
                        row.Cells["Tujuan"].Value = nama.Trim();
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(kode))
                        row.Cells["KodeTujuan"].Value = kode.Trim();

                    if (!string.IsNullOrWhiteSpace(nama))
                        row.Cells["Tujuan"].Value = nama.Trim();
                }

                updated++;
            }

            // Optional: also refresh the summary textbox
            txtTujuan.Text = ComposeTujuanSummaryText(_compartmentKodeTujuan);

            lblPortStatus.Text = $"Reapplied tujuan to {updated} row(s).";
            lblPortStatus.ForeColor = Color.DodgerBlue;

            // If you're also keeping _liveItems in sync (not required for UI), update it here:
            try
            {
                if (_liveItems != null && _liveItems.Count == dgvRegisLive.Rows.Count)
                {
                    for (int i = 0; i < _liveItems.Count; i++)
                    {
                        var r = dgvRegisLive.Rows[i];
                        if (r.IsNewRow) continue;
                        _liveItems[i].KodeTujuan = Convert.ToString(r.Cells["KodeTujuan"].Value);
                        _liveItems[i].Tujuan = Convert.ToString(r.Cells["Tujuan"].Value);
                    }
                }
            }
            catch { /* non-fatal */ }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser.TipeUser != "SUPERADMIN")
            {
                MessageBox.Show("Anda Tidak Memiliki Hak Akses Untuk Tombol ini , Hubungi SUPERADMIN. Delete hanya bisa digunakan oleh SUPERADMIN & kurang dari 24 jam");
                return;
            }

            var row = dgvRegister.CurrentRow?.DataBoundItem as TblRegister;
            if (row == null)
            {
                MessageBox.Show("Select a Register row first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // refetch the register by exact composite key
            var keyTime = TrimToSeconds(row.Tgl_Input);
            var reg = _db.Registers.FirstOrDefault(r =>
                r.NoPlat == row.NoPlat && DbFunctions.DiffSeconds(r.Tgl_Input, keyTime) == 0);
            if (reg == null)
            {
                MessageBox.Show("The selected Register no longer exists.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadRegister();
                return;
            }

            // check protection rules
            TimeSpan span = DateTime.Now - reg.Tgl_Input;
            if (!string.Equals(reg.Status, "DIKIRIM", StringComparison.OrdinalIgnoreCase) && span.TotalDays < 1)
            {
                MessageBox.Show(
                    $"This Register is protected and cannot be deleted because Status = \"{reg.Status}\".",
                    "Protected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // count details for confirmation
            int detailCount = _db.DetailRegisters.Count(d =>
                d.NoPlat == reg.NoPlat && DbFunctions.DiffSeconds(d.Tgl_Input, keyTime) == 0);

            var confirm = MessageBox.Show(
                $"Delete Register {reg.NoPlat} ({reg.Tgl_Input:yyyy-MM-dd HH:mm}) and its {detailCount} detail(s)?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var tx = _db.Database.BeginTransaction())
                {
                    // We match sub-second timestamps using a start/end range
                    var start = keyTime;
                    var end = keyTime.AddSeconds(1);

                    // 1) delete matching detail rows
                    string sqlDetails =
                        @"DELETE FROM TblDetailRegister
                  WHERE NoPlat = @p0 AND Tgl_Input >= @p1 AND Tgl_Input < @p2";
                    _db.Database.ExecuteSqlCommand(sqlDetails, reg.NoPlat, start, end);

                    // 2) delete the register row itself
                    string sqlRegister =
                        @"DELETE FROM TblRegister
                  WHERE NoPlat = @p0 AND Tgl_Input >= @p1 AND Tgl_Input < @p2";
                    _db.Database.ExecuteSqlCommand(sqlRegister, reg.NoPlat, start, end);

                    // 3) reset all DetailMT rows for this truck
                    string sqlUpdateMt =
                        @"UPDATE TblDetailMT
                  SET SealCode = '-', Status = '-'
                  WHERE NoPlat = @p0";
                    _db.Database.ExecuteSqlCommand(sqlUpdateMt, reg.NoPlat);

                    tx.Commit();
                }

                MessageBox.Show("Register deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // refresh the grids
                LoadRegister();
                if (dgvRegister.Rows.Count > 0)
                {
                    var nextNoPlat = dgvRegister.CurrentRow.Cells[0].Value.ToString();
                    var nextTgl = Convert.ToDateTime(dgvRegister.CurrentRow.Cells[1].Value);
                    LoadDetailRegister(nextNoPlat, nextTgl);
                    UpdateMobilTangkiLabels(nextNoPlat);
                    LoadDetailMTGrids(nextNoPlat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed:\r\n" + ex.ToString(),
                    "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var dlg = new FindMT(_db))
            {
                dlg.StartPosition = FormStartPosition.CenterParent;

                if (dlg.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.SelectedNoPlat))
                {
                    var noPlat = dlg.SelectedNoPlat;

                    // Ensure combobox contains it (refresh list if needed)
                    var ds = cbxNoPlat.DataSource as System.Collections.IEnumerable;
                    bool hasIt = false;
                    if (ds != null)
                    {
                        foreach (var item in ds)
                        {
                            var prop = item.GetType().GetProperty("NoPlat");
                            var value = prop?.GetValue(item, null)?.ToString();
                            if (string.Equals(value, noPlat, StringComparison.OrdinalIgnoreCase))
                            {
                                hasIt = true;
                                break;
                            }
                        }
                    }

                    if (!hasIt)
                    {
                        // Refill cbx to include the selected plate (cheap & safe)
                        LoadNoPlatCombo();
                    }

                    // Select it – this will trigger your SelectedIndexChanged (already working)
                    cbxNoPlat.SelectedValue = noPlat;
                }
            }
        }

        private void dgvManComPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            // Only handle clicks on the first column (checkbox column) and ignore header row
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool current = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !current;
            }
            // commit immediately so the UI reflects the change
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgv.EndEdit();
        }

        private void dgvPCovPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            // Only handle clicks on the first column (checkbox column) and ignore header row
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool current = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !current;
            }
            // commit immediately so the UI reflects the change
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgv.EndEdit();
        }

        private void dgvBotLoadPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            // Only handle clicks on the first column (checkbox column) and ignore header row
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool current = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !current;
            }
            // commit immediately so the UI reflects the change
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgv.EndEdit();
        }

        #region CollectDetail

        private void btnStartCollect_Click(object sender, EventArgs e)
        {
            // Block if still doing register scan
            if (_listening)
            {
                MessageBox.Show("Finish Register seal capturing before starting Collect.");
                return;
            }
            if (!SPRegis.IsOpen)
            {
                MessageBox.Show("Serial port is not connected.");
                return;
            }

            //test using timer 
            timer1.Interval = 400;
            //timer1.Start();

            // Clear previous buffer and seen seals
            _collectBuffer.Clear();
            _collectSeenSeals.Clear();
            txtCollect.Clear();

            _collectListening = true;
            lblCollectStatus.Text = "Listening (collect)…";
            lblCollectStatus.ForeColor = Color.DodgerBlue;

            btnStartCollect.Enabled = false;
            btnStopCollect.Enabled = true;
            btnSaveCollect.Enabled = true;
        }

        private void btnStopCollect_Click(object sender, EventArgs e)
        {
            _collectListening = false;
            lblCollectStatus.Text = "Collect stopped.";
            lblCollectStatus.ForeColor = Color.DarkOrange;
            //timer1.Stop();

            // Disable stop, allow save if there is anything
            btnStopCollect.Enabled = false;
            btnStartCollect.Enabled = true;
            btnSaveCollect.Enabled  = _collectBuffer.Count > 0;

            // If you want to reset everything on stop, also clear buffer/seen set:
            // _collectBuffer.Clear();
            // _collectSeenSeals.Clear();
        }

        private bool TryExtractCollectSeal(string line, out string seal)
        {
            seal = null;
            if (string.IsNullOrWhiteSpace(line)) return false;
            line = line.Trim();
            if (line.Length >= 3 && line.StartsWith("*") && line.EndsWith("#"))
            {
                var inner = line.Substring(1, line.Length - 2).Trim();
                // allow dashes or alpha characters etc.
                seal = inner;
                return true;
            }
            return false;
        }

        //public void WriteToPort(string data)
        //{
        //    try
        //    {
        //        SPRegis.Write(data);
        //    }
        //    catch (Exception ex)
        //    {
        //        // handle or attempt reconnect
        //    }
        //}

        private void SafeWriteToSerial(string message)
        {
            EnsureOpen();

            try
            {
                lock (_serialLock)
                {
                    _sendingAck = true; 
                    if (SPRegis.IsOpen)
                    {
                        SPRegis.Write(message);
                    }
                }
            }

            catch (Exception ex)
            {
                // handle write error
                txtSerialLog.AppendText(ex.Message + "\n");
                txtCollect.AppendText(ex.Message + "\n");
            }
            finally
            {
                _sendingAck = false;
            }
        }


        private void TryAddCollectItem(string seal)
        {
            // Already collected in this session
            if (_collectSeenSeals.Contains(seal))
            {
                txtCollect.AppendText($"already scanned : {seal}\r\n");
                try { SafeWriteToSerial("*2#"); } catch { /* ignore */ }
                return;
            }

            // Lookup the detail to find register key and base fields
            var detail = (from d in _db.DetailRegisters.AsNoTracking()
                          join m in _db.DetailMT.AsNoTracking()
                            on new { d.NoPlat, d.PartID } equals new { m.NoPlat, m.PartID } into g
                          from m in g.DefaultIfEmpty()
                          where d.Seal == seal
                          select new { d, m }).FirstOrDefault();
            if (detail == null)
            {
                // Unknown code – just log
                txtCollect.AppendText($"Unknown seal: {seal}\r\n");
                return;
            }

            // Get the register row (exact composite key)
            var regKey = TrimToSeconds(detail.d.Tgl_Input);
            var reg = _db.Registers.AsNoTracking()
                      .FirstOrDefault(r => r.NoPlat == detail.d.NoPlat &&
                                           DbFunctions.DiffSeconds(r.Tgl_Input, regKey) == 0);
            if (reg == null)
            {
                txtCollect.AppendText($"Register not found for seal: {seal}\r\n");
                return;
            }

            // Compute lateness based on Tgl_Input
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Session.tzi);
            bool isLate = (now - reg.Tgl_Input).TotalHours > 48.0;

            // Add to buffer
            var ci = new CollectItem
            {
                NoPlat = reg.NoPlat,
                Tgl_Input = regKey,
                PartIndex = detail.m?.PartIndex,
                PartID = detail.d.PartID,
                Seal = seal,
                Status = "DIKEMBALIKAN",
                KodeTujuan = detail.d.KodeTujuan,
                Tujuan = detail.d.Tujuan,
                Tgl_Kirim = detail.d.Tgl_Kirim,
                Tgl_Kembali = now,
                Keterangan = isLate ? "TERLAMBAT" : "TEPAT WAKTU"
            };
            _collectBuffer.Add(ci);
            _collectSeenSeals.Add(seal);

            try { SafeWriteToSerial("*2#"); } catch { /* ignore */ }

            // Update status label
            lblCollectStatus.Text = $"Collecting… { _collectBuffer.Count } captured";
            lblCollectStatus.ForeColor = Color.DodgerBlue;
        }


        private void btnSaveCollect_Click(object sender, EventArgs e)
        {
            if (_collectBuffer.Count == 0)
            {
                MessageBox.Show("No collected seals to save.");
                return;
            }

            using (var tx = _db.Database.BeginTransaction())
            {
                try
                {
                    // Group by composite key (NoPlat & exact Tgl_Input)
                    var groups = _collectBuffer
                        .GroupBy(ci => new { ci.NoPlat, ci.Tgl_Input })
                        .ToList();

                    foreach (var g in groups)
                    {
                        string noPlat = g.Key.NoPlat;
                        DateTime keyStart = g.Key.Tgl_Input;
                        DateTime keyEnd = keyStart.AddSeconds(1);

                        // 1) Raw SQL to update each collected detail row
                        foreach (var item in g)
                        {
                            var p = new[]
                            {
                        new SqlParameter("@noPlat",    noPlat),
                        new SqlParameter("@partId",    item.PartID),
                        new SqlParameter("@keyStart",  keyStart),
                        new SqlParameter("@keyEnd",    keyEnd),
                        new SqlParameter("@tglKembali",(object)item.Tgl_Kembali ?? DBNull.Value),
                        new SqlParameter("@ket",       (object)item.Keterangan ?? (object)DBNull.Value),
                    };

                            var sqlUpdateDetail = @"
                        UPDATE TblDetailRegister
                           SET Tgl_Kembali = @tglKembali,
                               Status      = 'DIKEMBALIKAN',
                               Keterangan  = @ket
                        WHERE NoPlat     = @noPlat
                          AND PartID     = @partId
                          AND Tgl_Input >= @keyStart
                          AND Tgl_Input <  @keyEnd;";
                            _db.Database.ExecuteSqlCommand(sqlUpdateDetail, p);
                        }

                        // 2) Mark any unreturned items for the same register as 'HILANG'
                        {
                            var p = new[]
                            {
                        new SqlParameter("@noPlat",   noPlat),
                        new SqlParameter("@keyStart", keyStart),
                        new SqlParameter("@keyEnd",   keyEnd)
                    };
                            var sqlMarkMissing = @"
                        UPDATE TblDetailRegister
                           SET Status     = 'HILANG',
                               Keterangan = 'TIDAK PERNAH KEMBALI'
                        WHERE NoPlat     = @noPlat
                          AND Tgl_Input >= @keyStart
                          AND Tgl_Input <  @keyEnd
                          AND Tgl_Kembali IS NULL;";
                            _db.Database.ExecuteSqlCommand(sqlMarkMissing, p);
                        }

                        // 3) Update header register status to 'DIKEMBALIKAN' and set UserOUT
                        {
                            var p = new[]
                            {
                        new SqlParameter("@noPlat",   noPlat),
                        new SqlParameter("@keyStart", keyStart),
                        new SqlParameter("@keyEnd",   keyEnd),
                        new SqlParameter("@userOut",  Session.CurrentUser?.UserID ?? "-")
                    };
                            var sqlUpdateHeader = @"
                        UPDATE TblRegister
                           SET Status  = 'DIKEMBALIKAN',
                               UserINPUT = @userOut
                        WHERE NoPlat     = @noPlat
                          AND Tgl_Input >= @keyStart
                          AND Tgl_Input <  @keyEnd;";
                            _db.Database.ExecuteSqlCommand(sqlUpdateHeader, p);
                        }
                    }

                    // 4) Reset SealCode & Status for all affected trucks once
                    var affectedPlates = groups.Select(g => g.Key.NoPlat).Distinct().ToList();
                    foreach (var plate in affectedPlates)
                    {
                        _db.Database.ExecuteSqlCommand(
                            "UPDATE TblDetailMT SET SealCode='-', Status='-' WHERE NoPlat=@p0",
                            new SqlParameter("@p0", plate));
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("Save collect failed:\r\n" + ex.Message,
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Clear buffer & seen seals; reset UI
            _collectBuffer.Clear();
            _collectSeenSeals.Clear();
            lblCollectStatus.Text = "Collect saved.";
            lblCollectStatus.ForeColor = Color.ForestGreen;

            btnSaveCollect.Enabled = false;
            btnStartCollect.Enabled = true;

            // Refresh grids
            LoadRegister();
            TCRegisterSeal.SelectedTab = TPRegister;
            if (dgvRegister.Rows.Count > 0)
            {
                string nextNoPlat = dgvRegister.Rows[0].Cells[0].Value.ToString();
                DateTime nextTgl = Convert.ToDateTime(dgvRegister.Rows[0].Cells[1].Value);
                LoadDetailRegister(nextNoPlat, nextTgl);
            }
        }



        #endregion

        private void dgvCollectBuffer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCollectBuffer.Columns[e.ColumnIndex].DataPropertyName == "Keterangan")
            {
                var txt = Convert.ToString(e.Value);
                var cell = dgvCollectBuffer.Rows[e.RowIndex].Cells[e.ColumnIndex];

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

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            SortDgvRegisLiveBySealCode(true);
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            SortDgvRegisLiveBySealCode(false);
        }

        private sealed class SealCodeParts
        {
            public string Prefix;
            public int Number;
            public SealCodeParts(string prefix, int number)
            {
                Prefix = prefix;
                Number = number;
            }
        }

        private static readonly Regex _sealRegex = new Regex(
            @"^\s*([^\d]+?)?\s*[-_ ]*\s*(\d+)\s*$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant
        );

        // "A-120" => Prefix="A", Number=120; if no number, Number=int.MinValue to keep order predictable
        private static SealCodeParts ParseSealCode(string seal)
        {
            if (string.IsNullOrEmpty(seal))
                return new SealCodeParts(string.Empty, int.MinValue);

            Match m = _sealRegex.Match(seal);
            if (m.Success)
            {
                string prefix = (m.Groups[1].Value ?? string.Empty).Trim();
                int number = 0;
                if (!int.TryParse(m.Groups[2].Value, out number))
                    number = int.MinValue;

                return new SealCodeParts(prefix, number);
            }

            return new SealCodeParts(seal.Trim(), int.MinValue);
        }

        private sealed class SealCodeComparer : IComparer<string>
        {
            private readonly int _direction; // 1 = Asc, -1 = Desc
            public SealCodeComparer(bool ascending)
            {
                _direction = ascending ? 1 : -1;
            }

            public int Compare(string a, string b)
            {
                if (a == null) a = string.Empty;
                if (b == null) b = string.Empty;

                SealCodeParts pa = ParseSealCode(a);
                SealCodeParts pb = ParseSealCode(b);

                int c = string.Compare(pa.Prefix, pb.Prefix, StringComparison.OrdinalIgnoreCase);
                if (c != 0) return _direction * c;

                c = pa.Number.CompareTo(pb.Number);
                if (c != 0) return _direction * c;

                return _direction * string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void SortDgvRegisLiveBySealCode(bool ascending)
        {
            string sealColName = "Seal"; // <-- your Seal column name
            int sealColIndex = dgvRegisLive.Columns[sealColName].Index;

            // ignore the new row if AllowUserToAddRows is true
            int last = dgvRegisLive.AllowUserToAddRows ? dgvRegisLive.Rows.Count - 2
                                                       : dgvRegisLive.Rows.Count - 1;
            if (last <= 0) return;

            SealCodeComparer cmp = new SealCodeComparer(ascending);

            dgvRegisLive.SuspendLayout();

            try
            {
                // Bubble sort logic, swapping only Seal column values
                for (int i = 0; i <= last; i++)
                {
                    bool swapped = false;
                    for (int j = 0; j <= last - 1 - i; j++)
                    {
                        DataGridViewRow r1 = dgvRegisLive.Rows[j];
                        DataGridViewRow r2 = dgvRegisLive.Rows[j + 1];

                        string k1 = Convert.ToString(r1.Cells[sealColIndex].Value ?? string.Empty);
                        string k2 = Convert.ToString(r2.Cells[sealColIndex].Value ?? string.Empty);

                        if (cmp.Compare(k1, k2) > 0)
                        {
                            // Swap only Seal column values
                            object tmp = r1.Cells[sealColIndex].Value;
                            r1.Cells[sealColIndex].Value = r2.Cells[sealColIndex].Value;
                            r2.Cells[sealColIndex].Value = tmp;

                            swapped = true;
                        }
                    }
                    if (!swapped) break; // already sorted
                }
            }
            finally
            {
                dgvRegisLive.ResumeLayout();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //SafeWriteToSerial("*1#");
        }

        private void EnsureOpen()
        {
            lock (_serialLock)
            {
                if (SPRegis == null) return;
                if (!SPRegis.IsOpen)
                {
                    try
                    {
                        SPRegis.Open();
                        SPRegis.DtrEnable = true;
                        SPRegis.RtsEnable = false;
                        SPRegis.Handshake = Handshake.None;
                    }
                    catch (Exception ex)
                    {
                        // handle or log; e.g. show message and retry later
                    }
                }
            }
        }

        private void ResetArduino()
        {
            lock (_serialLock)
            {
                if (SPRegis.IsOpen)
                {
                    SPRegis.DtrEnable = false;
                    Thread.Sleep(100);           // 100 ms reset pulse
                    SPRegis.DtrEnable = true;
                }
            }
        }

        private void btnRecreatePort_Click(object sender, EventArgs e)
        {
            _parent.btnReconnect.PerformClick();
            ForceRecreatePort();
        }

        private void ForceRecreatePort()
        {
            try
            {
                // snapshot settings
                var name = SPRegis?.PortName ?? "COM1";
                var baud = SPRegis?.BaudRate ?? 9600;
                var parity = SPRegis?.Parity ?? Parity.None;
                var databits = SPRegis?.DataBits ?? 8;
                var stopbits = SPRegis?.StopBits ?? StopBits.One;
                var newline = SPRegis?.NewLine ?? "\r\n";
                var readTo = SPRegis?.ReadTimeout ?? 500;
                var writeTo = SPRegis?.WriteTimeout ?? 500;
                var dtr = SPRegis?.DtrEnable ?? true;
                var rts = SPRegis?.RtsEnable ?? false;
                var hs = SPRegis?.Handshake ?? Handshake.None;

                // clean old
                try
                {
                    if (_dataReceivedHandler != null && SPRegis != null)
                    {
                        SPRegis.DataReceived -= _dataReceivedHandler;
                        SPRegis.ErrorReceived -= SPRegis_ErrorReceived;
                        SPRegis.PinChanged -= SPRegis_PinChanged;
                    }
                }
                catch { }

                try { if (SPRegis?.IsOpen == true) SPRegis.Close(); } catch { }
                try { SPRegis?.Dispose(); } catch { }

                // build new
                var port = new SerialPort(name, baud, parity, databits, stopbits)
                {
                    Encoding = Encoding.ASCII,
                    NewLine = newline,
                    ReadTimeout = readTo,
                    WriteTimeout = writeTo,
                    DtrEnable = dtr,
                    RtsEnable = rts,
                    Handshake = hs
                };

                // plug back into your Session singleton
                Session.SetGlobalPort(port);

                // resubscribe
                if (_dataReceivedHandler == null) _dataReceivedHandler = SPRegis_DataReceived;
                port.DataReceived += _dataReceivedHandler;
                port.ErrorReceived += SPRegis_ErrorReceived;
                port.PinChanged += SPRegis_PinChanged;

                port.Open();
                UpdateUiForPortState(true);
                txtSerialLog.AppendText("Port fully recreated and reopened.\r\n");
            }
            catch (Exception ex)
            {
                UpdateUiForPortState(false);
                txtSerialLog.AppendText("ForceRecreatePort failed: " + ex.Message + "\r\n");
            }
        }

    }


}
