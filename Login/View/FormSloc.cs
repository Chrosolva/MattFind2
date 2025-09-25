using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.Controller;
using Login.Controller;

namespace Login.View
{
    public partial class FormSloc : Form
    {
        #region properties

        public ControllerSlocs controllerSloc = new ControllerSlocs();
        BindingSource bindSlocBin = new BindingSource();
        public DataTable dt = new DataTable();

        #endregion

        #region fuunction

        public void FillcbxSloc()
        {
            dt = controllerSloc.getSloc();
            foreach(DataRow row in dt.Rows)
            {
                cbxSloc.Items.Add(row["Sloc"].ToString());
            }
        }

        #endregion

        public FormSloc()
        {
            InitializeComponent();
            this.FillcbxSloc();
            cbxSloc.SelectedIndex = 0;
        }

        private void FormSloc_Load(object sender, EventArgs e)
        {
            bindSlocBin.DataSource = controllerSloc.getSlocBin(cbxSloc.Text);
            dgvSlocBins.DataSource = bindSlocBin;
        }

        private void dgvSlocs_SelectionChanged(object sender, EventArgs e)
        {
            //if(dgvSlocBins.Rows.Count == 0)
            //{
            //    ClsStaticVariables.SlocID = "";
            //}
            //else
            //{
            //    ClsStaticVariables.SlocID = dgvSlocBins.CurrentRow.Cells["SlocBin"].Value.ToString() ?? "";
            //}
            //bindSlocBin.DataSource = controllerSloc.getSlocBin(ClsStaticVariables.SlocID);
            //dgvSlocBins.DataSource = bindSlocBin;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNESlocSlocBin fromNESloc = new FormNESlocSlocBin();
            fromNESloc.AccessibleDescription = "ADD";
            fromNESloc.btnAdd.AccessibleDescription = btnAdd.AccessibleDescription.ToString();
            fromNESloc.MdiParent = this.MdiParent;
            fromNESloc.WindowState = FormWindowState.Maximized;
            fromNESloc.ShowDialog();
            bindSlocBin.DataSource = controllerSloc.getSlocBin(cbxSloc.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvSlocBins.Rows.Count != 0)
            {
                FormNESlocSlocBin fromNESloc = new FormNESlocSlocBin(dgvSlocBins.CurrentRow.Cells["SlocBin"].Value.ToString());
                fromNESloc.AccessibleDescription = "EDIT";
                fromNESloc.btnAdd.AccessibleDescription = btnAdd.AccessibleDescription.ToString();
                fromNESloc.btnAdd.Text = "Ubah";
                fromNESloc.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Edit;
                fromNESloc.MdiParent = this.MdiParent;
                fromNESloc.WindowState = FormWindowState.Maximized;

                fromNESloc.ShowDialog();
                bindSlocBin.DataSource = controllerSloc.getSlocBin(cbxSloc.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(dgvSlocBins.Rows.Count !=0)
            {
                if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
                {
                    if (Convert.ToBoolean(dgvSlocBins.CurrentRow.Cells["Is_Empty"].Value))
                    {
                        DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data Sloc   " + dgvSlocBins.CurrentRow.Cells["SlocBin"].Value.ToString() + " ? ", " Warning ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show(controllerSloc.DeleteOneSloc(dgvSlocBins.CurrentRow.Cells["SlocBin"].Value.ToString()));
                        }
                        else if (dialogResult == DialogResult.No) { }
                        bindSlocBin.DataSource = controllerSloc.getSlocBin(cbxSloc.Text);
                    }
                    else
                    {
                        MessageBox.Show("Status SlocBin masih belum Empty");
                    }
                }
                else
                {
                    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
                }
                
            }
        }
    }
}
