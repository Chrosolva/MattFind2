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
using Excel = Microsoft.Office.Interop.Excel;


namespace Login.View
{
    public partial class FormTKartuRayon : Form
    {

        #region properties

        public ControllerManagement controllerManagement = new ControllerManagement();
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData;
        QRCode qrCode;
        Bitmap qrCodeImage;
        byte[] yourByteArray;
        public ReportDocument reportQRDoc2 = new ReportDocument();
        public DataTable dt = new DataTable();
        public BindingSource bindKR = new BindingSource();

        #endregion

        public FormTKartuRayon()
        {
            InitializeComponent();
        }

        private void txtScanCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string[] split = txtScanCode.Text.Split('|', ' ');
                    // get Kartu Rayon per Material Number
                    bindKR.DataSource = controllerManagement.GetKartuRayon(split[0]);
                    dgvKartuRayon.DataSource = bindKR;
                    ClsStaticVariables.MaterialNumber = txtScanCode.Text;
                    lblSelected.Text = "Selected : " + txtScanCode.Text;
                    txtScanCode.Text = ""; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kode Material Number Salah atau tidak Ditemukan ! , error Message = " + ex.Message);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormListItem frmListitem = new FormListItem();
            frmListitem.Tag = "MaterialSearch";
            frmListitem.ShowDialog();

            lblSelected.Text = "Selected : " + ClsStaticVariables.MaterialNumber;
            bindKR.DataSource = controllerManagement.GetKartuRayon(ClsStaticVariables.MaterialNumber);
            dgvKartuRayon.DataSource = bindKR;
        }

        private void FormTKartuRayon_Load(object sender, EventArgs e)
        {
            txtScanCode.Focus();
            btnRefresh_Click(sender, e);
        }

        private void dgvKartuRayon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bindKR.DataSource = controllerManagement.GetALLKartuRayon();
            dgvKartuRayon.DataSource = bindKR;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ExcelFilePath = "C:\\WareHouseMS\\KartuRayonExport" + DateTime.Now.ToShortDateString().Replace('/', '-') + ".xlsx";
            DataTable dt = controllerManagement.GetALLKartuRayon();
            ExportToExcel(dt, ExcelFilePath);
        }

        public static void ExportToExcel(DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }
}
