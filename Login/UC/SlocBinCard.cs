using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.View;
using Login.Controller;

namespace Login.UC
{
    public partial class SlocBinCard : UserControl
    {
        public SlocBinCard()
        {
            InitializeComponent();
        }

        public SlocBinCard(string SlocBin, string Status)
        {
            InitializeComponent();
            this.SlocBin = SlocBin;
            this.Status = Status;
        }

        #region properties

        public string SlocBin = "";
        public string Status = "";
        public ControllerManagement controllerManagement = new ControllerManagement();


        #endregion

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormSlocBinDetails frmSlocBinDetails = new FormSlocBinDetails(SlocBin);
            frmSlocBinDetails.WindowState = FormWindowState.Maximized;
            frmSlocBinDetails.ShowDialog();

            Status = controllerManagement.cekStatusSlocBin(this.SlocBin);
            setStatus();
        }

        public void setStatus ()
        {
            if (Status == "Empty")
            {
                colorPanel.BackColor = Color.FromArgb(121, 199, 157);
                btnDetails.FillColor = Color.FromArgb(0, 166, 110);
            }
            else if (Status == "Available")
            {
                colorPanel.BackColor = Color.FromArgb(152, 193, 217);
                btnDetails.FillColor = Color.FromArgb(62, 90, 128);
            }
            else if (Status == "Full")
            {
                colorPanel.BackColor = Color.FromArgb(229, 61, 56);
                btnDetails.FillColor = Color.FromArgb(168, 30, 34);
            }
            lblStatus.Text = Status;
        }

        private void SlocBinCard_Load(object sender, EventArgs e)
        {
            lblSlocBin.Text = SlocBin;
            lblStatus.Text = Status;
            setStatus();

            
        }
    }
}
