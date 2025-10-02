using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

namespace DEPTHCHK.Views
{
    public partial class MobilTangkiForm : Form
    {
        private readonly depthchkDBContext _db = new depthchkDBContext();
        private TblMobilTangki currentMT = null;   // null = add new

        private readonly BindingList<TblDetailMT> _detailBuffer = new BindingList<TblDetailMT>();
        private readonly BindingSource _bsDetail = new BindingSource();

        public MobilTangkiForm()
        {
            InitializeComponent();
            dgvMobilTangki.AutoGenerateColumns = true;
            dgvDetailMT.AutoGenerateColumns = true;

            // Bind grid
            _bsDetail.DataSource = _detailBuffer;
            // Simple binding first. (We can add custom columns later.)
            dgvDetailMTBuffer.AutoGenerateColumns = true;   // turn on to verify binding
            dgvDetailMTBuffer.DataSource = _detailBuffer;

            SetupGridColumns(); // only if you didn’t add them in Designer
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
                HeaderText = "CompartmentID",
                DataPropertyName = nameof(TblDetailMT.CompartmentID) // "CompartmentID"
            });
            dgvDetailMTBuffer.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Kalibrasi",
                DataPropertyName = nameof(TblDetailMT.Kalibrasi),     // "Kalibrasi"
                DefaultCellStyle = { Format = "N2" }
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
            dgvMobilTangki.SelectionChanged += DgvMobilTangki_SelectionChanged;
            LoadMobilTangki();
            
        }

        private void LoadMobilTangki()
        {
            var data = _db.MobilTangkis
                          .OrderBy(m => m.NoPlat)
                          .Select(m => new
                          {
                              m.NoPlat,
                              m.Type,
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
                                 d.CompartmentID,
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
                txtNoPlat.Text = currentMT.NoPlat;
                txtNoPlat.Enabled = false; // primary key shouldn't be changed
                txtType.Text = currentMT.Type;
                NUDJlhCompartment.Value = currentMT.JlhCompartment ?? 0;
                NUDCapacity.Value = currentMT.Capacity ?? 0;

                // method to load detailMT to buffer. 

                var details = _db.DetailMTs
                             .Where(d => d.NoPlat == noPlat)
                             .OrderBy(d => d.PartID)
                             .Select(d => new
                             {
                                 d.PartID,
                                 d.NoPlat,
                                 d.CompartmentID,
                                 d.Kalibrasi,
                                 d.Positive
                             })
                             .ToList();

                if (details.Any())
                {
                    for (int i = 0; i < details.Count; i++)
                    {
                        _detailBuffer.Add(new TblDetailMT
                        {
                            PartID = details[i].PartID,   // NoPlat_Compartment1,2,...
                            NoPlat = details[i].NoPlat,
                            CompartmentID = details[i].CompartmentID,                   // leave blank
                            Kalibrasi = details[i].Kalibrasi,                         // default 0
                            Positive = details[i].Positive                        // default 0/false
                        });
                    }
                }
                else
                {
                    // When there are no users, bind to an empty list so DataGridView clears itself
                    dgvDetailMT.DataSource = new List<object>();
                }

                // switch to Create/Edit tab
                TCMobilTangki.SelectedTab = TPAddEditMT;
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
            currentMT = null;
            txtNoPlat.Enabled = true;
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
                            decimal? capacity = GetDecimal(ws1.Cell(r, 4));

                            var mt = _db.MobilTangkis.SingleOrDefault(x => x.NoPlat == noPlat);
                            if (mt == null)
                            {
                                mt = new TblMobilTangki();
                                mt.NoPlat = noPlat;
                                mt.Type = type;
                                mt.JlhCompartment = jlhCompartment;
                                mt.Capacity = capacity;
                                _db.MobilTangkis.Add(mt);
                                mtInserted++;
                            }
                            else
                            {
                                mt.Type = type;
                                mt.JlhCompartment = jlhCompartment;
                                mt.Capacity = capacity;
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

                            string compartmentId = ws2.Cell(r, 3).GetString().Trim();
                            decimal? kalibrasi = GetDecimal(ws2.Cell(r, 4));
                            bool? positive = GetBool(ws2.Cell(r, 5));

                            var dt = _db.DetailMTs.SingleOrDefault(x => x.PartID == partId);
                            if (dt == null)
                            {
                                dt = new TblDetailMT();
                                dt.PartID = partId;
                                dt.NoPlat = noPlat;
                                dt.CompartmentID = string.IsNullOrWhiteSpace(compartmentId) ? null : compartmentId;
                                dt.Kalibrasi = kalibrasi.HasValue ? kalibrasi.Value : 0m;
                                dt.Positive = positive.HasValue ? positive.Value : false;
                                _db.DetailMTs.Add(dt);
                                dtInserted++;
                            }
                            else
                            {
                                dt.NoPlat = noPlat;
                                dt.CompartmentID = string.IsNullOrWhiteSpace(compartmentId) ? null : compartmentId;
                                dt.Kalibrasi = kalibrasi.HasValue ? kalibrasi.Value : 0m;
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
                                   m.Capacity
                               })
                               .ToList();

                var detail = _db.DetailMTs.AsNoTracking()
                               .OrderBy(d => d.NoPlat).ThenBy(d => d.PartID)
                               .Select(d => new
                               {
                                   d.PartID,
                                   d.NoPlat,
                                   d.CompartmentID,
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

                    int r = 2;
                    foreach (var m in mobil)
                    {
                        ws1.Cell(r, 1).Value = m.NoPlat;
                        ws1.Cell(r, 2).Value = m.Type ?? "";
                        ws1.Cell(r, 3).Value = m.JlhCompartment.HasValue ? m.JlhCompartment.Value : 0;
                        ws1.Cell(r, 4).Value = m.Capacity.HasValue ? m.Capacity.Value : 0m;
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
                    ws2.Cell(1, 3).Value = "CompartmentID";
                    ws2.Cell(1, 4).Value = "Kalibrasi";
                    ws2.Cell(1, 5).Value = "Positive";

                    r = 2;
                    foreach (var d in detail)
                    {
                        ws2.Cell(r, 1).Value = d.PartID;
                        ws2.Cell(r, 2).Value = d.NoPlat;
                        ws2.Cell(r, 3).Value = d.CompartmentID ?? "";
                        ws2.Cell(r, 4).Value = d.Kalibrasi.HasValue ? d.Kalibrasi.Value : 0m;
                        ws2.Cell(r, 5).Value = d.Positive.HasValue ? d.Positive.Value : false;
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
                    CompartmentID = null,                   // leave blank
                    Kalibrasi = 0m,                         // default 0
                    Positive = false                        // default 0/false
                });
            }

            _bsDetail.ResetBindings(false);    // refresh grid
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(txtNoPlat.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("NoPlat and Type are required.");
                return;
            }

            if (_detailBuffer.Count == 0 && NUDJlhCompartment.Value > 0)
            {
                MessageBox.Show("Generate detail terlebih dahulu.");
                return;
            }

            if (currentMT == null)
            {
                // Create new MobilTangki
                var mt = new TblMobilTangki
                {
                    NoPlat = txtNoPlat.Text.Trim(),
                    Type = txtType.Text.Trim(),
                    JlhCompartment = (int)NUDJlhCompartment.Value,
                    Capacity = NUDCapacity.Value
                };

                // Attach buffered details (clone to avoid EF tracking BindingList instance)
                foreach (var d in _detailBuffer)
                {
                    mt.DetailMTs.Add(new TblDetailMT
                    {
                        PartID = d.PartID,
                        NoPlat = d.NoPlat,
                        CompartmentID = d.CompartmentID,
                        Kalibrasi = d.Kalibrasi ?? 0m,
                        Positive = d.Positive ?? false
                    });
                }
                _db.MobilTangkis.Add(mt);

            }
            else
            {
                // Update existing
                currentMT.Type = txtType.Text.Trim();
                currentMT.JlhCompartment = (int)NUDJlhCompartment.Value;
                currentMT.Capacity = NUDCapacity.Value;

                // Map buffer by PartID for quick lookups
                var bufferByPartId = _detailBuffer
                    .ToDictionary(d => d.PartID, StringComparer.OrdinalIgnoreCase);

                // 1) ADD or UPDATE each buffered detail
                foreach (var kv in bufferByPartId)
                {
                    var partId = kv.Key;
                    var b = kv.Value;

                    // Try find existing detail by PartID
                    var existing = currentMT.DetailMTs.SingleOrDefault(x => x.PartID == partId);

                    if (existing == null)
                    {
                        // ADD
                        currentMT.DetailMTs.Add(new TblDetailMT
                        {
                            PartID = partId,
                            NoPlat = currentMT.NoPlat, // ensure FK is set
                            CompartmentID = string.IsNullOrWhiteSpace(b.CompartmentID) ? null : b.CompartmentID,
                            Kalibrasi = b.Kalibrasi ?? 0m,
                            Positive = b.Positive ?? false
                        });
                    }
                    else
                    {
                        // UPDATE
                        existing.CompartmentID = string.IsNullOrWhiteSpace(b.CompartmentID) ? null : b.CompartmentID;
                        existing.Kalibrasi = b.Kalibrasi ?? 0m;
                        existing.Positive = b.Positive ?? false;
                        existing.NoPlat = currentMT.NoPlat; // keep FK consistent
                    }
                }

                // 2) DELETE details in DB that are not in the buffer anymore
                var toDelete = currentMT.DetailMTs
                                 .Where(dbRow => !bufferByPartId.ContainsKey(dbRow.PartID))
                                 .ToList();
                foreach (var del in toDelete)
                {
                    _db.Entry(del).State = EntityState.Deleted;
                }
            }

            _db.SaveChanges();
            LoadMobilTangki();                      // refresh grid
            ClearForm();
            currentMT = null;
            TCMobilTangki.SelectedTab = TPMobilTangki;   // back to list
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
    }
}
