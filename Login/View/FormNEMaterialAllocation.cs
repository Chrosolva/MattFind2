using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master;
using Master.Controller;
using Login.Controller;
using Login.Models;

namespace Login.View
{
    public partial class FormNEMaterialAllocation : Form
    {
        #region properties

        ControllerMaterial controllerMaterial = new ControllerMaterial();
        BindingSource bindMats = new BindingSource();
        ControllerManagement controllerManagement = new ControllerManagement();
        BindingSource bind = new BindingSource();
        public DataTable dt = new DataTable();


        #endregion
        public FormNEMaterialAllocation()
        {
            InitializeComponent();
        }

        private void btnSearchME_Click(object sender, EventArgs e)
        {
            FormListMR frmListMR = new FormListMR();
            frmListMR.Tag = "Entry";
            frmListMR.ShowDialog();

            if (ClsStaticVariables.Reference.Trim() != "")
            {
                dgvManagementDetail.Rows.Clear();
                dt = controllerManagement.getManagementAllocation(ClsStaticVariables.Reference);
                txtManagementID.Text = ClsStaticVariables.Reference;
                
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Material_Number"].ToString().Trim() != "") 
                    {
                        int rowindex = dgvManagementDetail.Rows.Add();
                        dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                        dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = row["Material_Number"];
                        dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = row["Material_Description"];
                        dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = Convert.ToDecimal(row["Qty"]);
                        dgvManagementDetail.Rows[rowindex].Cells["Reference"].Value = row["Reference"];
                        dgvManagementDetail.Columns["MaterialSearch"].Width = 50;
                        dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = row["Sloc"];
                    }
                    else { MessageBox.Show("Data Alokasi tidak ada, Material telah keluar dari gudang "); }
                    
                }
                
            }
        }

        private void dgvManagementDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvManagementDetail.Columns[e.ColumnIndex].Name)
            {
                case "MaterialSearch":
                    FormListItem frmListitem = new FormListItem();
                    frmListitem.Tag = "MaterialSearch";
                    frmListitem.ShowDialog();

                    int rowindex = dgvManagementDetail.Rows.Add();
                    dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = ClsStaticVariables.MaterialNumber;
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = ClsStaticVariables.MaterialDescription;
                    dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = 0;
                    dgvManagementDetail.Rows[rowindex].Cells["Reference"].Value = "z~Free Stock";
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // set Allocation 
            foreach (DataGridViewRow row in dgvManagementDetail.Rows)
            {
                if (!row.IsNewRow)
                {
                    controllerManagement.obMMAlloc = new ClsMaterialAllocation(txtManagementID.Text, row.Cells["MaterialNumber"].Value.ToString(), row.Cells["Reference"].Value.ToString(), Convert.ToDecimal(row.Cells["Qty"].Value), row.Cells["Sloc"].Value.ToString());
                    controllerManagement.listMMalloc.Add(controllerManagement.obMMAlloc);

                }

            }
            //Delete All Alocation
            controllerManagement.DeleteAllocationPerMID(txtManagementID.Text);
            // Reinsert 
            MessageBox.Show(controllerManagement.InsertManagementAllocation(controllerManagement.listMMalloc));
            this.Close();
        }

        private void FormNEMaterialAllocation_Load(object sender, EventArgs e)
        {
            txtManagementID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvManagementDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvManagementDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvManagementDetail.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ','))
            {
                e.Handled = false;
            }
        }
    }
}
