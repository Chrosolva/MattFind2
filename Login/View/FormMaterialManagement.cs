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
    public partial class FormMaterialManagement : Form
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
        public BindingSource bindMM = new BindingSource();
        public BindingSource bindMMdetail = new BindingSource();
        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook excelworkBook;
        Microsoft.Office.Interop.Excel.Worksheet excelSheet;
        Microsoft.Office.Interop.Excel.Range excelCellrange;

        #endregion

        public FormMaterialManagement()
        {
            InitializeComponent();
        }

        public void setdgvMM ()
        {
            bindMM.DataSource = controllerManagement.getManagement(cbxJenisManagement.Text, (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));
            dgvMaterialManagement.DataSource = bindMM;
        }

        private void FormMaterialManagement_Load(object sender, EventArgs e)
        {
            if (DateTime.Today.Month < 3)
                dtpMulai.Value = Convert.ToDateTime("1/1/" + ClsStaticVariables.tahun.ToString());
            else
                dtpMulai.Value = DateTime.Now.AddMonths(-4);
            dtpSampai.Value = DateTime.Today;
            cbxJenisManagement.SelectedIndex = 1;
            setdgvMM();
            cbxJenis.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;
            
            
        }

        private void dgvMaterialManagement_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvMaterialManagement.Rows.Count != 0)
            {
                bindMMdetail.DataSource = controllerManagement.getManagementDetail(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString());
                dgvMMDetail.DataSource = bindMMdetail;
                foreach(DataGridViewColumn col in dgvMMDetail.Columns)
                {
                    if(col.HeaderText == "Select")
                    {
                        col.ReadOnly = false;
                        col.Width = 50;
                    }
                    else
                    {
                        col.ReadOnly = true;
                    }
                }
            }
        }

        private void cbxJenisManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            setdgvMM();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgvMaterialManagement.Rows.Count > 0)
            {
                if (dgvMaterialManagement.CurrentRow.Cells["Management_Type"].Value.ToString() == "Entry")
                {

                }
                else if(dgvMaterialManagement.CurrentRow.Cells["Management_Type"].Value.ToString() == "Request")
                {
                    reportQRDoc2 = new BonPengeluaranBarang();
                    reportQRDoc2.SetDataSource(controllerManagement.LoadMaterialRequest(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString()));

                    FormReport frmReport = new FormReport(reportQRDoc2);
                    frmReport.ShowDialog();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindMM.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            bindMM.Filter = $"{cbxJenis.Text.Trim()} like '%{txtFind.Text}%'";

        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if(dgvMaterialManagement.Rows.Count != 0)
            {
                if (cbxJenisManagement.Text == "Entry")
                {
                    MessageBox.Show("Data Material Entry tidak memiliki status untuk diubah !");
                }
                else if (cbxJenisManagement.Text == "Request")
                {
                    List<Tuple<string, string>> listData = new List<Tuple<string, string>>();
                    string Data = "";
                    string Data2 = "";

                    // get All checked 
                    foreach (DataGridViewRow row in dgvMMDetail.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells["Select"].Value))
                        {
                            Data = row.Cells["Management_ID"].Value.ToString();
                            Data2 = row.Cells["Material_Number"].Value.ToString();
                            listData.Add(new Tuple<string, string>(Data, Data2));
                        }
                    }


                    FormChangeStatusMM frmChangestatus = new FormChangeStatusMM(listData);
                    frmChangestatus.ShowDialog();
                    bindMM.DataSource = controllerManagement.getManagement(cbxJenisManagement.Text, (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));


                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Filter 
            setdgvMM();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnFilter_Click(sender, e);
        }

        private void btnSlocBinDetail_Click(object sender, EventArgs e)
        {
            if(dgvMaterialManagement.CurrentRow.Cells["Management_Type"].Value.ToString() == "Entry" )
            {
                if (dgvMMDetail.CurrentRow.Cells["SlocBin"].Value.ToString().Trim().Equals('-'))
                {
                    MessageBox.Show("Material sudah keluar dari SlocBin");
                }
                else
                {
                    FormSlocBinDetails frmSlocBinDetails = new FormSlocBinDetails(dgvMMDetail.CurrentRow.Cells["SlocBin"].Value.ToString());
                    frmSlocBinDetails.WindowState = FormWindowState.Maximized;
                    frmSlocBinDetails.ShowDialog();

                    setdgvMM();
                }
            }
            else
            {
                MessageBox.Show("Material Request tidak memiliki SlocBin ID");
            }
        }

        private void dgvMMDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //// Start Excel and get Application object.  
            //excel = new Microsoft.Office.Interop.Excel.Application();
            //// for making Excel visible  
            //excel.Visible = false;
            //excel.DisplayAlerts = false;
            //// Creation a new Workbook  
            //excelworkBook = excel.Workbooks.Add(Type.Missing);
            //// Workk sheet  
            //excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            //excelSheet.Name = "Material Management";
            //excelSheet.Cells[1, 1] = "Material Management Export";
            //excelSheet.Cells[1, 2] = "Date : " + (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay).ToString() + " to " + (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay).ToString();
            //string type = "";
            //if(cbxJenisManagement.Text == "ALL")
            //{
            //    type = "%%";
            //}
            //else
            //{
            //    type = "%" + cbxJenisManagement.Text + "%";
            //}
            //DataTable dt = controllerManagement.LoadAllMaterialManagement(type, (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));
            //// now we resize the columns  
            //excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[dt.Rows.Count, dt.Columns.Count]];
            //excelCellrange.EntireColumn.AutoFit();
            //Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
            //border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            //border.Weight = 2d;'

            string type = "";
            if (cbxJenisManagement.Text == "ALL")
            {
                type = "%%";
            }
            else
            {
                type = "%" + cbxJenisManagement.Text + "%";
            }

            string ExcelFilePath = "C:\\WareHouseMS\\MaterialManagementExport" + dtpMulai.Value.ToShortDateString().Replace('/','-') + " sd " + dtpSampai.Value.ToShortDateString().Replace('/','-') + ".xlsx";
            DataTable dt = controllerManagement.LoadAllMaterialManagement(type, (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));
            ExportToExcel(dt, ExcelFilePath);


        }

        public static void ExportToExcel( DataTable tbl, string excelFilePath = null)
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

        public void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") )
            {
                if(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString().Contains("M.RQ"))
                {
                    MessageBox.Show("Material Request tidak dapat dicancel , silahkan masukkan kembali material menggunakan material entry !!");
                }
                else if(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString().Contains("M.EN"))
                {
                    if(dgvMaterialManagement.CurrentRow.Cells["Status"].Value.Equals("Cancelled"))
                    {
                        MessageBox.Show("Data Transaksi sudah di batalkan");
                    }
                    else
                    {
                        // cek Last Transaction 
                        if (controllerManagement.cekLastTransaction(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString()))
                        {
                            try
                            {
                                // Update Material Qty 
                                controllerManagement.UpdateQtyMaterial(dgvMMDetail);
                                // Update Status Management Entry 
                                //Update status Management Detail
                                controllerManagement.UpdateAllMaterialEntryStatus(dgvMMDetail);

                                // Delete Material Allocation
                                controllerManagement.DeleteMaterialAllocation(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString());

                                // Delete SlocBin Detail
                                controllerManagement.DeleteAllSlocBinDetails(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString());

                                // Delete Kartu Rayon
                                controllerManagement.DeleteKartuRayon(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString());

                                MessageBox.Show("Data transaksi berhasil dibatalkan !!");
                                bindMM.DataSource = controllerManagement.getManagement(cbxJenisManagement.Text, (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Terjadi kesalahan pada pembatalan transaksi, hubungi teknisi IT anda , error Message = " + ex.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Transaksi tidak dapat dibatalkan karena bukan transaksi terakhir !!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            }
        }
    }
}
