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
    public partial class FormNEMaterialManagement : Form
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

        public FormNEMaterialManagement()
        {
            InitializeComponent();
        }

        public FormNEMaterialManagement(string ManagementType, string SlocBinID)
        {
            InitializeComponent();
            if (ManagementType == "Entry")
            {
                this.ManagementType = ManagementType;
                cbxManagementType.SelectedIndex = 0;
                cbxManagementType.Enabled = false;
                this.SlocBinID = SlocBinID;
                txtSlocBin.Text = this.SlocBinID;
                txtSlocBin.Enabled = false;
                TSEmpty.Enabled = false;
                dgvManagementDetail.AllowUserToAddRows = true;

            }
            else if (ManagementType == "Request")
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
            //else if (ManagementType == "Deposit Entry")
            //{
            //    this.ManagementType = ManagementType;
            //    cbxManagementType.SelectedIndex = 2;
            //    cbxManagementType.Enabled = false;
            //    this.SlocBinID = SlocBinID;
            //    txtSlocBin.Text = this.SlocBinID;
            //    txtSlocBin.Enabled = false;
            //    TSEmpty.Enabled = false;
            //}
            //else if(ManagementType == "Deposit Request")
            //{
            //    this.ManagementType = ManagementType;
            //    cbxManagementType.SelectedIndex = 3;
            //    cbxManagementType.Enabled = false;
            //    this.SlocBinID = SlocBinID;
            //    txtSlocBin.Text = this.SlocBinID;
            //    txtSlocBin.Enabled = false;
            //    TSFull.Enabled = false;
            //}

        }

        public void loadDataInsideSlocBin()
        {
            dt = controllerManagement.getSlocBinDetails(this.SlocBinID);
            foreach (DataRow row in dt.Rows)
            {
                int rowindex = dgvManagementDetail.Rows.Add();
                dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
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
                    dgvManagementDetail.Rows[rowindex].Cells["UOM"].Value = ClsStaticVariables.BaseUnit;
                    dgvManagementDetail.Rows[rowindex].Cells["Value"].Value = ClsStaticVariables.Value;
                    dgvManagementDetail.Rows[rowindex].Cells["Area"].Value = "";
                    dgvManagementDetail.Rows[rowindex].Cells["Equipment"].Value = "";
                    dgvManagementDetail.Rows[rowindex].Cells["Sloc"].Value = "K5GM";
                    break;
            }
        }

        private void FormNEMaterialManagement_Load(object sender, EventArgs e)
        {
            dtpTgl.Value = DateTime.Now;
            // set cbxSloc
            this.setCbxSloc();
            cbxSloc.SelectedIndex = 0;
            if (this.ManagementType == "Entry")
            {
                txtManagementID.Text = controllerManagement.AutoGenerateManagemetID("M.EN");
                TSAvailable.Checked = true;
                dgvManagementDetail.Columns["QtyAlokasi"].Visible = false;
                dgvManagementDetail.Columns["Reference"].Visible = false;
            }
            else if (this.ManagementType == "Request")
            {
                txtManagementID.Text = controllerManagement.AutoGenerateManagemetID("M.RQ");

            }
            else if (this.ManagementType == "Deposit Entry")
            {
                txtManagementID.Text = controllerManagement.AutoGenerateManagemetID("M.DE");
            }
            else if (this.ManagementType == "Deposit Request")
            {
                txtManagementID.Text = controllerManagement.AutoGenerateManagemetID("M.DR");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validasi inputan 
            if (validasi())
            {
                if (this.ManagementType == "Entry")
                {
                    // combine duplicate 
                    this.duplicate_check();
                    // set Cls Management 
                    controllerManagement.clsMM = new ClsManagementMaterial(txtManagementID.Text, cbxManagementType.Text, dtpTgl.Value, txtReservationCode.Text ?? "", txtPORO.Text ?? "", txtWO.Text ?? "", txtNamaPenanggungJawab.Text ?? "", ClsStaticVariables.controllerUser.objUser.UserID);
                    controllerManagement.clsMM.listMMatsDetails = new List<ClsMMaterialDetail>();

                    // set SlocBin
                    controllerManagement.objSlocBin = new ClsSlocBin(this.SlocBinID, cbxSloc.Text, TSFull.Checked, TSAvailable.Checked, false);
                    controllerManagement.objSlocBin.listSlocBInDetail = new List<ClsSlocBinDetail>();
                    controllerManagement.listKartuRayon = new List<ClsKartuRayon>();
                    controllerManagement.listMMalloc = new List<ClsMaterialAllocation>();
                    // Set Reference for Allocation 
                    string reftmp = "";
                    if (txtReservationCode.Text.Trim() != "")
                    {
                        reftmp += "Reservation = " + txtReservationCode.Text;
                    }
                    if (txtPORO.Text.Trim() != "")
                    {
                        reftmp += "PO/RO = " + txtPORO.Text;
                    }
                    if (txtWO.Text.Trim() != "")
                    {
                        reftmp += "WO = " + txtWO.Text;
                    }
                    if (txtReservationCode.Text.Trim() == "" && txtPORO.Text.Trim() == "" && txtWO.Text.Trim() == "")
                    {
                        reftmp = "z~Free Stock";
                    }

                    // set Cls ManagementDetail & SlocBinDetail 
                    foreach (DataGridViewRow row in dgvManagementDetail.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            
                            controllerManagement.clsMMDetail = new ClsMMaterialDetail(txtManagementID.Text, Convert.ToInt32(row.Cells["NoUrut"].Value), row.Cells["MaterialNumber"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), row.Cells["UOM"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Value"].Value)), row.Cells["Sloc"].Value.ToString());
                            controllerManagement.clsMM.listMMatsDetails.Add(controllerManagement.clsMMDetail);
                            controllerManagement.objSlocBInDetail = new ClsSlocBinDetail(this.SlocBinID, txtManagementID.Text, cbxManagementType.Text, dtpTgl.Value, row.Cells["MaterialNumber"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), row.Cells["UOM"].Value.ToString() ?? "", row.Cells["Area"].Value.ToString() ?? "", row.Cells["Equipment"].Value.ToString() ?? "", row.Cells["Sloc"].Value.ToString());
                            controllerManagement.objSlocBin.listSlocBInDetail.Add(controllerManagement.objSlocBInDetail);
                            if (this.cbxManagementType.Text == "Entry")
                            {
                                controllerManagement.ClsKartuRayon = new ClsKartuRayon(row.Cells["MaterialNumber"].Value.ToString(), DateTime.Now, txtManagementID.Text, cbxManagementType.Text, txtReservationCode.Text ?? "", txtPORO.Text ?? "", txtWO.Text ?? "", Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), 0, (0 + Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value).ToString("F"))), 0, 0, 0, txtNote.Text, Convert.ToDecimal(Convert.ToSingle(row.Cells["Value"].Value)), row.Cells["Sloc"].Value.ToString());
                                controllerManagement.listKartuRayon.Add(controllerManagement.ClsKartuRayon);

                                controllerManagement.obMMAlloc = new ClsMaterialAllocation(txtManagementID.Text, row.Cells["MaterialNumber"].Value.ToString(), reftmp, Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), row.Cells["Sloc"].Value.ToString());
                                controllerManagement.listMMalloc.Add(controllerManagement.obMMAlloc);
                            }

                        }

                    }
                    string proses = "";

                    try
                    {
                        // Insert ClsManagement
                        proses += controllerManagement.InsertManagement(controllerManagement.clsMM) + "\n";
                        // Insert Management Detail
                        proses += controllerManagement.insertManagementDetail(controllerManagement.clsMM.listMMatsDetails) + "\n";
                        // Insert Material Allocation
                        proses += controllerManagement.InsertManagementAllocation(controllerManagement.listMMalloc) + "\n";
                        // Insert Kartu Rayon 
                        proses += controllerManagement.InsertDataKartuRayon(controllerManagement.listKartuRayon) + "\n";
                        // Insert SlocBin Detail 
                        proses += controllerManagement.InsertSlocBinDetails(controllerManagement.objSlocBin.listSlocBInDetail) + "\n";
                        // Update SlocBin Status
                        proses += controllerManagement.UpdateSlocBinStatus(this.SlocBinID, cbxSloc.Text, TSFull.Checked, TSAvailable.Checked, TSEmpty.Checked) + "\n";
                        //// Update Material Qty Value 
                        //proses += controllerManagement.UpdateQtyMaterials(controllerManagement.listKartuRayon) + "\n";
                        MessageBox.Show("Data Material Entry Berhasil ditambah");
                        this.Close();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Penambahan Data Material Entry Gagal , proses = " + proses + "/n error Message = " + er.Message);
                    }
                }
                else if (this.ManagementType == "Request")
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

                                controllerManagement.objSlocBInDetail = new ClsSlocBinDetail(this.SlocBinID, row.Cells["Management_ID"].Value.ToString(), cbxManagementType.Text, dtpTgl.Value, row.Cells["MaterialNumber"].Value.ToString(), Convert.ToDecimal(Convert.ToSingle(row.Cells["Qty"].Value)), row.Cells["UOM"].Value.ToString() ?? "", row.Cells["Area"].Value.ToString() ?? "", row.Cells["Equipment"].Value.ToString() ?? "", row.Cells["Sloc"].Value.ToString());
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

        private void txtScanCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                try
                {
                    string[] split = txtScanCode.Text.Split('|', ' ');
                    // get One Material
                    dt = controllerManagement.getOneMaterial(split[0]);

                    int rowindex = dgvManagementDetail.Rows.Add();
                    dgvManagementDetail.Rows[rowindex].Cells["NoUrut"].Value = rowindex + 1;
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialNumber"].Value = dt.Rows[0]["Material_Number"].ToString();
                    dgvManagementDetail.Rows[rowindex].Cells["MaterialDescription"].Value = dt.Rows[0]["Material_Description"].ToString();
                    dgvManagementDetail.Rows[rowindex].Cells["Qty"].Value = 0;
                    dgvManagementDetail.Rows[rowindex].Cells["UOM"].Value = dt.Rows[0]["Base_Unit"].ToString();
                    dgvManagementDetail.Rows[rowindex].Cells["Value"].Value = Convert.ToDecimal(Convert.ToSingle(dt.Rows[0]["Value"]));
                    dgvManagementDetail.Rows[rowindex].Cells["Area"].Value = "";
                    dgvManagementDetail.Rows[rowindex].Cells["Equipment"].Value = "";

                    txtScanCode.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kode Material Number Salah atau tidak Ditemukan ! , error Message = " + ex.Message);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        public void duplicate_check()
        {
            for (int i = 0; i < dgvManagementDetail.RowCount - 1; i++) //compare data
            {
                var Row = dgvManagementDetail.Rows[i];
                string abc = Row.Cells["MaterialNumber"].Value.ToString().ToUpper();
                string sloc1 = Row.Cells["Sloc"].Value.ToString().ToUpper();

                for (int j = i + 1; j < dgvManagementDetail.RowCount; j++)
                {
                    if (!dgvManagementDetail.Rows[j].IsNewRow)
                    {
                        var Row2 = dgvManagementDetail.Rows[j];
                        string def = Row2.Cells["MaterialNumber"].Value.ToString().ToUpper();
                        string sloc2 = Row2.Cells["Sloc"].Value.ToString().ToUpper();
                        if (abc == def && sloc1 == sloc2)
                        {
                            if (Row.Cells["Area"].Value.ToString().Trim() != "" || Row2.Cells["Area"].Value.ToString().Trim() != "")
                            {
                                Row.Cells["Area"].Value = Row.Cells["Area"].Value.ToString() + " , " + Row2.Cells["Area"].Value.ToString();
                            }
                            if (Row.Cells["Equipment"].Value.ToString().Trim() != "" || Row2.Cells["Equipment"].Value.ToString().Trim() != "")
                            {
                                Row.Cells["Equipment"].Value = Row.Cells["Equipment"].Value.ToString() + " | " + Row2.Cells["Equipment"].Value.ToString();
                            }
                            Row.Cells["Qty"].Value = Convert.ToSingle(Row.Cells["Qty"].Value) + Convert.ToSingle(Row2.Cells["Qty"].Value);
                            dgvManagementDetail.Rows.Remove(Row2);
                            j--;
                        }
                    }
                }
            }
        }

        public void duplicatecheck2()
        {
            othr = dgvManagementDetail;
            for (int i = 0; i < othr.RowCount - 1; i++) //compare data
            {
                var Row = othr.Rows[i];
                string abc = Row.Cells["MaterialNumber"].Value.ToString().ToUpper();
                string sloc1 = Row.Cells["Sloc"].Value.ToString().ToUpper();

                for (int j = i + 1; j < othr.RowCount; j++)
                {
                    if (!othr.Rows[j].IsNewRow)
                    {
                        var Row2 = othr.Rows[j];
                        string def = Row2.Cells["MaterialNumber"].Value.ToString().ToUpper();
                        string sloc2 = Row2.Cells["Sloc"].Value.ToString().ToUpper();
                        if (abc == def && sloc1 == sloc2)
                        {
                            if (Row.Cells["Area"].Value.ToString().Trim() != "" || Row2.Cells["Area"].Value.ToString().Trim() != "")
                            {
                                Row.Cells["Area"].Value = Row.Cells["Area"].Value.ToString() + " , " + Row2.Cells["Area"].Value.ToString();
                            }
                            if (Row.Cells["Equipment"].Value.ToString().Trim() != "" || Row2.Cells["Equipment"].Value.ToString().Trim() != "")
                            {
                                Row.Cells["Equipment"].Value = Row.Cells["Equipment"].Value.ToString() + " | " + Row2.Cells["Equipment"].Value.ToString();
                            }
                            if (Row.Cells["Reference"].Value.ToString().Trim() != "" || Row2.Cells["Reference"].Value.ToString().Trim() != "")
                            {
                                Row.Cells["Reference"].Value = Row.Cells["Reference"].Value.ToString() + " | " + Row2.Cells["Reference"].Value.ToString();
                            }
                            Row.Cells["Qty"].Value = Convert.ToSingle(Row.Cells["Qty"].Value) + Convert.ToSingle(Row2.Cells["Qty"].Value);
                            othr.Rows.Remove(Row2);
                            j--;
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
