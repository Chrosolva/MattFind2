using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEPTHCHK.Data;
using DEPTHCHK.Models;
using DEPTHCHK.Views;
using System.Data.Entity;

namespace DEPTHCHK.Views
{

    public partial class PengirimanForm : Form
    {
        private depthchkDBContext _db;
        private BindingSource _bsPeng = new BindingSource();
        private BindingSource _bsDetail = new BindingSource();
        private bool _loadingMaster;

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
            public string Compartment { get; set; }
            public decimal? DataBacaan { get; set; }
            public decimal? DataKalibrasi { get; set; }
            public string Satuan { get; set; }
            public string Keterangan { get; set; }
        }

        public PengirimanForm()
        {
            InitializeComponent();
        }

        private void PengirimanForm_Load(object sender, EventArgs e)
        {
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

            DataGridViewHelper.ApplyDefaultStyle(dgvPengiriman);
            DataGridViewHelper.ApplyDefaultStyle(dgvDetailPengiriman);

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
        }

        private void dgvPengiriman_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TryFormatColumn(dgvPengiriman, "Tgl_Input", "dd-MM-yyyy HH:mm");
            AutoFit(dgvPengiriman);
        }

        private void dgvDetailPengiriman_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TryFormatColumn(dgvDetailPengiriman, "Tgl_Input", "dd-MM-yyyy HH:mm");
            TryFormatColumn(dgvDetailPengiriman, "DataBacaan", "N2");
            TryFormatColumn(dgvDetailPengiriman, "DataKalibrasi", "N2");
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
                    else if (by == "Tujuan")
                        q = q.Where(p => p.Tujuan.Contains(term));
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
                        Tujuan = p.Tujuan,
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
                    Compartment = d.Compartment,
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
    }
}
