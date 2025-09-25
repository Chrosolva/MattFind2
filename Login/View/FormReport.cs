using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Login.View
{
    public partial class FormReport : Form
    {
        #region properties

        ReportDocument reportdoc = new ReportDocument();

        #endregion

        public FormReport()
        {
            InitializeComponent();
        }


        public FormReport(ReportDocument reportDoc)
        {
            InitializeComponent();
            this.reportdoc = reportDoc;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            crViewer.ReportSource = reportdoc;
        }
    }
}
