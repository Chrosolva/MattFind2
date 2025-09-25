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
    public partial class FormListItem : Form
    {
        public FormListItem()
        {
            InitializeComponent();
        }

        #region properties

        ControllerMaterial controllerMaterial = new ControllerMaterial();
        BindingSource bindMats = new BindingSource();
        ControllerManagement controllerManagement = new ControllerManagement();
        BindingSource bind = new BindingSource();


        #endregion

        private void FormListItem_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "MaterialSearch")
            {
                bindMats.DataSource = controllerMaterial.getAllMaterial();
                dgvListItem.DataSource = bindMats;
                btnGotoSlocBin.Visible = false;
                btnAdd.Visible = true;
            }
            else if (this.Tag.ToString() == "MaterialSearchViaSlocBin")
            {
                bind.DataSource = controllerManagement.SearchMaterial(ClsStaticVariables.MaterialNumber);
                dgvListItem.DataSource = bind;
                btnGotoSlocBin.Visible = true;
                btnAdd.Visible = false;
            }
            else if (this.Tag.ToString() == "TitipanSearch")
            {
                bindMats.DataSource = controllerMaterial.getAllMaterialTitipan();
                dgvListItem.DataSource = bindMats;
                btnGotoSlocBin.Visible = false;
                btnAdd.Visible = true;
            }
            else if (this.Tag.ToString() == "MaterialSearch2")
            {
                bindMats.DataSource = controllerManagement.getSlocBinDetails2();
                dgvListItem.DataSource = bindMats;
                btnGotoSlocBin.Visible = false;
                btnAdd.Visible = true;
            }
            else if (this.Tag.ToString() == "MaterialSearch3")
            {
                bindMats.DataSource = controllerManagement.getSlocBinDetails2(ClsStaticVariables.MaterialNumber);
                dgvListItem.DataSource = bindMats;
                btnGotoSlocBin.Visible = false;
                btnAdd.Visible = true;
            }

        }

        private void dgvListItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.Tag.ToString() == "MaterialSearch")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                ClsStaticVariables.Value = 0;
                this.Close();
            }
            else if (this.Tag.ToString() == "TitipanSearch")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                this.Close();
            }
            else if (this.Tag.ToString() == "MaterialSearch2")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                ClsStaticVariables.Sloc = dgvListItem.CurrentRow.Cells["Sloc"].Value.ToString();
                ClsStaticVariables.SlocBinID = dgvListItem.CurrentRow.Cells["SlocBin"].Value.ToString();
                ClsStaticVariables.Reference = dgvListItem.CurrentRow.Cells["Reference"].Value.ToString();
                ClsStaticVariables.Area = dgvListItem.CurrentRow.Cells["Area"].Value.ToString();
                ClsStaticVariables.Equipment = dgvListItem.CurrentRow.Cells["Equipment"].Value.ToString();
                ClsStaticVariables.ManagementID = dgvListItem.CurrentRow.Cells["Management_ID"].Value.ToString();
                ClsStaticVariables.QtyAlokasi = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["QtyAlokasi"].Value);
                this.Close();
            }
            else if (this.Tag.ToString() == "MaterialSearch3")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                ClsStaticVariables.Sloc = dgvListItem.CurrentRow.Cells["Sloc"].Value.ToString();
                ClsStaticVariables.SlocBinID = dgvListItem.CurrentRow.Cells["SlocBin"].Value.ToString();
                ClsStaticVariables.Reference = dgvListItem.CurrentRow.Cells["Reference"].Value.ToString();
                ClsStaticVariables.Area = dgvListItem.CurrentRow.Cells["Area"].Value.ToString();
                ClsStaticVariables.Equipment = dgvListItem.CurrentRow.Cells["Equipment"].Value.ToString();
                ClsStaticVariables.ManagementID = dgvListItem.CurrentRow.Cells["Management_ID"].Value.ToString();
                ClsStaticVariables.QtyAlokasi = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["QtyAlokasi"].Value);
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "MaterialSearch")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                ClsStaticVariables.Value = 0;
                this.Close();
            }
            else if (this.Tag.ToString() == "TitipanSearch")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                this.Close();
            }
            else if (this.Tag.ToString() == "MaterialSearch2")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                ClsStaticVariables.Sloc = dgvListItem.CurrentRow.Cells["Sloc"].Value.ToString();
                ClsStaticVariables.SlocBinID = dgvListItem.CurrentRow.Cells["SlocBin"].Value.ToString();
                ClsStaticVariables.Reference = dgvListItem.CurrentRow.Cells["Reference"].Value.ToString();
                ClsStaticVariables.Area = dgvListItem.CurrentRow.Cells["Area"].Value.ToString();
                ClsStaticVariables.Equipment = dgvListItem.CurrentRow.Cells["Equipment"].Value.ToString();
                ClsStaticVariables.ManagementID = dgvListItem.CurrentRow.Cells["Management_ID"].Value.ToString();
                ClsStaticVariables.QtyAlokasi = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["QtyAlokasi"].Value);
                this.Close();
            }
            else if (this.Tag.ToString() == "MaterialSearch3")
            {
                ClsStaticVariables.tambah = true;
                ClsStaticVariables.MaterialNumber = dgvListItem.CurrentRow.Cells["Material_Number"].Value.ToString();
                ClsStaticVariables.MaterialDescription = dgvListItem.CurrentRow.Cells["Material_Description"].Value.ToString();
                ClsStaticVariables.Qty = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["Qty"].Value);
                ClsStaticVariables.BaseUnit = dgvListItem.CurrentRow.Cells["Base_Unit"].Value.ToString();
                ClsStaticVariables.Sloc = dgvListItem.CurrentRow.Cells["Sloc"].Value.ToString();
                ClsStaticVariables.SlocBinID = dgvListItem.CurrentRow.Cells["SlocBin"].Value.ToString();
                ClsStaticVariables.Reference = dgvListItem.CurrentRow.Cells["Reference"].Value.ToString();
                ClsStaticVariables.Area = dgvListItem.CurrentRow.Cells["Area"].Value.ToString();
                ClsStaticVariables.Equipment = dgvListItem.CurrentRow.Cells["Equipment"].Value.ToString();
                ClsStaticVariables.ManagementID = dgvListItem.CurrentRow.Cells["Management_ID"].Value.ToString();
                ClsStaticVariables.QtyAlokasi = Convert.ToDecimal(dgvListItem.CurrentRow.Cells["QtyAlokasi"].Value);
                this.Close();
            }
        }

        private void btnGotoSlocBin_Click(object sender, EventArgs e)
        {
            FormSlocBinDetails frmSlocBinDetails = new FormSlocBinDetails(dgvListItem.CurrentRow.Cells["SlocBin"].Value.ToString());
            frmSlocBinDetails.WindowState = FormWindowState.Maximized;
            frmSlocBinDetails.ShowDialog();

            ClsStaticVariables.status = controllerManagement.cekStatusSlocBin(dgvListItem.CurrentRow.Cells["SlocBin"].Value.ToString());
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if(this.Tag.ToString() == "MaterialSearch")
            {
                bindMats.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
            }
            else if ( this.Tag.ToString() == "MaterialSearchViaSlocBin")
            {
                bind.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "MaterialSearch")
            {
                bindMats.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
            }
            else if (this.Tag.ToString() == "MaterialSearchViaSlocBin")
            {
                bind.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
            }
        }

        private void FormListItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
