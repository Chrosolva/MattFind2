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
using Login.Controller;
using Login.Models;
using Login.UC;
using Master.Controller;

namespace Login.View
{
    public partial class FormWareHouseDetail : Form
    {

        public FormWareHouseDetail()
        {
            InitializeComponent();
        }

        #region properties

        public ControllerSlocs controllerSloc = new ControllerSlocs();
        public DataTable dt = new DataTable();

        #endregion

        #region function 

        public void generateDenah()
        {
            dt = controllerSloc.getSlocBinEachGUD(ClsStaticVariables.HeaderID);
            SlocBinCard slocbincd = new SlocBinCard();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (Convert.ToBoolean(dt.Rows[i]["Is_Full"].ToString()))
                {
                    slocbincd = new SlocBinCard(dt.Rows[i]["SlocBin"].ToString(), "Full");
                }
                else if (Convert.ToBoolean(dt.Rows[i]["Still_Available"].ToString()))
                {
                    slocbincd = new SlocBinCard(dt.Rows[i]["SlocBin"].ToString(), "Available");
                }
                else if (Convert.ToBoolean(dt.Rows[i]["Is_Empty"].ToString()))
                {
                    slocbincd = new SlocBinCard(dt.Rows[i]["SlocBin"].ToString(), "Empty");
                }
                slocbincd.btnDetails.Click += new EventHandler(btnDetails_click);
                FLSlocBin.Controls.Add(slocbincd);
            }
        }

        #endregion
        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            cbxGUDID.SelectedIndex = 0;
            generateDenah();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FLSlocBin.Controls.Clear();
            FormDashBoard_Load(sender, e);
        }

        public void btnDetails_click(object sender, EventArgs e)
        {

        }
    }
}
