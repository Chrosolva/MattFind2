using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CrystalDecisions.CrystalReports.Engine;

namespace DEPTHCHK.Views
{
    public partial class ReportViewer : MaterialForm
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        public void LoadReport(ReportDocument report)
        {
            crViewer.ReportSource = report;
            crViewer.Refresh();
        }
    }
}
