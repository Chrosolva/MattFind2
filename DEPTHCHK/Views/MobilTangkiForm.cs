using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DEPTHCHK.Data;
using DEPTHCHK.Models;
using ClosedXML.Excel;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.IO.Ports;

namespace DEPTHCHK.Views
{
    public partial class MobilTangkiForm : Form
    {
        private readonly depthchkDBContext _db = new depthchkDBContext();
        private TblMobilTangki currentMT = null;   // null = add new

        private readonly BindingList<TblDetailMT> _detailBuffer = new BindingList<TblDetailMT>();
        private readonly BindingSource _bsDetail = new BindingSource();

        private SerialPort _serialPort => Session.GlobalPort;
        private SerialPort _measPort { get { return Session.GlobalPort2; } }
        private SerialDataReceivedEventHandler _measHandler;
        private SerialDataReceivedEventHandler _dataReceivedHandler;
        private SerialPort _attachedRfidPort;
        private SerialPort _attachedMeasPort;

        public MobilTangkiForm()
        {
            InitializeComponent();

            SetupGridColumns(); // only if you didn’t add them in Designer
                                // Example: materialTabControl1 is your existing control
            TCMobilTangki.DrawMode = TabDrawMode.OwnerDrawFixed;
            TCMobilTangki.SizeMode = TabSizeMode.Fixed;
            TCMobilTangki.ItemSize = new Size(1, 1);      // virtually hides headers
            TCMobilTangki.Padding = new Point(0, 0);

            // (Optional) make sure it fills the main content area
            TCMobilTangki.Dock = DockStyle.Fill;

            // Optional: keep Alignment.Top (default). Since headers are hidden, alignment doesn't matter.
            this.Activated += (s, e) => InitSerialUi();
            Session.GlobalPortChanged += OnGlobalPortChanged;
            Session.GlobalPort2Changed += OnGlobalPort2Changed;
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

            EnsureRfidSubscription();
            EnsureMeasSubscription();
            UpdateUiForPortState(_serialPort?.IsOpen == true || _measPort?.IsOpen == true);

            //if (_serialPort.IsOpen)
            //{
            //    UpdateUiForPortState(true);
            //}
            //else
            //{
            //    UpdateUiForPortState(false);
            //}

            //if (_measPort != null && _measHandler == null)
            //{
            //    _measHandler = new SerialDataReceivedEventHandler(MeasPort_DataReceived);
            //    _measPort.DataReceived += _measHandler;
            //}
        }

        private void EnsureRfidSubscription()
        {
            var port = _serialPort;

            if (_attachedRfidPort != port)
            {
                if (_attachedRfidPort != null && _dataReceivedHandler != null)
                {
                    try
                    {
                        _attachedRfidPort.DataReceived -= _dataReceivedHandler;
                        _attachedRfidPort.ErrorReceived -= _serialPort_ErrorReceived;
                        _attachedRfidPort.PinChanged -= _serialPort_PinChanged;
                    }
                    catch { }
                }

                _attachedRfidPort = port;

                if (_attachedRfidPort != null)
                {
                    if (_dataReceivedHandler == null)
                    {
                        _dataReceivedHandler = _serialPort_DataReceived;
                    }

                    _attachedRfidPort.DataReceived += _dataReceivedHandler;
                    _attachedRfidPort.ErrorReceived += _serialPort_ErrorReceived;
                    _attachedRfidPort.PinChanged += _serialPort_PinChanged;
                }
            }
        }

        private void EnsureMeasSubscription()
        {
            var port = _measPort;

            if (_attachedMeasPort != port)
            {
                if (_attachedMeasPort != null && _measHandler != null)
                {
                    try
                    {
                        _attachedMeasPort.DataReceived -= _measHandler;
                    }
                    catch { }
                }

                _attachedMeasPort = port;

                if (_attachedMeasPort != null)
                {
                    if (_measHandler == null)
                    {
                        _measHandler = new SerialDataReceivedEventHandler(MeasPort_DataReceived);
                    }

                    _attachedMeasPort.DataReceived += _measHandler;
                }
            }
        }

        private void OnGlobalPortChanged(SerialPort newPort)
        {
            BeginInvoke(new MethodInvoker(InitSerialUi));
        }

        private void OnGlobalPort2Changed(SerialPort newPort)
        {
            BeginInvoke(new MethodInvoker(InitSerialUi));
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
                }
            }
            catch
            {
                // ignore timeouts or errors
            }
        }

        private void OnMeasurementReceived(int value)
        {
            txtSerialLog.AppendText("Measurement VALUE = " + value.ToString("N0") + Environment.NewLine);
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

            //lblPortStatus.Text = connected
            //    ? "Connected: " + _serialPort.PortName + " @ " + _serialPort.BaudRate
            //    : "Disconnected";
            

            List<string> parts = new List<string>();
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                {
                    parts.Add("RFID " + _serialPort.PortName);
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
            lblPortStatus.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
            lblPortStatus.Text = string.Join(" | ", parts.ToArray());
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;

            try
            {
                // Loop while there are at least 8 bytes waiting (one full frame)
                while (sp.IsOpen && sp.BytesToRead >= 8)
                {
                    byte[] frame = new byte[8];
                    int read = sp.Read(frame, 0, 8);
                    if (read == 8)
                    {
                        // Process the frame on the UI thread
                        BeginInvoke(new Action(() => ProcessRfidFrame(frame)));
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

        private void ProcessRfidFrame(byte[] frame)        {
            // check header
            bool okHeader = frame[0] == 0x07 && frame[1] == 0x00 &&
                            frame[2] == 0xEE && frame[3] == 0x00;

            if (okHeader)
            {
                string rfid = frame[4].ToString("X2") + frame[5].ToString("X2");
                txtRfidData.Text = rfid;
            }
            else
            {
                // discard the remaining bytes so the next read starts fresh
                try { _serialPort.DiscardInBuffer(); }
                catch (Exception ex)
                {
                    // handle exception if port is closed or in error state
                }
            }

            txtSerialLog.AppendText(BitConverter.ToString(frame) + Environment.NewLine);
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

        private void SetupGridColumns()
        {
            dgvDetailMTBuffer.AutoGenerateColumns = false;
            dgvDetailMTBuffer.Columns.Clear();

            dgvDetailMTBuffer.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "PartID",
                DataPropertyName = nameof(TblDetailMT.PartID),      // "PartID"
                ReadOnly = true,
                Width = 180
            });
            dgvDetailMTBuffer.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Kalibrasi",
                DataPropertyName = nameof(TblDetailMT.Kalibrasi),     // "Kalibrasi"
                DefaultCellStyle = { Format = "N0" }
            });
            dgvDetailMTBuffer.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Positive",
                DataPropertyName = nameof(TblDetailMT.Positive)       // "Positive" (bool?)
            });
        }


        private void MobilTangkiForm_Load(object sender, EventArgs e)
        {
            btnDelete.Font = btnEdit.Font;
            DataGridViewHelper.ApplyDefaultStyle(dgvMobilTangki);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailMT);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailMTBuffer, false);
            InitSerialUi();
            dgvMobilTangki.SelectionChanged += DgvMobilTangki_SelectionChanged;
            LoadMobilTangki();
            MaterialTabHelper.ApplyStyle(TabSelector, TCMobilTangki);
            txtSerialLog.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
            txtSerialLog.BackColor = Color.FromArgb(12, 32, 30);
        }

        private void StyleTextBoxDisabled(MaterialSkin.Controls.MaterialTextBox2 txt)
        {
            txt.EnabledChanged += delegate
            {
                if (!txt.Enabled)
                {
                    txt.BackColor = Color.FromArgb(45, 45, 45);   // lighter gray for dark theme
                    txt.ForeColor = Color.WhiteSmoke;            // light text
                }
                else
                {
                    txt.BackColor = Color.FromArgb(30, 30, 30);  // normal dark color
                    txt.ForeColor = Color.White;
                }
            };
        }


        private void LoadMobilTangki()
        {
            var data = _db.MobilTangkis
                          .OrderBy(m => m.NoPlat)
                          .Select(m => new
                          {
                              m.NoPlat,
                              m.Type,
                              m.RfidData,
                              m.JlhCompartment,
                              m.Capacity
                          })
                          .ToList();

            dgvMobilTangki.DataSource = data;

            if (dgvMobilTangki.Rows.Count > 0)
                dgvMobilTangki.Rows[0].Selected = true; // trigger detail load
        }

        private void DgvMobilTangki_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMobilTangki.CurrentRow == null) return;

            var noPlat = dgvMobilTangki.CurrentRow.Cells["NoPlat"]?.Value?.ToString();
            if (string.IsNullOrWhiteSpace(noPlat)) return;

            LoadDetailMT(noPlat);
        }

        public void LoadDetailMT(string noPlat)
        {
            var details = _db.DetailMTs
                             .Where(d => d.NoPlat == noPlat)
                             .OrderBy(d => d.PartID)
                             .Select(d => new
                             {
                                 d.PartID,
                                 d.NoPlat,
                                 d.Kalibrasi,
                                 d.Positive
                             })
                             .ToList();

            if (details.Any())
            {
                dgvDetailMT.DataSource = details;
                dgvDetailMT.ClearSelection();
                dgvDetailMT.Rows[0].Selected = true; // optional: pre-select first row
            }
            else
            {
                // When there are no users, bind to an empty list so DataGridView clears itself
                dgvDetailMT.DataSource = new List<object>();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db.Dispose();
            base.OnFormClosed(e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMobilTangki.CurrentRow == null) return;

            string noPlat = dgvMobilTangki.CurrentRow.Cells["NoPlat"].Value.ToString();
            currentMT = _db.MobilTangkis.FirstOrDefault(mt => mt.NoPlat == noPlat);
            if (currentMT != null)
            {
                // Always clear previous entries
                _detailBuffer.Clear();

                txtNoPlat.Text = currentMT.NoPlat;
                txtNoPlat.ReadOnly = true;
                txtRfidData.Text = currentMT.RfidData ?? string.Empty;
                txtType.Text = currentMT.Type;
                NUDJlhCompartment.Value = currentMT.JlhCompartment ?? 0;
                NUDCapacity.Value = currentMT.Capacity ?? 0;

                var details = _db.DetailMTs
                                 .Where(d => d.NoPlat == noPlat)
                                 .OrderBy(d => d.PartID)
                                 .ToList();

                foreach (var det in details)
                {
                    _detailBuffer.Add(new TblDetailMT
                    {
                        PartID = det.PartID,
                        NoPlat = det.NoPlat,
                        Kalibrasi = det.Kalibrasi,
                        Positive = det.Positive
                    });
                }

                // Refresh the grid’s data source
                dgvDetailMTBuffer.DataSource = null;
                dgvDetailMTBuffer.DataSource = _detailBuffer;

                TCMobilTangki.SelectedTab = TPAddEditMT;

                StyleTextBoxDisabled(txtNoPlat);
                StyleTextBoxDisabled(txtRfidData);
            }
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            currentMT = null;
            ClearForm();
            txtNoPlat.Enabled = true;
            TCMobilTangki.SelectedTab = TPAddEditMT;
        }

        private void ClearForm()
        {
            txtNoPlat.Text = "";
            txtType.Text = "";
            NUDJlhCompartment.Value = 0;
            NUDCapacity.Value = 0;
            txtRfidData.Text = "";
            currentMT = null;
            txtNoPlat.ReadOnly = false;
            // Keep the DataSource intact; just clear the list
            _detailBuffer.Clear();
            _bsDetail.ResetBindings(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClearForm();
            TCMobilTangki.SelectedTab = TPMobilTangki;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Import DEPTHCHK Excel";
            ofd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            int mtInserted = 0, mtUpdated = 0, mtSkipped = 0;
            int dtInserted = 0, dtUpdated = 0, dtSkipped = 0;

            try
            {
                using (var wb = new XLWorkbook(ofd.FileName))
                {
                    using (var tx = _db.Database.BeginTransaction())
                    {
                        // -------- SHEET 1: TblMobilTangki --------
                        var ws1 = wb.Worksheet(1); // "Sheet1"
                        var lastRowUsed1 = ws1.LastRowUsed();
                        int lastRow1 = (lastRowUsed1 != null) ? lastRowUsed1.RowNumber() : 1;

                        for (int r = 2; r <= lastRow1; r++)
                        {
                            string noPlat = ws1.Cell(r, 1).GetString().Trim();
                            if (string.IsNullOrWhiteSpace(noPlat))
                            {
                                mtSkipped++;
                                continue;
                            }

                            string type = ws1.Cell(r, 2).GetString().Trim();
                            int? jlhCompartment = GetInt(ws1.Cell(r, 3));
                            int? capacity = GetInt(ws1.Cell(r, 4));
                            string RfidData = ws1.Cell(r, 5).GetString().Trim();

                            var mt = _db.MobilTangkis.SingleOrDefault(x => x.NoPlat == noPlat);
                            if (mt == null)
                            {
                                mt = new TblMobilTangki();
                                mt.NoPlat = noPlat;
                                mt.Type = type;
                                mt.JlhCompartment = jlhCompartment;
                                mt.Capacity = capacity;
                                mt.RfidData = RfidData;
                                _db.MobilTangkis.Add(mt);
                                mtInserted++;
                            }
                            else
                            {
                                mt.Type = type;
                                mt.JlhCompartment = jlhCompartment;
                                mt.Capacity = capacity;
                                mt.RfidData = RfidData;
                                mtUpdated++;
                            }
                        }

                        _db.SaveChanges();

                        // for validating NoPlat on detail rows (includes newly added)
                        var mobilMap = _db.MobilTangkis.AsNoTracking().ToList()
                                          .ToDictionary(
                                              x => x.NoPlat,
                                              StringComparer.OrdinalIgnoreCase);

                        // -------- SHEET 2: TblDetailMT --------
                        var ws2 = wb.Worksheet(2); // "Sheet2"
                        var lastRowUsed2 = ws2.LastRowUsed();
                        int lastRow2 = (lastRowUsed2 != null) ? lastRowUsed2.RowNumber() : 1;

                        for (int r = 2; r <= lastRow2; r++)
                        {
                            string partId = ws2.Cell(r, 1).GetString().Trim();
                            if (string.IsNullOrWhiteSpace(partId))
                            {
                                dtSkipped++;
                                continue;
                            }

                            string noPlat = ws2.Cell(r, 2).GetString().Trim();
                            if (string.IsNullOrWhiteSpace(noPlat))
                            {
                                dtSkipped++;
                                continue;
                            }
                            if (!mobilMap.ContainsKey(noPlat))
                            {
                                dtSkipped++;
                                continue;
                            }

                            int? kalibrasi = GetInt(ws2.Cell(r, 3));  // third column
                            bool? positive = GetBool(ws2.Cell(r, 4)); // fourth column


                            var dt = _db.DetailMTs.SingleOrDefault(x => x.PartID == partId);
                            if (dt == null)
                            {
                                dt = new TblDetailMT();
                                dt.PartID = partId;
                                dt.NoPlat = noPlat;
                                dt.Kalibrasi = kalibrasi.HasValue ? kalibrasi.Value : 0;
                                dt.Positive = positive.HasValue ? positive.Value : false;
                                _db.DetailMTs.Add(dt);
                                dtInserted++;
                            }
                            else
                            {
                                dt.NoPlat = noPlat;
                                dt.Kalibrasi = kalibrasi.HasValue ? kalibrasi.Value : 0;
                                dt.Positive = positive.HasValue ? positive.Value : false;
                                dtUpdated++;
                            }
                        }

                        _db.SaveChanges();
                        tx.Commit();
                    }
                }

                LoadMobilTangki(); // refresh list grid

                MessageBox.Show(
                    "Import selesai.\r\n\r\n" +
                    "MobilTangki: +" + mtInserted + ", ~" + mtUpdated + ", skipped " + mtSkipped + "\r\n" +
                    "DetailMT:    +" + dtInserted + ", ~" + dtUpdated + ", skipped " + dtSkipped,
                    "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import gagal: " + ex.Message, "Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int? GetInt(IXLCell c)
        {
            if (c.IsEmpty()) return null;
            if (c.DataType == XLDataType.Number) return (int)c.GetDouble();
            string s = c.GetString().Trim();
            int v;
            if (int.TryParse(s, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out v)) return v;
            if (int.TryParse(s, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.CurrentCulture, out v)) return v;
            return null;
        }

        private static decimal? GetDecimal(IXLCell c)
        {
            if (c.IsEmpty()) return null;
            if (c.DataType == XLDataType.Number) return Convert.ToDecimal(c.GetDouble());
            string s = c.GetString().Trim();
            decimal v;
            if (decimal.TryParse(s, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out v)) return v;
            if (decimal.TryParse(s, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out v)) return v;
            return null;
        }

        private static bool? GetBool(IXLCell c)
        {
            if (c.IsEmpty()) return null;
            if (c.DataType == XLDataType.Boolean) return c.GetBoolean();
            string s = c.GetString().Trim().ToLowerInvariant();
            if (s == "1" || s == "true" || s == "yes" || s == "y") return true;
            if (s == "0" || s == "false" || s == "no" || s == "n") return false;
            return null;
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
                SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export DEPTHCHK Excel";
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "DEPTHCHK_Export_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                var mobil = _db.MobilTangkis.AsNoTracking()
                               .OrderBy(m => m.NoPlat)
                               .Select(m => new
                               {
                                   m.NoPlat,
                                   m.Type,
                                   m.JlhCompartment,
                                   m.Capacity,
                                   m.RfidData
                               })
                               .ToList();

                var detail = _db.DetailMTs.AsNoTracking()
                               .OrderBy(d => d.NoPlat).ThenBy(d => d.PartID)
                               .Select(d => new
                               {
                                   d.PartID,
                                   d.NoPlat,
                                   d.Kalibrasi,
                                   d.Positive
                               })
                               .ToList();

                using (var wb = new XLWorkbook())
                {
                    // Sheet1
                    var ws1 = wb.Worksheets.Add("Sheet1");
                    ws1.Cell(1, 1).Value = "NoPlat";
                    ws1.Cell(1, 2).Value = "Type";
                    ws1.Cell(1, 3).Value = "JlhCompartment";
                    ws1.Cell(1, 4).Value = "Capacity";
                    ws1.Cell(1, 5).Value = "RfidData";

                    int r = 2;
                    foreach (var m in mobil)
                    {
                        ws1.Cell(r, 1).Value = m.NoPlat;
                        ws1.Cell(r, 2).Value = m.Type ?? "";
                        ws1.Cell(r, 3).Value = m.JlhCompartment.HasValue ? m.JlhCompartment.Value : 0;
                        ws1.Cell(r, 4).Value = m.Capacity.HasValue ? m.Capacity.Value : 0m;
                        ws1.Cell(r, 5).Value = m.RfidData ??  "";
                        r++;
                    }
                    if (ws1.RangeUsed() != null)
                    {
                        ws1.RangeUsed().SetAutoFilter();
                        ws1.Columns().AdjustToContents();
                    }

                    // Sheet2
                    var ws2 = wb.Worksheets.Add("Sheet2");
                    ws2.Cell(1, 1).Value = "PartID";
                    ws2.Cell(1, 2).Value = "NoPlat";
                    ws2.Cell(1, 3).Value = "Kalibrasi";
                    ws2.Cell(1, 4).Value = "Positive";

                    r = 2;
                    foreach (var d in detail)
                    {
                        ws2.Cell(r, 1).Value = d.PartID;
                        ws2.Cell(r, 2).Value = d.NoPlat;
                        ws2.Cell(r, 3).Value = d.Kalibrasi.HasValue ? d.Kalibrasi.Value : 0;
                        ws2.Cell(r, 4).Value = d.Positive.HasValue ? d.Positive.Value : false;
                        r++;
                    }
                    if (ws2.RangeUsed() != null)
                    {
                        ws2.RangeUsed().SetAutoFilter();
                        ws2.Columns().AdjustToContents();
                    }

                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Export selesai.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export gagal: " + ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var noPlat = txtNoPlat.Text.Trim();
            var jlh = (int)NUDJlhCompartment.Value;

            if (string.IsNullOrWhiteSpace(noPlat) || jlh <= 0)
            {
                MessageBox.Show("Isi NoPlat dan jumlah compartment (>0).");
                return;
            }

            _detailBuffer.Clear();

            for (int i = 1; i <= jlh; i++)
            {
                _detailBuffer.Add(new TblDetailMT
                {
                    PartID = $"{noPlat}_Compartment{i}",   // NoPlat_Compartment1,2,...
                    NoPlat = noPlat,
                    Kalibrasi = 0,                         // default 0
                    Positive = false                        // default 0/false
                });
            }

            _bsDetail.ResetBindings(false);    // refresh grid
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtNoPlat.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("NoPlat and Type are required.");
                return;
            }

            // Ensure detail records were generated (if any compartments are specified)
            if (_detailBuffer.Count == 0 && NUDJlhCompartment.Value > 0)
            {
                MessageBox.Show("Generate detail terlebih dahulu.");
                return;
            }

            // Normalize and prepare the RFID data
            string newRfid = (txtRfidData.Text ?? "").Trim().PadRight(4).Substring(0, 4);

            // When editing, capture the current primary key (NoPlat) in a simple string
            string currentNoPlat = currentMT?.NoPlat;

            // Check for duplicate RFID data in another MobilTangki
            bool duplicateRfid = _db.MobilTangkis.Any(mt =>
                mt.RfidData != null &&
                mt.RfidData.Equals(newRfid, StringComparison.OrdinalIgnoreCase) &&
                (currentNoPlat == null || mt.NoPlat != currentNoPlat));

            if (duplicateRfid)
            {
                MessageBox.Show(
                    "RFID data already exists in the database. Please scan a unique tag.",
                    "Duplicate RFID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (currentMT == null)
            {
                // ----- Create a new MobilTangki -----
                var mt = new TblMobilTangki
                {
                    NoPlat = txtNoPlat.Text.Trim(),
                    Type = txtType.Text.Trim(),
                    JlhCompartment = (int)NUDJlhCompartment.Value,
                    Capacity = NUDCapacity.Value,
                    RfidData = newRfid
                };

                // Copy detail records from the buffer into the new entity
                foreach (var d in _detailBuffer)
                {
                    mt.DetailMTs.Add(new TblDetailMT
                    {
                        PartID = d.PartID,
                        NoPlat = d.NoPlat,
                        Kalibrasi = d.Kalibrasi ?? 0,
                        Positive = d.Positive ?? false
                    });
                }

                _db.MobilTangkis.Add(mt);
            }
            else
            {
                // ----- Update an existing MobilTangki -----
                currentMT.Type = txtType.Text.Trim();
                currentMT.JlhCompartment = (int)NUDJlhCompartment.Value;
                currentMT.Capacity = NUDCapacity.Value;
                currentMT.RfidData = newRfid;

                // Map the detail buffer by PartID for quick lookup
                var bufferByPartId = _detailBuffer.ToDictionary(d => d.PartID, StringComparer.OrdinalIgnoreCase);

                // 1) Add or update detail records from the buffer
                foreach (var kv in bufferByPartId)
                {
                    string partId = kv.Key;
                    TblDetailMT bufferD = kv.Value;

                    // See if this PartID already exists on the current entity
                    var existing = currentMT.DetailMTs
                        .SingleOrDefault(x => x.PartID.Equals(partId, StringComparison.OrdinalIgnoreCase));

                    if (existing == null)
                    {
                        // Add a new detail
                        currentMT.DetailMTs.Add(new TblDetailMT
                        {
                            PartID = partId,
                            NoPlat = currentMT.NoPlat,
                            Kalibrasi = bufferD.Kalibrasi ?? 0,
                            Positive = bufferD.Positive ?? false
                        });
                    }
                    else
                    {
                        // Update existing detail
                        existing.Kalibrasi = bufferD.Kalibrasi ?? 0;
                        existing.Positive = bufferD.Positive ?? false;
                        existing.NoPlat = currentMT.NoPlat; // keep FK consistent
                    }
                }

                // 2) Remove any detail records that are no longer in the buffer
                var toDelete = currentMT.DetailMTs
                    .Where(dbRow => !bufferByPartId.ContainsKey(dbRow.PartID))
                    .ToList();

                foreach (var del in toDelete)
                {
                    // mark for deletion
                    _db.Entry(del).State = EntityState.Deleted;
                }
            }

            // Persist changes and refresh the UI
            _db.SaveChanges();
            LoadMobilTangki();
            ClearForm();
            currentMT = null;
            TCMobilTangki.SelectedTab = TPMobilTangki;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMobilTangki.CurrentRow == null)
            {
                MessageBox.Show("Pilih data Mobil Tangki terlebih dahulu.");
                return;
            }

            object cellVal = dgvMobilTangki.CurrentRow.Cells["NoPlat"].Value;
            string noPlat = (cellVal == null) ? null : cellVal.ToString();
            if (string.IsNullOrWhiteSpace(noPlat))
            {
                MessageBox.Show("NoPlat tidak valid.");
                return;
            }

            //// Optional: warn if there are related Pengiriman
            //int pengirimanCount = _db.Pengirimans.Count(p => p.NoPlat == noPlat);
            //string warn = (pengirimanCount > 0)
            //    ? "\r\n\r\nPERINGATAN: Ada " + pengirimanCount + " data pengiriman yang masih terkait. " +
            //      "Hapus atau putuskan keterkaitan dulu (set NoPlat = NULL) sebelum menghapus MobilTangki ini."
            //    : "";

            DialogResult ask = MessageBox.Show(
                "Hapus Mobil Tangki: " + noPlat + " ?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ask != DialogResult.Yes) return;

            //if (pengirimanCount > 0)
            //{
            //    MessageBox.Show("Tidak dapat menghapus karena masih terkait dengan data pengiriman (" + pengirimanCount + ").",
            //                    "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            try
            {
                using (var tx = _db.Database.BeginTransaction())
                {
                    // Load master + details
                    var mt = _db.MobilTangkis
                                .Include(m => m.DetailMTs)
                                .SingleOrDefault(m => m.NoPlat == noPlat);

                    if (mt == null)
                    {
                        MessageBox.Show("Data tidak ditemukan atau sudah dihapus.");
                        tx.Rollback();
                        return;
                    }

                    // Delete child details first (no cascade in mapping)
                    // (ToList to avoid modifying collection while enumerating)
                    foreach (var d in mt.DetailMTs.ToList())
                    {
                        _db.DetailMTs.Remove(d);
                    }

                    // Delete master
                    _db.MobilTangkis.Remove(mt);

                    _db.SaveChanges();
                    tx.Commit();
                }

                // UI refresh
                currentMT = null;
                _detailBuffer.Clear();              // if you show buffer grid
                LoadMobilTangki();                  // reload list
                dgvDetailMT.DataSource = new System.Collections.Generic.List<object>(); // clear detail view

                MessageBox.Show("Data berhasil dihapus.", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message, "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadMobilTangki();
        }

        public void PrepareToClose()
        {
            // unsubscribe events first
            //try
            //{
            //    if (_dataReceivedHandler != null && _serialPort != null)
            //    {
            //        _serialPort.DataReceived -= _dataReceivedHandler;
            //        _serialPort.ErrorReceived -= _serialPort_ErrorReceived;
            //        _serialPort.PinChanged -= _serialPort_PinChanged;
            //        _dataReceivedHandler = null;
            //    }
            //}
            //catch { /* ignore */ }

            try
            {
                // Port 1 (RFID)
                if (_dataReceivedHandler != null && _attachedRfidPort != null)
                {
                    try
                    {
                        //_serialPort.DataReceived -= _dataReceivedHandler;
                        //_serialPort.ErrorReceived -= _serialPort_ErrorReceived;
                        //_serialPort.PinChanged -= _serialPort_PinChanged;
                        //_dataReceivedHandler = null;

                        _attachedRfidPort.DataReceived -= _dataReceivedHandler;
                        _attachedRfidPort.ErrorReceived -= _serialPort_ErrorReceived;
                        _attachedRfidPort.PinChanged -= _serialPort_PinChanged;
                    }
                    catch { /* ignore */ }
                    _dataReceivedHandler = null;
                    _attachedRfidPort = null;
                }

                // Port 2 (Measurement)
                //if (_measHandler != null && _measPort != null)
                if (_measHandler != null && _attachedMeasPort != null)
                {
                    try
                    {
                        //_measPort.DataReceived -= _measHandler;
                        _attachedMeasPort.DataReceived -= _measHandler;
                    }
                    catch { /* ignore */ }
                    _measHandler = null;
                    _attachedMeasPort = null;
                }

                Session.GlobalPortChanged -= OnGlobalPortChanged;
                Session.GlobalPort2Changed -= OnGlobalPort2Changed;
            }
            catch
            {
                // swallow top-level exceptions to avoid crash during form close
            }
        }

        private void btnClearrfid_Click(object sender, EventArgs e)
        {
            txtRfidData.Text = "";
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            SendAckGet();
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
                _measPort.Write("?");
                txtSerialLog.AppendText("GET DATA." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send ACK: " + ex.Message);
            }
        }
    }
}
