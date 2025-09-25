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
    public partial class FormTitipan : Form
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
        public BindingSource bindTT = new BindingSource();
        public BindingSource bindTTdetail = new BindingSource();

        #endregion

        public FormTitipan()
        {
            InitializeComponent();
        }

        private void FormTitipan_Load(object sender, EventArgs e)
        {
            cbxJenis.SelectedIndex = 0;
            bindTT.DataSource = controllerManagement.getAlltitipan();
            dgvTitipan.DataSource = bindTT;
        }

        private void dgvTitipan_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvTitipan.Rows.Count!=0)
            {
                bindTTdetail.DataSource = controllerManagement.getAlltitipanDetail(dgvTitipan.CurrentRow.Cells["Titipan_ID"].Value.ToString());
                dgvTitipanDetail.DataSource = bindTTdetail;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            bindTT.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindTT.Filter = $"{cbxJenis.Text.Trim().ToUpper()} like '%{txtFind.Text}%'";

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgvTitipan.Rows.Count !=0)
            {
                reportQRDoc2 = new BonPenitipanBarang();
                reportQRDoc2.SetDataSource(controllerManagement.LoadTitipan(dgvTitipan.CurrentRow.Cells["Titipan_ID"].Value.ToString(), "OnProcess"));

                FormReport frmReport = new FormReport(reportQRDoc2);
                frmReport.WindowState = FormWindowState.Maximized;
                frmReport.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrintBonKeluar_Click(object sender, EventArgs e)
        {
            if (dgvTitipan.Rows.Count != 0)
            {
                if (dgvTitipan.Rows.Count != 0)
                {
                    reportQRDoc2 = new BonKeluarTitipan();
                    reportQRDoc2.SetDataSource(controllerManagement.LoadTitipan(dgvTitipan.CurrentRow.Cells["Titipan_ID"].Value.ToString(), "Done"));

                    FormReport frmReport = new FormReport(reportQRDoc2);
                    frmReport.WindowState = FormWindowState.Maximized;
                    frmReport.ShowDialog();
                }
            }
        }
    }
}
