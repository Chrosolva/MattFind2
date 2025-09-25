using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEALCHK.View;
using SEALCHK.Model;
using SEALCHK.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.Entity;

namespace SEALCHK.View
{
    public partial class FindRegisterForm : MaterialForm
    {

        private readonly SealCheckContext _db;
        private Timer _debounce;
        public string SelectedNoPlat { get; private set; }
        public DateTime SelectedTglInput { get; private set; }

        // Optional: let caller prefill search UI
        public string InitialTerm { get; set; }
        public string InitialSearchBy { get; set; } = "All";
        public DateTime? InitialFrom { get; set; }
        public DateTime? InitialTo { get; set; }

        public FindRegisterForm(SealCheckContext db)
        {
            InitializeComponent();
            _db = db;

            // Hook the Load event so FindRegisterForm_Load actually runs
            this.Load += FindRegisterForm_Load;

            // basic UI init
            cbxSearchBy.Items.Clear();
            cbxSearchBy.Items.AddRange(new object[] { "All", "NoPlat", "Tujuan", "Status", "UserINPUT" });
            cbxSearchBy.SelectedIndex = 0;

            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;

            // debounce
            _debounce = new Timer { Interval = 250 };
            _debounce.Tick += (s, e) => { _debounce.Stop(); LoadGrid(); };

            // events
            txtSearch.TextChanged += (s, e) => { _debounce.Stop(); _debounce.Start(); };
            cbxSearchBy.SelectedIndexChanged += (s, e) => LoadGrid();
            dtpFrom.ValueChanged += (s, e) => LoadGrid();
            dtpTo.ValueChanged += (s, e) => LoadGrid();

            dgv.CellDoubleClick += (s, e) => TrySelectCurrent();
            btnSelect.Click += (s, e) => TrySelectCurrent();
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void FindRegisterForm_Load(object sender, EventArgs e)
        {
            // apply initial values (if provided)
            if (!string.IsNullOrWhiteSpace(InitialTerm)) txtSearch.Text = InitialTerm;
            if (!string.IsNullOrWhiteSpace(InitialSearchBy))
            {
                int idx = cbxSearchBy.Items.IndexOf(InitialSearchBy);
                if (idx >= 0) cbxSearchBy.SelectedIndex = idx;
            }
            if (InitialFrom.HasValue) dtpFrom.Value = InitialFrom.Value.Date;
            if (InitialTo.HasValue) dtpTo.Value = InitialTo.Value.Date;

            LoadGrid();
            DataGridViewHelper.ApplyDefaultStyle(dgv);
        }

        private void LoadGrid()
        {
            string term = (txtSearch.Text ?? "").Trim();
            string by = cbxSearchBy.SelectedItem as string ?? "All";
            DateTime from = dtpFrom.Value.Date;
            DateTime toExcl = dtpTo.Value.Date.AddDays(1);

            var q = _db.Registers.AsNoTracking()
                        .Where(r => r.Tgl_Input >= from && r.Tgl_Input < toExcl);

            if (term.Length > 0)
            {
                switch (by)
                {
                    case "NoPlat": q = q.Where(r => r.NoPlat.Contains(term)); break;
                    case "Tujuan": q = q.Where(r => (r.Tujuan ?? "").Contains(term)); break;
                    case "Status": q = q.Where(r => (r.Status ?? "").Contains(term)); break;
                    case "UserINPUT": q = q.Where(r => (r.UserINPUT ?? "").Contains(term)); break;
                    default:
                        q = q.Where(r =>
                            r.NoPlat.Contains(term) ||
                            (r.Tujuan ?? "").Contains(term) ||
                            (r.Status ?? "").Contains(term) ||
                            (r.UserINPUT ?? "").Contains(term));
                        break;
                }
            }

            var list = q.OrderByDescending(r => r.Tgl_Input)
                        .ThenBy(r => r.NoPlat)
                        .ToList(); // bind POCOs; we’ll hide navs

            dgv.DataSource = list;

            // hide nav properties if present
            if (dgv.Columns.Contains("MobilTangki")) dgv.Columns["MobilTangki"].Visible = false;
            if (dgv.Columns.Contains("User")) dgv.Columns["User"].Visible = false;
            if (dgv.Columns.Contains("DetailRegisters")) dgv.Columns["DetailRegisters"].Visible = false;

            lblRowCount.Text = $"Rows: {list.Count}";
        }

        private void TrySelectCurrent()
        {
            var reg = dgv.CurrentRow?.DataBoundItem as TblRegister;
            if (reg == null)
            {
                MessageBox.Show("Select a row first.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelectedNoPlat = reg.NoPlat;
            SelectedTglInput = reg.Tgl_Input; // this is the exact DateTime we’ll use
            DialogResult = DialogResult.OK;
        }
    }
}
