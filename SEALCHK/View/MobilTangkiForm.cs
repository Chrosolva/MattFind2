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
using SEALCHK.Data;
using SEALCHK.Model;
using ClosedXML.Excel;


namespace SEALCHK.View
{
    public partial class MobilTangkiForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        private TblMobilTangki currentMT = null;   // null = add new

        public MobilTangkiForm()
        {
            InitializeComponent();
            dgvMobilTangki.AutoGenerateColumns = true;
            dgvDetailMT.AutoGenerateColumns = true;
        }

        private void MobilTangkiForm_Load(object sender, EventArgs e)
        {
            btnDelete.Font = btnEdit.Font;
            DataGridViewHelper.ApplyDefaultStyle(dgvMobilTangki);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailMT);
            LoadMobilTangki();
            dgvMobilTangki.SelectionChanged += DgvMobilTangki_SelectionChanged;
        }

        private void LoadMobilTangki()
        {
            var data = _db.MobilTangki
                          .OrderBy(m => m.NoPlat)
                          .Select(m => new
                          {
                              m.NoPlat,
                              m.Type,
                              m.JlhCompartment,
                              m.CoverBoxPanel,
                              m.DetailStatus
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

            var details = _db.DetailMT
                             .Where(d => d.NoPlat == noPlat)
                             .OrderBy(d => d.PartIndex)
                             .Select(d => new
                             {
                                 d.PartID,
                                 d.NoPlat,
                                 d.SealCode,
                                 d.Status,
                                 d.Capacity,
                                 d.PartIndex
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
            currentMT = _db.MobilTangki.FirstOrDefault(mt => mt.NoPlat == noPlat);
            if (currentMT != null)
            {
                txtNoPlat.Text = currentMT.NoPlat;
                txtNoPlat.Enabled = false; // primary key shouldn't be changed
                txtType.Text = currentMT.Type;
                NUDJlhCompartment.Value = currentMT.JlhCompartment ?? 0;
                NUDPanelCover.Value = currentMT.CoverBoxPanel ?? 0;

                // switch to Create/Edit tab
                TCMobilTangki.SelectedTab = TPAddEditMT;
            }
        }

        private void TabSelector_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            currentMT = null;
            ClearForm();
            txtNoPlat.Enabled = true;
            TCMobilTangki.SelectedTab = TPAddEditMT;
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

            if (currentMT == null)
            {
                // Create new MobilTangki
                var mt = new TblMobilTangki
                {
                    NoPlat = txtNoPlat.Text.Trim(),
                    Type = txtType.Text.Trim(),
                    JlhCompartment = (int)NUDJlhCompartment.Value,
                    CoverBoxPanel = (int)NUDPanelCover.Value,
                    DetailStatus = "-" // default
                };
                _db.MobilTangki.Add(mt);
            }
            else
            {
                // Update existing
                currentMT.Type = txtType.Text.Trim();
                currentMT.JlhCompartment = (int)NUDJlhCompartment.Value;
                currentMT.CoverBoxPanel = (int)NUDPanelCover.Value;
                // leave DetailStatus as is, or update if you add an input for it
            }

            _db.SaveChanges();
            LoadMobilTangki();                      // refresh grid
            ClearForm();
            currentMT = null;
            TCMobilTangki.SelectedTab = TPMobilTangki;   // back to list
        }

        private void ClearForm()
        {
            txtNoPlat.Text = "";
            txtType.Text = "";
            NUDJlhCompartment.Value = 0;
            NUDPanelCover.Value = 0;
            currentMT = null;
            txtNoPlat.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TCMobilTangki.SelectedTab = TPMobilTangki;
        }

        private void btnAutoDetail_Click(object sender, EventArgs e)
        {
            // Ask the user to confirm deletion
            var result = MessageBox.Show(
                $"Sebelum melanjut ke AutoGenerate , SUPERADMIN menyarankan untuk BACK_UP database terlebih dahulu. Apakah database sudah diBACK_UP ?",
                "Confirm AUTO GEN",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return; // user cancelled

            // create a new context for this operation
            using (var db = new SealCheckContext())
            {
                // find all MobilTangki rows where DetailStatus is "-" (not yet generated)
                var pending = db.MobilTangki
                                .Where(mt => mt.DetailStatus == "-")
                                .ToList();

                foreach (var mt in pending)
                {
                    // avoid duplicating detail rows for an existing plate
                    bool detailsExist = db.DetailMT.Any(d => d.NoPlat == mt.NoPlat);
                    if (!detailsExist)
                    {
                        int compartments = mt.JlhCompartment ?? 0;

                        // create "ManCom" rows
                        for (int i = 1; i <= compartments; i++)
                        {
                            db.DetailMT.Add(new TblDetailMT
                            {
                                PartID = $"{mt.NoPlat}_ManCom{i}",
                                NoPlat = mt.NoPlat,
                                SealCode = "-",
                                Status = "-",
                                Capacity = null,
                                PartIndex = i // continue ordering
                            });
                        }

                        // create "BotLoad" rows
                        for (int i = 1; i <= compartments; i++)
                        {
                            db.DetailMT.Add(new TblDetailMT
                            {
                                PartID = $"{mt.NoPlat}_BotLoad{i}",
                                NoPlat = mt.NoPlat,
                                SealCode = "-",       // default value
                                Status = "-",       // default value
                                Capacity = null,      // default value
                                PartIndex = compartments + i          // optional ordering
                            });
                        }

                        // optionally add a PCover row if CoverBoxPanel > 0
                        if (mt.CoverBoxPanel.HasValue && mt.CoverBoxPanel.Value > 0)
                        {
                            db.DetailMT.Add(new TblDetailMT
                            {
                                PartID = $"{mt.NoPlat}_PCover",
                                NoPlat = mt.NoPlat,
                                SealCode = "-",
                                Status = "-",
                                Capacity = null,
                                PartIndex = (compartments * 2) + 1
                            });
                        }
                    }

                    // mark this MobilTangki row as generated
                    mt.DetailStatus = "GENERATED";
                }

                db.SaveChanges();
            }

            // reload the grid to reflect the updated DetailStatus
            LoadMobilTangki();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx"
            })
            {
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook(openDlg.FileName))
                    {
                        var ws = workbook.Worksheet(1);
                        var rows = ws.RangeUsed().RowsUsed().Skip(1); // skip header

                        foreach (var row in rows)
                        {
                            string noPlat = row.Cell(1).GetString().Trim();
                            string type = row.Cell(2).GetString().Trim();
                            int jlhCompartment = (int)row.Cell(3).GetDouble();
                            int coverBoxPanel = (int)row.Cell(4).GetDouble();
                            string detailStatus = row.Cell(5).GetString().Trim();

                            // see if this plate already exists
                            var existing = _db.MobilTangki.Find(noPlat);
                            if (existing == null)
                            {
                                // create new record
                                var mt = new TblMobilTangki
                                {
                                    NoPlat = noPlat,
                                    Type = type,
                                    JlhCompartment = jlhCompartment,
                                    CoverBoxPanel = coverBoxPanel,
                                    DetailStatus = detailStatus == string.Empty ? "-" : detailStatus
                                };
                                _db.MobilTangki.Add(mt);
                            }
                            else
                            {
                                // update existing (optional)
                                existing.Type = type;
                                existing.JlhCompartment = jlhCompartment;
                                existing.CoverBoxPanel = coverBoxPanel;
                                existing.DetailStatus = detailStatus;
                            }
                        }

                        _db.SaveChanges();
                        MessageBox.Show("Import completed.");
                        LoadMobilTangki(); // refresh grid
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Let user choose where to save
            using (var saveDlg = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = "MobilTangkiAndDetail.xlsx"
            })
            {
                if (saveDlg.ShowDialog() != DialogResult.OK) return;

                using (var db = new SealCheckContext())
                using (var workbook = new XLWorkbook())
                {
                    // Sheet 1: MobilTangki
                    var wsMT = workbook.Worksheets.Add("MobilTangki");

                    // header row
                    wsMT.Cell(1, 1).Value = "NoPlat";
                    wsMT.Cell(1, 2).Value = "Type";
                    wsMT.Cell(1, 3).Value = "JlhCompartment";
                    wsMT.Cell(1, 4).Value = "CoverBoxPanel";
                    wsMT.Cell(1, 5).Value = "DetailStatus";

                    // data
                    var mobilTangkiList = db.MobilTangki.OrderBy(mt => mt.NoPlat).ToList();
                    int mtRow = 2;
                    foreach (var mt in mobilTangkiList)
                    {
                        wsMT.Cell(mtRow, 1).Value = mt.NoPlat;
                        wsMT.Cell(mtRow, 2).Value = mt.Type;
                        wsMT.Cell(mtRow, 3).Value = mt.JlhCompartment;
                        wsMT.Cell(mtRow, 4).Value = mt.CoverBoxPanel;
                        wsMT.Cell(mtRow, 5).Value = mt.DetailStatus;
                        mtRow++;
                    }

                    // optional: adjust column widths to fit contents
                    wsMT.Columns().AdjustToContents();

                    // Sheet 2: DetailMT
                    var wsDetail = workbook.Worksheets.Add("DetailMT");
                    wsDetail.Cell(1, 1).Value = "PartID";
                    wsDetail.Cell(1, 2).Value = "NoPlat";
                    wsDetail.Cell(1, 3).Value = "SealCode";
                    wsDetail.Cell(1, 4).Value = "Status";
                    wsDetail.Cell(1, 5).Value = "Capacity";
                    wsDetail.Cell(1, 6).Value = "PartIndex";

                    var detailList = db.DetailMT.OrderBy(d => d.NoPlat)
                                                .ThenBy(d => d.PartID)
                                                .ToList();

                    int dtRow = 2;
                    foreach (var d in detailList)
                    {
                        wsDetail.Cell(dtRow, 1).Value = d.PartID;
                        wsDetail.Cell(dtRow, 2).Value = d.NoPlat;
                        wsDetail.Cell(dtRow, 3).Value = d.SealCode;
                        wsDetail.Cell(dtRow, 4).Value = d.Status;
                        wsDetail.Cell(dtRow, 5).Value = d.Capacity;
                        wsDetail.Cell(dtRow, 6).Value = d.PartIndex;
                        dtRow++;
                    }
                    wsDetail.Columns().AdjustToContents();

                    // save workbook
                    workbook.SaveAs(saveDlg.FileName);
                    MessageBox.Show("Export completed successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure there is a selected row
            if (dgvMobilTangki.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string noPlat = dgvMobilTangki.CurrentRow.Cells["NoPlat"].Value.ToString();

            // Ask the user to confirm deletion
            var result = MessageBox.Show(
                $"Are you sure you want to delete Mobil Tangki {noPlat} and its details?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return; // user cancelled

            // Delete using Entity Framework
            using (var db = new SealCheckContext())
            {
                // Load the MobilTangki entity and its related details
                var mobil = db.MobilTangki.FirstOrDefault(mt => mt.NoPlat == noPlat);
                if (mobil != null)
                {
                    // If you defined a relationship without cascade delete, remove detail rows manually:
                    var details = db.DetailMT.Where(d => d.NoPlat == noPlat).ToList();
                    db.DetailMT.RemoveRange(details);

                    // Remove the MobilTangki row
                    db.MobilTangki.Remove(mobil);
                    db.SaveChanges();  // commits deletions:contentReference[oaicite:0]{index=0},:contentReference[oaicite:1]{index=1}

                    MessageBox.Show($"Mobil Tangki {noPlat} deleted.");
                }
            }

            // Refresh the grid after deletion
            LoadMobilTangki();
            dgvDetailMT.DataSource = null; // clear details grid if you show details
        }
    }
}
