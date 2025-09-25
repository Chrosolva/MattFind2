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
    public partial class FormMaterialAllocation : Form
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
        public DataSet ds = new DataSet();
        public BindingSource bindMM = new BindingSource();
        public BindingSource bindMMdetail = new BindingSource();

        #endregion
        public FormMaterialAllocation()
        {
            InitializeComponent();
        }

        private void FormMaterialAllocation_Load(object sender, EventArgs e)
        {
            if (DateTime.Today.Month < 3)
                dtpMulai.Value = Convert.ToDateTime("1/1/" + ClsStaticVariables.tahun.ToString());
            else
                dtpMulai.Value = DateTime.Now.AddMonths(-4);
            dtpSampai.Value = DateTime.Today;
            setdgvMM();
        }

        public void setdgvMM()
        {
            bindMM.DataSource = controllerManagement.getManagement("Entry", (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));
            dgvMaterialManagement.DataSource = bindMM;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            ds = controllerManagement.LoadMaterialAllocationGlobal();
            reportQRDoc2 = new ReportPencadanganMaterial();
            reportQRDoc2.SetDataSource(ds);

            FormReport frmReport = new FormReport(reportQRDoc2);
            frmReport.ShowDialog();
        }

        private void btnSlocBinDetail_Click(object sender, EventArgs e)
        {

        }

        private void dgvMaterialManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaterialManagement.Rows.Count != 0)
            {
                bindMMdetail.DataSource = controllerManagement.getManagementAllocation(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString());
                dgvMMAllocation.DataSource = bindMMdetail;
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormNEMaterialAllocation frmNEMA = new FormNEMaterialAllocation();
            frmNEMA.WindowState = FormWindowState.Maximized;
            frmNEMA.ShowDialog();
            if(dgvMaterialManagement.Rows.Count !=0)
            {
                bindMMdetail.DataSource = controllerManagement.getManagementAllocation(dgvMaterialManagement.CurrentRow.Cells["Management_ID"].Value.ToString());
            }
            dgvMMAllocation.DataSource = bindMMdetail;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bindMM.DataSource = controllerManagement.getManagement("Entry", (dtpMulai.Value.Date + dtpStartTime.Value.TimeOfDay), (dtpSampai.Value.Date + dtpEndTime.Value.TimeOfDay));
            dgvMaterialManagement.DataSource = bindMM;
        }
    }
}
