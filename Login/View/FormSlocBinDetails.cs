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
using Login.Models;
using Master;
using QRCoder;
using CrystalDecisions.CrystalReports.Engine;
using Login.Reports;


namespace Login.View
{
    public partial class FormSlocBinDetails : Form
    {
        #region properties

        public ControllerSlocs controllerSloc = new ControllerSlocs();
        public BindingSource bindSlocbinDetail = new BindingSource();
        public string SlocBin = "";
        public ClsSlocBin objSlocBin = new ClsSlocBin();
        public ControllerManagement controllerManagement = new ControllerManagement();
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData;
        QRCode qrCode;
        Bitmap qrCodeImage;
        byte[] yourByteArray;
        public ReportDocument reportQRDoc2 = new ReportDocument();
        public DataTable dt = new DataTable();


        #endregion

        public FormSlocBinDetails()
        {
            InitializeComponent();
        }

        public FormSlocBinDetails(string SlocBIn)
        {
            InitializeComponent();
            this.SlocBin = SlocBIn;
            this.objSlocBin = controllerSloc.getOneSlocBin(SlocBin);
            if (ClsStaticVariables.status == "Full")
            {
                TSFull.Checked = true;
            }
            else if (ClsStaticVariables.status == "Empty")
            {
                TSEmpty.Checked = true;
            }
            else if (ClsStaticVariables.status == "Available")
            {
                TSAvailable.Checked = true;
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if(TSEmpty.Checked)
            {
                TSFull.Checked = false;
                TSAvailable.Checked = false;
                ClsStaticVariables.status = "Empty";
            }
        }

        private void TSAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if(TSAvailable.Checked)
            {
                TSFull.Checked = false;
                TSEmpty.Checked = false;
                ClsStaticVariables.status = "Available";
            }
        }

        private void TSFull_CheckedChanged(object sender, EventArgs e)
        {
            if(TSFull.Checked)
            {
                TSAvailable.Checked = false;
                TSEmpty.Checked = false;
                ClsStaticVariables.status = "Full";
            }
        }

        private void FormSlocBinDetails_Load(object sender, EventArgs e)
        {
            bindSlocbinDetail.DataSource = controllerManagement.getSlocBinDetails(SlocBin);
            dgvSlocBinDetail.DataSource = bindSlocbinDetail;
            lblSlocBin.Text = objSlocBin.SlocBin;
            lblSloc.Text = objSlocBin.Sloc;
            generateSlocQRCode();
        }

        private void btnMaterialEntry_Click(object sender, EventArgs e)
        {
            FormNEMaterialManagement frmNEMaterialManagement = new FormNEMaterialManagement("Entry", this.SlocBin);
            frmNEMaterialManagement.WindowState = FormWindowState.Maximized;
            frmNEMaterialManagement.ShowDialog();
            bindSlocbinDetail.DataSource = controllerManagement.getSlocBinDetails(SlocBin);
        }

        private void btnMaterialRequest_Click(object sender, EventArgs e)
        {
            if(dgvSlocBinDetail.Rows.Count !=0 )
            {
                if(!dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString().Contains("M.TT."))
                {
                    FormNEMaterialManagement2 frmNEMaterialManagement = new FormNEMaterialManagement2("Request", this.SlocBin);
                    frmNEMaterialManagement.WindowState = FormWindowState.Maximized;
                    frmNEMaterialManagement.ShowDialog();
                    bindSlocbinDetail.DataSource = controllerManagement.getSlocBinDetails(SlocBin);
                }
                else
                {
                    MessageBox.Show("Tidak ada Material untuk dikeluarkan atau Material tersebut merupakan material titipan");
                }
            }
        }

        public void generateSlocQRCode ()
        {
            qrGenerator = new QRCodeGenerator();

            qrCodeData = qrGenerator.CreateQrCode(this.SlocBin, QRCodeGenerator.ECCLevel.Q);
            qrCode = new QRCode(qrCodeData);
            
            qrCodeImage = qrCode.GetGraphic(5);

            
            using (var mStream = new System.IO.MemoryStream())
            {
                qrCodeImage.Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
                yourByteArray = mStream.ToArray();
            }
            pbSlocQR.Image = qrCodeImage;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            generateSlocQRCode();
            DataSet ds = new DataSet();

            DataTable TblQRCode = new DataTable();
            TblQRCode.TableName = "SlocBinQR";
            TblQRCode.Columns.Add("SlocBin", typeof(string));
            TblQRCode.Columns.Add("QRCode", typeof(byte[]));

            DataRow row = TblQRCode.NewRow();
            row["SlocBin"] = this.SlocBin;
            row["QRCode"] = yourByteArray;
            TblQRCode.Rows.Add(row);

            ds.Tables.Add(TblQRCode);

            reportQRDoc2 = new PrintSlocBinQRCode();
            reportQRDoc2.SetDataSource(ds);

            FormReport frmReport = new FormReport(reportQRDoc2);
            frmReport.ShowDialog();

        }

        private void btnViewQRMaterial_Click(object sender, EventArgs e)
        {
            
            List<Tuple<string,  string>> listData = new List<Tuple<string, string>>();
            string Data = "";
            string Data2 = "";

            dt = controllerManagement.getFullMaterialInfo(this.SlocBin);
            if(dt.Rows.Count!= 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Data = "SlocBin : " + dt.Rows[i]["SlocBin"].ToString() + "\n" +
                            "Material Number: " + dt.Rows[i]["Material_Number"].ToString() + "\n" +
                            "Material Description: " + dt.Rows[i]["Material_Description"].ToString() + "\n" +
                            "Tgl : " + dt.Rows[i]["Tgl"].ToString() + "\n" +
                            "Reservation Code: " + dt.Rows[i]["Reservation_Code"].ToString() + "\n" +
                            "PO / RO: " + dt.Rows[i]["PO_RO"].ToString() + "\n" +
                            "Work Order: " + dt.Rows[i]["WorkOrder"].ToString() + "\n" +
                            "Qty : " + dt.Rows[i]["Qty"].ToString() + "\n" +
                            "UOM : " + dt.Rows[i]["Base_Unit"].ToString();
                    Data2 = dt.Rows[i]["Material_Number"].ToString() + "||" + dt.Rows[i]["Material_Description"].ToString();
                    listData.Add(new Tuple<string, string> (Data2, Data));
                }
            }
            DataSet ds = new DataSet();

            DataTable TblQRCode = new DataTable();
            TblQRCode.TableName = "TblQRCode";
            TblQRCode.Columns.Add("Material_Number", typeof(string));
            TblQRCode.Columns.Add("QRCode", typeof(byte[]));
            TblQRCode.Columns.Add("Data", typeof(string));

            foreach (Tuple<string,string> x in listData)
            {
                qrGenerator = new QRCodeGenerator();

                qrCodeData = qrGenerator.CreateQrCode(x.Item1, QRCodeGenerator.ECCLevel.Q);
                qrCode = new QRCode(qrCodeData);
                qrCodeImage = qrCode.GetGraphic(5);

                using (var mStream = new System.IO.MemoryStream())
                {
                    qrCodeImage.Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
                    yourByteArray = mStream.ToArray();
                }

                DataRow row = TblQRCode.NewRow();
                row["Material_Number"] = x.Item1;
                row["QRCode"] = yourByteArray;
                row["Data"] = x.Item2;
                TblQRCode.Rows.Add(row);
            }

            ds.Tables.Add(TblQRCode); 

            reportQRDoc2 = new PrintQRCodeWithDetail();
            reportQRDoc2.SetDataSource(ds);

            FormReport frmReport = new FormReport(reportQRDoc2);
            frmReport.ShowDialog();
        }

        private void btnDPE_Click(object sender, EventArgs e)
        {
            ClsStaticVariables.SlocBinID = this.SlocBin;
            FormNETitipan frmNeTitipan = new FormNETitipan();
            frmNeTitipan.WindowState = FormWindowState.Maximized;
            frmNeTitipan.Tag = "ADD";
            frmNeTitipan.ShowDialog();
            bindSlocbinDetail.DataSource = controllerManagement.getSlocBinDetails(SlocBin);
        }

        private void btnDPR_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString().Contains("M.TT"))
                {
                    string currentID = dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data Titipan   " + dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString() + $" dan Material_Number = {dgvSlocBinDetail.CurrentRow.Cells["Material_Number"].Value.ToString()} dan Sloc = {dgvSlocBinDetail.CurrentRow.Cells["Sloc"].Value.ToString()}  ? ", " Warning ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            controllerManagement.DeleteTitipn(dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString(), this.SlocBin, dgvSlocBinDetail.CurrentRow.Cells["Material_Number"].Value.ToString(), dgvSlocBinDetail.CurrentRow.Cells["Sloc"].Value.ToString() );
                            //controllerOrder.CancelOrder(dgvOrder.CurrentRow.Cells["OrderID"].Value.ToString());
                            controllerManagement.UpdateStatusTitipanDetail(dgvSlocBinDetail.CurrentRow.Cells["Material_Number"].Value.ToString(), dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString(), dgvSlocBinDetail.CurrentRow.Cells["Sloc"].Value.ToString());
                            // Cek SlocbInDetail 
                            bool hapus = true;
                            dgvSlocBinDetail.EndEdit();
                            hapus = controllerManagement.cekTitipanDiSlocBIn(currentID);

                            if (hapus)
                            {
                                controllerManagement.UpdateStatusTitipan(currentID);
                            }
                            MessageBox.Show("Data Titipan Berhasil Dihapus");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Data gagal dihapus, ", ex.Message);
                        }


                    }
                    else if (dialogResult == DialogResult.No) { }
                }
                else
                {
                    MessageBox.Show("Baris yang dipilih bukan merupakan barang titipan !");
                }
                bindSlocbinDetail.DataSource = controllerManagement.getSlocBinDetails(SlocBin);
                if (dgvSlocBinDetail.Rows.Count == 0)
                {
                    controllerManagement.UpdateSlocBinStatus(this.SlocBin, lblSloc.Text, false, false, true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Tidak ada data titipan di Slocbin = {this.SlocBin} mohon di perikasa ulang !, error Message = " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(dgvSlocBinDetail.Rows.Count !=0 )
            {
                Image img = Image.FromFile(dgvSlocBinDetail.CurrentRow.Cells["FilePath"].Value.ToString());
                FormViewImage frmView = new FormViewImage(img);
                frmView.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<Tuple<string, string>> listData = new List<Tuple<string, string>>();
            string Data = "";
            string Data2 = "";

            dt = controllerManagement.getFullMaterialInfo(this.SlocBin);
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Data = "SlocBin : " + dt.Rows[i]["SlocBin"].ToString() + "\n" +
                            "Material Number: " + dt.Rows[i]["Material_Number"].ToString() + "\n" +
                            "Material Description: " + dt.Rows[i]["Material_Description"].ToString() + "\n" +
                            "Tgl : " + dt.Rows[i]["Tgl"].ToString() + "\n" +
                            "Reservation Code: " + dt.Rows[i]["Reservation_Code"].ToString() + "\n" +
                            "PO / RO: " + dt.Rows[i]["PO_RO"].ToString() + "\n" +
                            "Work Order: " + dt.Rows[i]["WorkOrder"].ToString() + "\n" +
                            "Qty : " + dt.Rows[i]["Qty"].ToString() + "\n" +
                            "UOM : " + dt.Rows[i]["Base_Unit"].ToString();
                    Data2 = dt.Rows[i]["Material_Number"].ToString() + "||" + dt.Rows[i]["Material_Description"].ToString();
                    listData.Add(new Tuple<string, string>(Data2, Data));
                }
            }
            DataSet ds = new DataSet();

            DataTable TblQRCode = new DataTable();
            TblQRCode.TableName = "TblQRCode";
            TblQRCode.Columns.Add("Material_Number", typeof(string));
            TblQRCode.Columns.Add("QRCode", typeof(byte[]));
            TblQRCode.Columns.Add("Data", typeof(string));

            foreach (Tuple<string, string> x in listData)
            {
                qrGenerator = new QRCodeGenerator();

                qrCodeData = qrGenerator.CreateQrCode(x.Item1, QRCodeGenerator.ECCLevel.Q);
                qrCode = new QRCode(qrCodeData);
                qrCodeImage = qrCode.GetGraphic(5);

                using (var mStream = new System.IO.MemoryStream())
                {
                    qrCodeImage.Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
                    yourByteArray = mStream.ToArray();
                }

                DataRow row = TblQRCode.NewRow();
                row["Material_Number"] = x.Item1;
                row["QRCode"] = yourByteArray;
                row["Data"] = x.Item2;
                TblQRCode.Rows.Add(row);
            }

            ds.Tables.Add(TblQRCode);

            reportQRDoc2 = new PrintStripMaterial();
            reportQRDoc2.SetDataSource(ds);

            FormReport frmReport = new FormReport(reportQRDoc2);
            frmReport.ShowDialog();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            // Update SlocBin Status
            MessageBox.Show(controllerManagement.UpdateSlocBinStatus(this.SlocBin, lblSloc.Text, TSFull.Checked, TSAvailable.Checked, TSEmpty.Checked));

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(dgvSlocBinDetail.Rows.Count != 0)
            {
                FormMaterialManagement frmMM = new FormMaterialManagement();
                frmMM.Text = "Material Management";
                FormTitipan frmTitipan = new FormTitipan();
                string managementid = dgvSlocBinDetail.CurrentRow.Cells["Management_ID"].Value.ToString();
                if (managementid.Contains("M.EN"))
                {
                    frmMM.cbxJenisManagement.SelectedIndex = 1;
                    frmMM.cbxJenis.SelectedIndex = 4;
                    frmMM.txtFind.Text = managementid;
                    frmMM.WindowState = FormWindowState.Maximized;
                    frmMM.ShowDialog();
                }
                else if (managementid.Contains("M.TT"))
                {
                    frmTitipan.cbxJenis.SelectedIndex = 2;
                    frmTitipan.txtFind.Text = managementid;
                    frmTitipan.WindowState = FormWindowState.Maximized;
                    frmTitipan.ShowDialog();
                }
                
            }
        }
    }
}
