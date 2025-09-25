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
using QRCoder;
using CrystalDecisions.CrystalReports.Engine;
using Login.Reports;

namespace Login.View
{

    public partial class FormMaterial : Form
    {
        #region properties

        public ControllerMaterial controllerMaterial = new ControllerMaterial();
        BindingSource bindMats = new BindingSource();
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData;
        QRCode qrCode;
        Bitmap qrCodeImage;
        byte[] yourByteArray;
        public ReportDocument reportQRDoc2 = new ReportDocument();
        public string filepath = "";

        #endregion
        

        public FormMaterial()
        {
            InitializeComponent();
        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            bindMats.DataSource =  controllerMaterial.getAllMaterial();
            dgvMaterial.DataSource = bindMats;
            comboBox1.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
            {
                FormNEMaterial frmNEMaterial = new FormNEMaterial();
                frmNEMaterial.Text = "Add Material";
                frmNEMaterial.AccessibleDescription = "ADD";
                frmNEMaterial.btnAdd.AccessibleDescription = btnAdd.AccessibleDescription.ToString();
                frmNEMaterial.MdiParent = this.MdiParent;
                frmNEMaterial.ShowDialog();
                bindMats.DataSource = controllerMaterial.getAllMaterial();
            }
            else
            {
                MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvMaterial.Rows.Count != 0 )
            {
                if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
                {
                    FormNEMaterial frmNEMaterial = new FormNEMaterial(dgvMaterial.CurrentRow.Cells["Material_Number"].Value.ToString());
                    frmNEMaterial.Text = "Edit Material";
                    frmNEMaterial.AccessibleDescription = "EDIT";
                    frmNEMaterial.btnAdd.AccessibleDescription = btnAdd.AccessibleDescription.ToString();
                    frmNEMaterial.btnAdd.Text = "Edit";
                    frmNEMaterial.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Edit;
                    frmNEMaterial.MdiParent = this.MdiParent;
                    frmNEMaterial.ShowDialog();
                    bindMats.DataSource = controllerMaterial.getAllMaterial();
                }
                else
                {
                    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvMaterial.Rows.Count != 0)
            {
                if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
                {
                    if(Convert.ToDecimal(dgvMaterial.CurrentRow.Cells["Qty"].Value)<= 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data Sloc   " + dgvMaterial.CurrentRow.Cells["Material_Number"].Value.ToString() + " ? ", " Warning ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show(controllerMaterial.DeleteMaterial(dgvMaterial.CurrentRow.Cells["Material_Number"].Value.ToString()));
                        }
                        else if (dialogResult == DialogResult.No) { }
                        bindMats.DataSource = controllerMaterial.getAllMaterial();
                    }
                    else
                    {
                        MessageBox.Show("Qty Material masih belum 0 !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
                }
                
            }
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            qrGenerator = new QRCodeGenerator();

            qrCodeData = qrGenerator.CreateQrCode(dgvMaterial.CurrentRow.Cells["Material_Number"].Value.ToString() + "|| " + dgvMaterial.CurrentRow.Cells["Material_Description"].Value.ToString() , QRCodeGenerator.ECCLevel.Q);
            qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(5);


            using (var mStream = new System.IO.MemoryStream())
            {
                qrCodeImage.Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
                yourByteArray = mStream.ToArray();
            }

            DataSet ds = new DataSet();

            DataTable TblQRCode = new DataTable();
            TblQRCode.TableName = "TblQRCode";
            TblQRCode.Columns.Add("Material_Number", typeof(string));
            TblQRCode.Columns.Add("QRCode", typeof(byte[]));

            DataRow row = TblQRCode.NewRow();
            row["Material_Number"] = dgvMaterial.CurrentRow.Cells["Material_Number"].Value.ToString() + " || " + dgvMaterial.CurrentRow.Cells["Material_Description"].Value.ToString();
            row["QRCode"] = yourByteArray;
            TblQRCode.Rows.Add(row);

            ds.Tables.Add(TblQRCode);

            reportQRDoc2 = new PrintQRCodes();
            reportQRDoc2.SetDataSource(ds);

            FormReport frmReport = new FormReport(reportQRDoc2);
            frmReport.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Excel Files|*.xls;*.xlsx;";
                DialogResult dr = od.ShowDialog();
                if (dr == DialogResult.Abort)
                    return;
                if (dr == DialogResult.Cancel)
                    return;
                filepath = od.FileName.ToString();

                string tablematerial = "WareHouseMS.dbo.Material";
                string hasil1;
                this.Cursor = Cursors.WaitCursor;
                hasil1 = ClsStaticVariables.objConnection.objSqlServerIUDClass.ImportDataFromExcelMaterial(filepath, tablematerial, "Sheet1");
                MessageBox.Show(hasil1);
                this.Cursor = Cursors.Arrow;
                bindMats.DataSource = controllerMaterial.getAllMaterial();
            }
            else
            {
                MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bindMats.Filter = $"{comboBox1.Text.Trim().ToUpper()} like '%{textBox1.Text}%'";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindMats.Filter = $"{comboBox1.Text.Trim().ToUpper()} like '%{textBox1.Text}%'";
        }
    }
}
