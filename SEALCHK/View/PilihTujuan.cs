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
using SEALCHK.UserControls;
using MaterialSkin;
using MaterialSkin.Controls;
using RegionOption = SEALCHK.View.RegisterSealForm.RegionOption;
using OwnedOption = SEALCHK.View.RegisterSealForm.OwnedOption;


namespace SEALCHK.View
{
    public partial class PilihTujuan : MaterialForm
    {
        private readonly SealCheckContext _db = new SealCheckContext();

        private readonly List<RegionOption> _regions;
        private readonly List<OwnedOption> _owners;

        private readonly List<UCTujuan> _slots = new List<UCTujuan>();
        private int _activeIndex = 0; // which slot will receive the selected tujuan

        // OUTPUT: caller reads this after DialogResult.OK
        // PilihTujuan.cs (class body)
        public string[] SelectedKodeTujuan { get; private set; }
        public string[] SelectedNamaSPBU { get; private set; }


        //public PilihTujuan()
        //{
        //    InitializeComponent();
        //}

        public PilihTujuan(int jlhCompartment,
    IEnumerable<SEALCHK.View.RegisterSealForm.RegionOption> regions,
    IEnumerable<SEALCHK.View.RegisterSealForm.OwnedOption> owners,
    string[] initialCodes = null)

        {
            InitializeComponent();

            _regions = regions != null ? new List<RegionOption>(regions) : new List<RegionOption>();
            _owners = owners != null ? new List<OwnedOption>(owners) : new List<OwnedOption>();

            // build compartments UI
            BuildCompartments(jlhCompartment, initialCodes);

            // load filters/search UI
            LoadFilterCombos();

            // search-by column list (pick any subset you like)
            cbxSearchBy.Items.Clear();
            cbxSearchBy.Items.AddRange(new object[]
            {
            "KodeTujuan", "NamaSPBU", "AlamatSPBU", "NamaRegional", "NamaKepemilikan"
            });
            cbxSearchBy.SelectedIndex = 0;

            // wiring
            txtSearch.TextChanged += (s, e) => RefreshGrid();
            cbxRegional.SelectedIndexChanged += (s, e) => RefreshGrid();
            cbxOwned.SelectedIndexChanged += (s, e) => RefreshGrid();
            cbxSearchBy.SelectedIndexChanged += (s, e) => RefreshGrid();

            dgvTujuan.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) AssignRowToActiveSlot(e.RowIndex); };

            btnAssignToActive.Click += (s, e) => AssignSelectedRowToActiveSlot();
            btnClearSlot.Click += (s, e) => { SetSlotKode(_activeIndex, null); };
            btnClearAll.Click += (s, e) => { foreach (var uc in _slots) uc.KodeTujuan = null; };
            btnFinSet.Click += (s, e) => FinishAndClose();

            // first paint
            RefreshGrid();
            UpdateActiveUi();
        }

        // ---------- Build compartments ----------
        private void BuildCompartments(int jlhCompartment, string[] initialCodes)
        {
            grpCompart.SuspendLayout();
            grpCompart.Controls.Clear();
            _slots.Clear();

            for (int i = 0; i < jlhCompartment; i++)
            {
                var uc = new UCTujuan
                {
                    Index = i,
                    Dock = DockStyle.Top
                };
                uc.SelectRequested += OnSlotSelectRequested;
                if (initialCodes != null && i < initialCodes.Length)
                    uc.KodeTujuan = initialCodes[i];

                // optional: show "Compartment N" label if you put a label on UCTujuan
                // uc.lblTitle.Text = "Compartment " + (i + 1);

                _slots.Add(uc);
                grpCompart.Controls.Add(uc);
                uc.BringToFront(); // newest on top
            }

            grpCompart.ResumeLayout();
            _activeIndex = Math.Min(Math.Max(0, _activeIndex), Math.Max(0, _slots.Count - 1));
        }

        private void OnSlotSelectRequested(object sender, EventArgs e)
        {
            var uc = sender as UCTujuan;
            if (uc == null) return;
            _activeIndex = uc.Index;
            UpdateActiveUi();
        }

        private void UpdateActiveUi()
        {
            lblActiveSlot.Text = "Active: Compartment " + (_activeIndex + 1);
            for (int i = 0; i < _slots.Count; i++)
                _slots[i].Highlight(i == _activeIndex);
        }

        private void SetSlotKode(int index, string kode)
        {
            if (index < 0 || index >= _slots.Count) return;
            _slots[index].KodeTujuan = kode;
        }

        // ---------- Filters/Search ----------
        private void LoadFilterCombos()
        {
            // Add an "All" option at top for both combos
            var regions = new List<RegionOption> { new RegionOption { Id = 0, Name = "Semua Regional" } };
            regions.AddRange(_regions);

            var owners = new List<OwnedOption> { new OwnedOption { Id = 0, Name = "Semua Kepemilikan" } };
            owners.AddRange(_owners);

            cbxRegional.DisplayMember = "Display";
            cbxRegional.ValueMember = "Id";
            cbxRegional.DataSource = regions;
            cbxRegional.SelectedIndex = 0;

            cbxOwned.DisplayMember = "Display";
            cbxOwned.ValueMember = "Id";
            cbxOwned.DataSource = owners;
            cbxOwned.SelectedIndex = 0;
        }

        private void RefreshGrid()
        {
            string term = (txtSearch.Text ?? "").Trim();
            string searchBy = cbxSearchBy.SelectedItem != null ? cbxSearchBy.SelectedItem.ToString() : "NamaSPBU";

            int regId = cbxRegional.SelectedValue is int ? (int)cbxRegional.SelectedValue : 0;
            int ownId = cbxOwned.SelectedValue is int ? (int)cbxOwned.SelectedValue : 0;

            // Note: TblTujuan uses strings for these codes.
            string kodeRegional = regId > 0 ? regId.ToString() : null; // "1","2","..."
            string kodeKepemilikan = ownId > 0 ? ownId.ToString() : null; // "1","3","4"

            var q = _db.Tujuan.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(kodeRegional))
                q = q.Where(t => t.KodeRegional == kodeRegional);
            if (!string.IsNullOrEmpty(kodeKepemilikan))
                q = q.Where(t => t.KodeKepemilikan == kodeKepemilikan);

            if (!string.IsNullOrWhiteSpace(term))
            {
                // simple contains; adjust to your needs
                switch (searchBy)
                {
                    case "KodeTujuan": q = q.Where(t => t.KodeTujuan.Contains(term)); break;
                    case "NamaSPBU": q = q.Where(t => t.NamaSPBU.Contains(term)); break;
                    case "AlamatSPBU": q = q.Where(t => t.AlamatSPBU.Contains(term)); break;
                    case "NamaRegional": q = q.Where(t => t.NamaRegional.Contains(term)); break;
                    case "NamaKepemilikan": q = q.Where(t => t.NamaKepemilikan.Contains(term)); break;
                    default: q = q.Where(t => t.NamaSPBU.Contains(term)); break;
                }
            }

            var list = q
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

            dgvTujuan.AutoGenerateColumns = true;
            dgvTujuan.DataSource = list;
            lblRowCount.Text = "Rows: " + list.Count;
        }

        private void AssignSelectedRowToActiveSlot()
        {
            if (dgvTujuan.CurrentRow == null) return;
            AssignRowToActiveSlot(dgvTujuan.CurrentRow.Index);
        }

        private void AssignRowToActiveSlot(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvTujuan.Rows.Count) return;

            object kodeObj = dgvTujuan.Rows[rowIndex].Cells["KodeTujuan"].Value;
            object namaObj = dgvTujuan.Rows[rowIndex].Cells["NamaSPBU"].Value;

            string kode = kodeObj != null ? kodeObj.ToString() : null;
            string nama = namaObj != null ? namaObj.ToString() : null;

            if (!string.IsNullOrWhiteSpace(kode))
            {
                SetSlotKodeNama(_activeIndex, kode, nama);

                // auto-advance
                if (_activeIndex + 1 < _slots.Count)
                {
                    _activeIndex++;
                    UpdateActiveUi();
                }
            }
        }

        private void SetSlotKodeNama(int index, string kode, string nama)
        {
            if (index < 0 || index >= _slots.Count) return;
            _slots[index].KodeTujuan = kode;
            _slots[index].NamaSPBU = nama;
        }

        private void FinishAndClose()
        {
            var kode = new string[_slots.Count];
            var nama = new string[_slots.Count];

            for (int i = 0; i < _slots.Count; i++)
            {
                kode[i] = _slots[i].KodeTujuan;
                nama[i] = _slots[i].NamaSPBU;
            }

            SelectedKodeTujuan = kode;
            SelectedNamaSPBU = nama;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PilihTujuan_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.ApplyDefaultStyle(dgvTujuan);
        }

        
    }
}
