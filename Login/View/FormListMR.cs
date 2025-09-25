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
    public partial class FormListMR : Form
    {
        #region properties

        ControllerMaterial controllerMaterial = new ControllerMaterial();
        BindingSource bindMats = new BindingSource();
        ControllerManagement controllerManagement = new ControllerManagement();
        BindingSource bind = new BindingSource();


        #endregion

        public FormListMR()
        {
            InitializeComponent();
        }

        private void FormListMR_Load(object sender, EventArgs e)
        {
            cbxJenis.SelectedIndex = 0;
            if(this.Tag.ToString() == "Request")
            {
                bind.DataSource = controllerManagement.GetAllMaterialRequest();
            }
            else if (this.Tag.ToString() == "Entry")
            {
                bind.DataSource = controllerManagement.GetAllMaterialEntry();
            }
            dgvListItem.DataSource = bind;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            bind.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bind.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dgvListItem.Rows.Count!=0)
            {
                ClsStaticVariables.Reference = dgvListItem.CurrentRow.Cells["Management_ID"].Value.ToString();
            }
            this.Close();
        }
    }
}
