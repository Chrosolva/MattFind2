using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEALCHK.Data;
using SEALCHK.Model;
using ClosedXML.Excel;

namespace SEALCHK.View
{
    public partial class DestinationForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        private TblTujuan currentTujuan = null;   // null = add new

        public DestinationForm()
        {
            InitializeComponent();
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

        private void DestinationForm_Load(object sender, EventArgs e)
        {
            LoadKodeRegional();
            LoadKodeKepemilikan();
            LoadTujuan();
            DataGridViewHelper.ApplyDefaultStyle(dgvTujuan);
        }

        private void LoadKodeRegional()
        {
            var data = new List<RegionOption>
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

            cbxRegional.DisplayMember = "Display";   // what the user sees
            cbxRegional.ValueMember = "Id";     // the underlying value (1/2/3)
            cbxRegional.DataSource = data;

            // Optional: no initial selection
            cbxRegional.SelectedIndex = 0;   // (MaterialComboBox also supports this)
                                              // Or preselect one: cbxRegional.SelectedValue = 2; // Kalimantan
        }

        private void LoadKodeKepemilikan()
        {
            var data = new List<OwnedOption>
            {
                new OwnedOption { Id = 1, Name = "COCO (Corporate Owner, Corporate Operate)"},
                new OwnedOption { Id = 2, Name = "CODO (Corporate Owner, Dealer Operate)"},
                new OwnedOption { Id = 3, Name = "DODO (Dealer Owned Dealer Operate)"},
            };

            cbxOwned.DisplayMember = "Display";   // what the user sees
            cbxOwned.ValueMember = "Id";     // the underlying value (1/2/3)
            cbxOwned.DataSource = data;

            // Optional: no initial selection
            cbxOwned.SelectedIndex = 0;
        }

        private void cbxRegional_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? selectedId = cbxRegional.SelectedValue as int?;
            if (selectedId.HasValue)
            {
                // Text
                string selectedName = (cbxRegional.SelectedItem as RegionOption)?.Name;
                txtNamaRegional.Text = selectedName;

                // do something...
            }
        }

        private void cbxOwned_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? selectedId = cbxOwned.SelectedValue as int?;
            if (selectedId.HasValue)
            {
                // Text
                string selectedName = (cbxOwned.SelectedItem as OwnedOption)?.Name;
                txtNamaKepemilikan.Text = selectedName;

                // do something...
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            currentTujuan = null;
            ClearForm();
            txtKodeTujuan.Enabled = true;
            TCTujuan.SelectedTab = TPAddEditTujuan;
        }

        private void ClearForm()
        {
            txtKodeTujuan.Text = "";
            txtNamaSPBU.Text = "";
            txtAlamatSPBU.Text = "";
            cbxRegional.SelectedIndex = 0;
            cbxOwned.SelectedIndex = 0;
            currentTujuan = null;
            txtKodeTujuan.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(txtKodeTujuan.Text) ||
                string.IsNullOrWhiteSpace(txtNamaSPBU.Text) || 
                string.IsNullOrWhiteSpace(txtAlamatSPBU.Text))
            {
                MessageBox.Show("KodeTujuan, NamaSPBU and AlamatSPBU are required.");
                return;
            }

            if (currentTujuan == null)
            {
                // Create new MobilTangki
                var t = new TblTujuan
                {
                    KodeTujuan = txtKodeTujuan.Text.Trim(),
                    NamaSPBU = txtNamaSPBU.Text.Trim(),
                    AlamatSPBU = txtAlamatSPBU.Text.Trim(),
                    KodeRegional = (cbxRegional.SelectedItem as RegionOption)?.Id.ToString(),
                    NamaRegional = (cbxRegional.SelectedItem as RegionOption)?.Name.ToString(),
                    KodeKepemilikan = (cbxOwned.SelectedItem as OwnedOption)?.Id.ToString(),
                    NamaKepemilikan = (cbxOwned.SelectedItem as OwnedOption)?.Name.ToString()

                };
                _db.Tujuan.Add(t);
            }
            else
            {
                // Update existing
                currentTujuan.NamaSPBU = txtNamaSPBU.Text.Trim();
                currentTujuan.AlamatSPBU = txtAlamatSPBU.Text.Trim();
                currentTujuan.KodeRegional = (cbxRegional.SelectedItem as RegionOption)?.Id.ToString();
                currentTujuan.NamaRegional = (cbxRegional.SelectedItem as RegionOption)?.Name.ToString();
                currentTujuan.KodeKepemilikan = (cbxOwned.SelectedItem as OwnedOption)?.Id.ToString();
                currentTujuan.NamaKepemilikan = (cbxOwned.SelectedItem as OwnedOption)?.Name.ToString();
                // leave DetailStatus as is, or update if you add an input for it
            }

            _db.SaveChanges();
            LoadTujuan();                      // refresh grid
            ClearForm();
            currentTujuan = null;
            TCTujuan.SelectedTab = TPTujuan;   // back to list
        }

        private void LoadTujuan()
        {
            var data = _db.Tujuan
                          .OrderBy(t => t.KodeTujuan)
                          .Select(t => new
                          {
                              t.KodeTujuan,
                              t.NamaSPBU,
                              t.AlamatSPBU,
                              t.KodeRegional,
                              t.NamaRegional,
                              t.KodeKepemilikan,
                              t.NamaKepemilikan
                          })
                          .ToList();

            dgvTujuan.DataSource = data;

            if (dgvTujuan.Rows.Count > 0)
                dgvTujuan.Rows[0].Selected = true; // trigger detail load
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTujuan.CurrentRow == null) return;

            string KodeTujuan = dgvTujuan.CurrentRow.Cells["KodeTujuan"].Value.ToString();
            currentTujuan = _db.Tujuan.FirstOrDefault(t => t.KodeTujuan == KodeTujuan);
            if (currentTujuan != null)
            {
                txtKodeTujuan.Text = currentTujuan.KodeTujuan;
                txtKodeTujuan.Enabled = false; // primary key shouldn't be changed
                txtNamaSPBU.Text = currentTujuan.NamaSPBU;
                txtAlamatSPBU.Text = currentTujuan.AlamatSPBU;
                cbxRegional.SelectedIndex = Convert.ToInt32(currentTujuan.KodeRegional)-1;
                txtNamaRegional.Text = currentTujuan.NamaRegional;
                cbxOwned.SelectedIndex = Convert.ToInt32(currentTujuan.KodeKepemilikan)-1;
                txtNamaKepemilikan.Text = currentTujuan.NamaKepemilikan;

                // switch to Create/Edit tab
                TCTujuan.SelectedTab = TPAddEditTujuan;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure there is a selected row
            if (dgvTujuan.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string kodeTujuan = dgvTujuan.CurrentRow.Cells["KodeTujuan"].Value.ToString();

            // Ask the user to confirm deletion
            var result = MessageBox.Show(
                $"Are you sure you want to delete Tujuan {kodeTujuan}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return; // user cancelled

            // Delete using Entity Framework
            using (var db = new SealCheckContext())
            {
                // Load the MobilTangki entity and its related details
                var tujuan = db.Tujuan.FirstOrDefault(t => t.KodeTujuan == kodeTujuan);
                if (tujuan != null)
                {
                    // Remove the Tujuan row
                    db.Tujuan.Remove(tujuan);
                    db.SaveChanges();  // commits deletions:contentReference[oaicite:0]{index=0},:contentReference[oaicite:1]{index=1}

                    MessageBox.Show($"Tujuan {tujuan} deleted.");
                }
            }

            // Refresh the grid after deletion
            LoadTujuan();
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
                            string kodeTujuan = row.Cell(1).GetString().Trim();
                            string namaSPBU = row.Cell(2).GetString().Trim();
                            string alamatSPBU = row.Cell(3).GetString().Trim();
                            string kodeRegional = row.Cell(4).GetString().Trim();
                            string kodeKepemilikan = row.Cell(5).GetString().Trim();
                            string namaRegional = row.Cell(6).GetString().Trim();
                            string namaKepemilikan = row.Cell(7).GetString().Trim();

                            // see if this plate already exists
                            var existing = _db.Tujuan.Find(kodeTujuan);
                            if (existing == null)
                            {
                                // create new record
                                var t = new TblTujuan
                                {
                                    KodeTujuan = kodeTujuan,
                                    NamaSPBU = namaSPBU,
                                    AlamatSPBU = alamatSPBU,
                                    KodeRegional = kodeRegional,
                                    NamaRegional = namaRegional,
                                    KodeKepemilikan = kodeKepemilikan,
                                    NamaKepemilikan = namaKepemilikan
                                };
                                _db.Tujuan.Add(t);
                            }
                            else
                            {
                                // update existing (optional)
                                existing.NamaSPBU = namaSPBU;
                                existing.AlamatSPBU = alamatSPBU;
                                existing.KodeRegional = kodeRegional;
                                existing.NamaRegional = namaRegional;
                                existing.KodeKepemilikan = kodeKepemilikan;
                                existing.NamaKepemilikan = namaKepemilikan;
                            }
                        }

                        _db.SaveChanges();
                        MessageBox.Show("Import completed.");
                        LoadTujuan(); // refresh grid
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
                FileName = "Tujuan SPBU.xlsx"
            })
            {
                if (saveDlg.ShowDialog() != DialogResult.OK) return;

                using (var db = new SealCheckContext())
                using (var workbook = new XLWorkbook())
                {
                    // Sheet 1: MobilTangki
                    var wsMT = workbook.Worksheets.Add("Tujuan");

                    // header row
                    wsMT.Cell(1, 1).Value = "KodeTujuan";
                    wsMT.Cell(1, 2).Value = "NamaSPBU";
                    wsMT.Cell(1, 3).Value = "AlamatSPBU";
                    wsMT.Cell(1, 4).Value = "KodeRegional";
                    wsMT.Cell(1, 5).Value = "KodeKepemilikan";
                    wsMT.Cell(1, 6).Value = "NamaRegional";
                    wsMT.Cell(1, 7).Value = "NamaKepemilikan";

                    // data
                    var tujuanlist = db.Tujuan.OrderBy(t => t.KodeTujuan).ToList();
                    int tRow = 2;
                    foreach (var t in tujuanlist)
                    {
                        wsMT.Cell(tRow, 1).Value = t.KodeTujuan;
                        wsMT.Cell(tRow, 2).Value = t.NamaSPBU;
                        wsMT.Cell(tRow, 3).Value = t.AlamatSPBU;
                        wsMT.Cell(tRow, 4).Value = t.KodeRegional;
                        wsMT.Cell(tRow, 5).Value = t.KodeKepemilikan;
                        wsMT.Cell(tRow, 6).Value = t.NamaRegional;
                        wsMT.Cell(tRow, 7).Value = t.NamaKepemilikan;
                        tRow++;
                    }

                    // optional: adjust column widths to fit contents
                    wsMT.Columns().AdjustToContents();

                    // save workbook
                    workbook.SaveAs(saveDlg.FileName);
                    MessageBox.Show("Export completed successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
