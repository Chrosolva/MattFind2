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
    public partial class FindMT : MaterialForm
    {
        private readonly SealCheckContext _db;
        private readonly Timer _debounce;
        public string SelectedNoPlat { get; private set; }

        private sealed class MtRow
        {
            public string NoPlat { get; set; }
            public string Type { get; set; }
            public int? JlhCompartment { get; set; }
            public int? CoverBoxPanel { get; set; }
            public string DetailStatus { get; set; }
        }

        public FindMT(SealCheckContext db)
        {
            InitializeComponent();
            _db = db;

            // SearchBy options
            cbxSearchBy.Items.Clear();
            cbxSearchBy.Items.AddRange(new object[] { "All", "NoPlat", "Type", "DetailStatus" });
            cbxSearchBy.SelectedIndex = 0;

            // Debounce for typing
            _debounce = new Timer { Interval = 250 };
            _debounce.Tick += (s, e) => { _debounce.Stop(); LoadData(); };

            txtSearch.TextChanged += (s, e) => { _debounce.Stop(); _debounce.Start(); };
            cbxSearchBy.SelectedIndexChanged += (s, e) => LoadData();

            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.CellDoubleClick += (s, e) => SelectCurrent();
            dgv.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.Handled = true; SelectCurrent(); } };

            btnSelect.Click += (s, e) => SelectCurrent();
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

            // First load
            LoadData();
        }

        private void LoadData()
        {
            string term = (txtSearch.Text ?? "").Trim();
            string by = cbxSearchBy.SelectedItem as string ?? "All";

            IQueryable<TblMobilTangki> q = _db.MobilTangki;   // <-- IQueryable, no AsNoTracking here

            if (term.Length > 0)
            {
                switch (by)
                {
                    case "NoPlat":
                        q = q.Where(x => x.NoPlat.Contains(term));
                        break;
                    case "Type":
                        q = q.Where(x => (x.Type ?? "").Contains(term));
                        break;
                    case "DetailStatus":
                        q = q.Where(x => (x.DetailStatus ?? "").Contains(term));
                        break;
                    default: // All
                        q = q.Where(x =>
                            x.NoPlat.Contains(term) ||
                            (x.Type ?? "").Contains(term) ||
                            (x.DetailStatus ?? "").Contains(term));
                        break;
                }
            }

            var list = q.AsNoTracking()                      // <-- apply here
                        .OrderBy(x => x.NoPlat)
                        .Select(x => new MtRow
                        {
                            NoPlat = x.NoPlat,
                            Type = x.Type,
                            JlhCompartment = x.JlhCompartment,
                            CoverBoxPanel = x.CoverBoxPanel,
                            DetailStatus = x.DetailStatus
                        })
                        .ToList();

            dgv.DataSource = list;
            lblRowCount.Text = $"{list.Count} item(s)";
            if (list.Count > 0) { dgv.ClearSelection(); dgv.Rows[0].Selected = true; }
        }


        private void SelectCurrent()
        {
            var row = dgv.CurrentRow?.DataBoundItem as MtRow;
            if (row == null)
            {
                MessageBox.Show("Select a row first.", "Find MT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelectedNoPlat = row.NoPlat;
            DialogResult = DialogResult.OK;
        }

        private void FindMT_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.ApplyDefaultStyle(dgv);
            dgv.AllowUserToResizeColumns = true;
        }
    }
}
