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
    public partial class FormNEMaterialManagement2 : Form
    {
        #region properties

        public string ManagementType = "";
        public string SlocBinID = "";
        public ControllerManagement controllerManagement = new ControllerManagement();
        public ControllerSlocs controllerSloc = new ControllerSlocs();
        public DataTable dt = new DataTable();
        public DataGridView othr = new DataGridView();
        public string Pesan = "";
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

        public FormNEMaterialManagement2()
        {
            InitializeComponent();
        }

        public FormNEMaterialManagement2(string ManagementType, string SlocBinID)
        {
            InitializeComponent();
            if (ManagementType == "Request")
            {
                this.ManagementType = ManagementType;
                cbxManagementType.SelectedIndex = 1;
                cbxManagementType.Enabled = false;
                this.SlocBinID = SlocBinID;
                txtSlocBin.Text = this.SlocBinID;
                txtSlocBin.Enabled = false;
                TSFull.Enabled = false;
                //load data 
                loadDataInsideSlocBin();
                dgvManagementDetail.AllowUserToAddRows = false;


            }
        }

        public void loadDataInsideSlocBin()
        {
            dt = controllerManagement.getSlocBinDetails(this.SlocBinID);
            foreach (DataRow row in dt.Rows)
            {
                if(row["Management_ID"].ToString().Contains("M.EN."))
                {
                    int rowindex = dgvManagementDetail.Rows.Add();
                    dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                    dgvManagementDetail.Rows[rowindex].Cells["SlocBin"].Value = row["SlocBin"];
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = row["Material_Number"];
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = row["Material_Description"];
                    dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = 0;
                    dgvManagementDetail.Columns["Qty"].HeaderText = "Qty Request";
                    dgvManagementDetail.Rows[rowindex].Cells["QtyAlokasi"].Value = Convert.ToDecimal(Convert.ToSingle(row["QtyAlokasi"]));
                    dgvManagementDetail.Rows[rowindex].Cells["Reference"].Value = row["Reference"].ToString();
                    dgvManagementDetail.Rows[rowindex].Cells["UOM"].Value = row["Base_Unit"];
                    dgvManagementDetail.Rows[rowindex].Cells["Value"].Value = 0;
                    dgvManagementDetail.Rows[rowindex].Cells["Area"].Value = row["Area"];
                    dgvManagementDetail.Rows[rowindex].Cells["Equipment"].Value = row["Equipment"];
                    dgvManagementDetail.Rows[rowindex].Cells["Management_ID"].Value = row["Management_ID"];
                    dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = row["Sloc"];
                    dgvManagementDetail.Rows[rowindex].Cells["Equipment"].Value = row["Equipment"];
                    dgvManagementDetail.Rows[rowindex].Cells["Area"].Value = row["Area"];
                }
            }
        }

        private void FormNEMaterialManagement2_Load(object sender, EventArgs e)
        {
            dtpTgl.Value = DateTime.Now;
            // set cbxSloc
            this.setCbxSloc();
            cbxSloc.SelectedIndex = 0;
            if (this.ManagementType == "Request")
            {
                txtManagementID.Text = controllerManagement.AutoGenerateManagemetID("M.RQ");

            }
            string sloc = controllerManagement.getSloc(this.SlocBinID);
            for (int i = 0; i < cbxSloc.Items.Count; i++)
            {
                if (cbxSloc.Items[i].ToString() == sloc)
                {
                    cbxSloc.SelectedIndex = i;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSFull_CheckedChanged(object sender, EventArgs e)
        {
            if (TSFull.Checked)
            {
                TSAvailable.Checked = false;
                TSEmpty.Checked = false;
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

        private void TSEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (TSEmpty.Checked)
            {
                TSFull.Checked = false;
                TSAvailable.Checked = false;
            }
        }

        private void txtScanCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string[] split = txtScanCode.Text.Split('|', ' ');
                    // get One Material
                    ClsStaticVariables.tambah = false;
                    ClsStaticVariables.MaterialNumber = split[0];
                    FormListItem frmListitem = new FormListItem();
                    frmListitem.Tag = "MaterialSearch3";
                    frmListitem.ShowDialog();

                    if(ClsStaticVariables.tambah)
                    {
                        int rowindex = dgvManagementDetail.Rows.Add();
                        dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                        dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = ClsStaticVariables.MaterialNumber;
                        dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = ClsStaticVariables.MaterialDescription;
                        dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = 0;
                        dgvManagementDetail.Rows[rowindex].Cells["UOM"].Value = ClsStaticVariables.BaseUnit;
                        dgvManagementDetail.Rows[rowindex].Cells["Value"].Value = ClsStaticVariables.Value;
                        dgvManagementDetail.Rows[rowindex].Cells["Area"].Value = ClsStaticVariables.Area;
                        dgvManagementDetail.Rows[rowindex].Cells["Equipment"].Value = ClsStaticVariables.Equipment;
                        dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = ClsStaticVariables.Sloc;
                        dgvManagementDetail.Rows[rowindex].Cells["SlocBin"].Value = ClsStaticVariables.SlocBinID;
                        dgvManagementDetail.Rows[rowindex].Cells["Reference"].Value = ClsStaticVariables.Reference;
                        dgvManagementDetail.Rows[rowindex].Cells["Management_ID"].Value = ClsStaticVariables.ManagementID;
                        dgvManagementDetail.Rows[rowindex].Cells["QtyAlokasi"].Value = ClsStaticVariables.QtyAlokasi;
                    }

                    txtScanCode.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kode Material Number Salah atau tidak Ditemukan ! , error Message = " + ex.Message);
                }
            }
        }

        private void dgvManagementDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvManagementDetail.Columns[e.ColumnIndex].Name)
            {
                case "MaterialSearch":
                    ClsStaticVariables.tambah = false;
                    FormListItem frmListitem = new FormListItem();
                    frmListitem.Tag = "MaterialSearch2";
                    frmListitem.ShowDialog();

                    if (ClsStaticVariables.tambah)
                    {
                        int rowindex = dgvManagementDetail.Rows.Add();
                        dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                        dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = ClsStaticVariables.MaterialNumber;
                        dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = ClsStaticVariables.MaterialDescription;
                        dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = 0;
                        dgvManagementDetail.Rows[rowindex].Cells["UOM"].Value = ClsStaticVariables.BaseUnit;
                        dgvManagementDetail.Rows[rowindex].Cells["Value"].Value = ClsStaticVariables.Value;
                        dgvManagementDetail.Rows[rowindex].Cells["Area"].Value = ClsStaticVariables.Area;
                        dgvManagementDetail.Rows[rowindex].Cells["Equipment"].Value = ClsStaticVariables.Equipment;
                        dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = ClsStaticVariables.Sloc;
                        dgvManagementDetail.Rows[rowindex].Cells["SlocBin"].Value = ClsStaticVariables.SlocBinID;
                        dgvManagementDetail.Rows[rowindex].Cells["Reference"].Value = ClsStaticVariables.Reference;
                        dgvManagementDetail.Rows[rowindex].Cells["Management_ID"].Value = ClsStaticVariables.ManagementID;
                        dgvManagementDetail.Rows[rowindex].Cells["QtyAlokasi"].Value = ClsStaticVariables.QtyAlokasi;
                    }
                    break;
            }
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

        public bool validasi()
        {
            bool lanjut = true;

            foreach (DataGridViewRow row in dgvManagementDetail.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        string qty = row.Cells["Qty"].Value.ToString();
                        float realqty = Convert.ToSingle(qty);
                        if (realqty >= 0)
                        {
                            lanjut = true;
                        }
                        else
                        {
                            lanjut = false;
                            Pesan = "Qty harus >= =";
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Pesan = "Terjadi kesalahan Penginputan Data , error Message = " + ex.Message;
                    }
                }
            }

            return lanjut;
        }

        public void duplicatecheck2()
        {
            othr = dgvManagementDetail;
            for (int i = 0; i < othr.RowCount - 1; i++) //compare data
            {
                var Row = othr.Rows[i];
                string abc = Row.Cells["MaterialNumber"].Value.ToString().ToUpper();
                string sloc1 = Row.Cells["Sloc"].Value.ToString().ToUpper();
                string managementid1 = Row.Cells["Management_ID"].Value.ToString();

                for (int j = i + 1; j < othr.RowCount; j++)
                {
                    if (!othr.Rows[j].IsNewRow)
                    {
                        var Row2 = othr.Rows[j];
                        string def = Row2.Cells["MaterialNumber"].Value.ToString().ToUpper();
                        string sloc2 = Row2.Cells["Sloc"].Value.ToString().ToUpper();
                        string managementid2 = Row2.Cells["Management_ID"].Value.ToString();

                        if (abc == def && sloc1 == sloc2 && managementid1 == managementid2)
                        {
                            othr.Rows.Remove(Row2);
                            j--;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validasi inputan 
            if (validasi())
            {
                if (this.ManagementType == "Request")
                {
                    DataGridView tmp = dgvManagementDetail;


                    if (controllerManagement.checkStokGenerally(tmp))
                    {
                        // set Cls Management 
                        controllerManagement.clsMM = new ClsManagementMaterial(txtManagementID.Text, cbxManagementType.Text, dtpTgl.Value, txtReservationCode.Text ?? "", txtPORO.Text ?? "", txtWO.Text ?? "", txtNamaPenanggungJawab.Text ?? "", ClsStaticVariables.controllerUser.objUser.UserID, "OnProcess");
                        controllerManagement.clsMM.listMMatsDetails = new List<ClsMMaterialDetail>();

                        // set SlocBin
                        controllerManagement.objSlocBin = new ClsSlocBin(this.SlocBinID, cbxSloc.Text, TSFull.Checked, TSAvailable.Checked, false);
                        controllerManagement.objSlocBin.listSlocBInDetail = new List<ClsSlocBinDetail>();
                        controllerManagement.listKartuRayon = new List<ClsKartuRayon>();
                        // set Cls ManagementDetail & SlocBinDetail 
                        foreach (DataGridViewRow row in dgvManagementDetail.Rows)
                        {
                            if (!row.IsNewRow)
                            {

                                controllerManagement.objSlocBInDetail = new ClsSlocBinDetail(row.Cells["SlocBin"].Value.ToString(), row.Cells["Management_ID"].Value.ToString(), cbxManagementType.Text, dtpTgl.Value, row.Cells["MaterialNumber"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), row.Cells["UOM"].Value.ToString() ?? "", row.Cells["Area"].Value.ToString() ?? "", row.Cells["Equipment"].Value.ToString() ?? "", row.Cells["Sloc"].Value.ToString());
                                controllerManagement.objSlocBin.listSlocBInDetail.Add(controllerManagement.objSlocBInDetail);
                                controllerManagement.obMMAlloc = new ClsMaterialAllocation(txtManagementID.Text, row.Cells["MaterialNumber"].Value.ToString(), row.Cells["Reference"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), row.Cells["Sloc"].Value.ToString());
                                controllerManagement.listMMalloc.Add(controllerManagement.obMMAlloc);
                            }

                        }


                        string proses = "";

                        try
                        {

                            // Insert ClsManagement
                            proses += controllerManagement.InsertManagementWithStatus(controllerManagement.clsMM) + "\n";
                            // stock check specifically Update or Delete
                            proses += controllerManagement.UpdateorDeleteAllocation(tmp) + "\n";
                            proses += controllerManagement.UpdateorDeleteSlocBinDetails(controllerManagement.objSlocBin.listSlocBInDetail) + "\n";

                            this.duplicatecheck2();

                            foreach (DataGridViewRow row in othr.Rows)
                            {
                                if (this.cbxManagementType.Text == "Request")
                                {
                                    if (!row.IsNewRow)
                                    {
                                        controllerManagement.clsMMDetail = new ClsMMaterialDetail(txtManagementID.Text, Convert.ToInt32(row.Cells["NoUrut"].Value), row.Cells["MaterialNumber"].Value.ToString(), Convert.ToDecimal(row.Cells["Qty"].Value.ToString()), row.Cells["UOM"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Value"].Value)), "Problem", row.Cells["Sloc"].Value.ToString(), row.Cells["Reference"].Value.ToString());
                                        controllerManagement.clsMM.listMMatsDetails.Add(controllerManagement.clsMMDetail);
                                        controllerManagement.ClsKartuRayon = new ClsKartuRayon(row.Cells["MaterialNumber"].Value.ToString(), DateTime.Now, txtManagementID.Text, cbxManagementType.Text, txtReservationCode.Text ?? "", txtPORO.Text ?? "", txtWO.Text ?? "", 0, Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), (0 - Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value))), 0, 0, 0, txtNote.Text, Convert.ToDecimal(row.Cells["Value"].Value), row.Cells["Sloc"].Value.ToString());
                                        controllerManagement.listKartuRayon.Add(controllerManagement.ClsKartuRayon);
                                    }
                                }
                            }



                            // Insert Management Detail
                            proses += controllerManagement.insertManagementDetail(controllerManagement.clsMM.listMMatsDetails) + "\n";
                            // Insert Kartu Rayon 
                            proses += controllerManagement.InsertDataKartuRayon(controllerManagement.listKartuRayon) + "\n";
                            //cek SlocBinStatus 
                            if (controllerManagement.cekSlocBinCount(this.SlocBinID) == "Available")
                            {
                                TSAvailable.Checked = true;
                            }
                            else if (controllerManagement.cekSlocBinCount(this.SlocBinID) == "Empty")
                            {
                                TSEmpty.Checked = true;
                            }
                            // Update SlocBin Status
                            proses += controllerManagement.UpdateSlocBinStatus(this.SlocBinID, cbxSloc.Text, TSFull.Checked, TSAvailable.Checked, TSEmpty.Checked) + "\n";

                            //// Update Material Qty Value 
                            //proses += controllerManagement.UpdateQtyMaterials(controllerManagement.listKartuRayon) + "\n";
                            MessageBox.Show("Data Material Request Berhasil ditambah");
                            this.Close();
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Penambahan Data Material Request Gagal , proses = " + proses + "/n error Message = " + er.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stok Material di SlocBin " + this.SlocBinID + " tidak cukup untuk memproses material request ini, silahkan di cek kembali ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Terjadi Kesalahan Inputan !! Mohon diperiksa data inputan terlebih dahulu, pesan = ");
            }
        }
    }
}
