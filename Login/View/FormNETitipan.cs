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
    public partial class FormNETitipan : Form
    {
        #region properties

        public string ManagementType = "";
        public string SlocBinID = "";
        public ControllerManagement controllerManagement = new ControllerManagement();
        public ControllerSlocs controllerSloc = new ControllerSlocs();
        public DataTable dt = new DataTable();
        public DataGridView othr = new DataGridView();
        #endregion

        #region function 

        public void setCbxSloc()
        {
            dt = controllerSloc.getSloc();
            foreach (DataRow row in dt.Rows)
            {
                cbxSloc.Items.Add(row["Sloc"].ToString());
            }
        }

        #endregion

        public FormNETitipan()
        {
            InitializeComponent();
            //if(this.Tag.ToString() == "DELETE")
            //{
            //    btnSearchMR.Enabled = false;

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchMR_Click(object sender, EventArgs e)
        {
            FormListMR frmListMR = new FormListMR();
            frmListMR.Tag = "Request";
            frmListMR.ShowDialog();

            if(ClsStaticVariables.Reference.Trim() != "")
            {
                dgvManagementDetail.Rows.Clear();
                dt =  controllerManagement.getManagementDetail(ClsStaticVariables.Reference);
                txtReference.Text = ClsStaticVariables.Reference;
                foreach(DataRow row in dt.Rows)
                {
                    int rowindex = dgvManagementDetail.Rows.Add();
                    dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = row["Material_Number"];
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = row["Material_Description"];
                    dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = Convert.ToDecimal(row["Qty"]);
                    dgvManagementDetail.Rows[rowindex].Cells["BaseUnit"].Value = row["Base_Unit"];
                    dgvManagementDetail.Rows[rowindex].Cells["Note"].Value = "-";
                    dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = row["Sloc"];
                }
            }
        }

        private void FormNETitipan_Load(object sender, EventArgs e)
        {
            dtpTgl.Value = DateTime.Now;
            cbxSloc.SelectedIndex = 0;
            this.txtSlocBin.Text = ClsStaticVariables.SlocBinID;
            setCbxSloc();
            txtManagementID.Text = controllerManagement.AutoGenerateTitipanID("M.TT");
            if(this.Tag.ToString() == "ADD")
            {
                TSAvailable.Checked = true;
            }
            else if (this.Tag.ToString() =="DELETE")
            {
                TSEmpty.Checked = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.Tag.ToString() == "ADD")
            {
                //set Titipan Detaiil
                //Set SlocBin Detail
                //Update SlocBin Status
                //set Titipan
                controllerManagement.objTitip = new ClsTitipan(txtManagementID.Text,txtReference.Text, txtNamaPenanggungJawab.Text, txtNote.Text, txtSlocBin.Text, dtpTgl.Value, "OnProcess");
                controllerManagement.objTitip.listtitipandetail = new List<CLsTitipanDetail>();

                // set SlocBin
                controllerManagement.objSlocBin = new ClsSlocBin(ClsStaticVariables.SlocBinID, cbxSloc.Text, TSFull.Checked, TSAvailable.Checked, false);
                controllerManagement.objSlocBin.listSlocBInDetail = new List<ClsSlocBinDetail>();
                // set Cls TitipanDetail & SlocBinDetail 
                foreach (DataGridViewRow row in dgvManagementDetail.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        controllerManagement.objTitipdetail = new CLsTitipanDetail(Convert.ToInt32(row.Cells["NoUrut"].Value), row.Cells["MaterialNumber"].Value.ToString() ?? "" , row.Cells["MaterialDescription"].Value.ToString() ?? " ", Convert.ToDecimal(row.Cells["Qty"].Value), row.Cells["Note"].Value.ToString() ?? " ", "OnProcess", (row.Cells["NoUrut"].Value.ToString() + row.Cells["Sloc"].Value.ToString()));
                        controllerManagement.objTitip.listtitipandetail.Add(controllerManagement.objTitipdetail);
                        controllerManagement.objSlocBInDetail = new ClsSlocBinDetail(ClsStaticVariables.SlocBinID, txtManagementID.Text, "Titip", dtpTgl.Value, row.Cells["MaterialNumber"].Value.ToString(), Convert.ToDecimal(row.Cells["Qty"].Value), row.Cells["BaseUnit"].Value.ToString() ?? "",  "",  "", ( row.Cells["NoUrut"].Value.ToString() + row.Cells["Sloc"].Value.ToString()));
                        controllerManagement.objSlocBin.listSlocBInDetail.Add(controllerManagement.objSlocBInDetail);
                    }

                }
                string proses = "";

                try
                {
                    proses += controllerManagement.InsertTitipan(controllerManagement.objTitip);
                    proses += controllerManagement.InsertTitipanDetail(controllerManagement.objTitip.listtitipandetail);
                    // Insert SlocBin Detail 
                    proses += controllerManagement.InsertSlocBinDetails(controllerManagement.objSlocBin.listSlocBInDetail) + "\n";
                    // Update SlocBin Status
                    proses += controllerManagement.UpdateSlocBinStatus(ClsStaticVariables.SlocBinID, cbxSloc.Text, TSFull.Checked, TSAvailable.Checked, TSEmpty.Checked) + "\n";
                    MessageBox.Show("Data Titipan Berhasil ditambah");
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Penambahan Data Titipan Gagal , proses = " + proses + "/n error Message = " + er.Message);
                }
            }
            else if(this.Tag.ToString() == "DELETE")
            {

            }
        }

        private void TSEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (TSEmpty.Checked)
            {
                TSFull.Checked = false;
                TSAvailable.Checked = false;
            }
        }

        private void TSAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (TSAvailable.Checked)
            {
                TSFull.Checked = false;
                TSEmpty.Checked = false;
            }
        }

        private void TSFull_CheckedChanged(object sender, EventArgs e)
        {
            if (TSFull.Checked)
            {
                TSAvailable.Checked = false;
                TSEmpty.Checked = false;
            }
        }

        private void dgvManagementDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = " " ;
            e.Row.Cells[2].Value = " ";
            e.Row.Cells[4].Value = "0";
            e.Row.Cells[5].Value = " ";
            e.Row.Cells[6].Value = " ";

        }

        private void dgvManagementDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvManagementDetail.CurrentCell.ColumnIndex == 4) //Desired Column 
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

        private void dgvManagementDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvManagementDetail.Columns[e.ColumnIndex].Name)
            {
                case "Select":
                    FormListItem frmListitem = new FormListItem();
                    frmListitem.Tag = "TitipanSearch";
                    frmListitem.ShowDialog();

                    int rowindex = dgvManagementDetail.Rows.Add();
                    dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = ClsStaticVariables.MaterialNumber;
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = ClsStaticVariables.MaterialDescription;
                    dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = 0;
                    dgvManagementDetail.Rows[rowindex].Cells["BaseUnit"].Value = ClsStaticVariables.BaseUnit;
                    dgvManagementDetail.Rows[rowindex].Cells["Note"].Value = "-";
                    dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = "0000";
                    break;
            }
        }
    }
}
