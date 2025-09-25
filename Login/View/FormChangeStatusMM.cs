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
using Master.Controller;
using Login.Controller;
using Login.Models;

namespace Login.View
{
    public partial class FormChangeStatusMM : Form
    {
        public List<Tuple<string, string>> listData = new List<Tuple<string, string>>();
        public ControllerManagement controllerManagement = new ControllerManagement();
        public FormChangeStatusMM()
        {
            InitializeComponent();
        }

        public FormChangeStatusMM(List<Tuple<string,string>> listdata) 
        {
            InitializeComponent();
            TSBacklog.Checked = true;
            this.listData = listdata;
        }

        private void TSEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (TSProblem.Checked)
            {
                TSGI.Checked = false;
                TSBacklog.Checked = false;
                ClsStaticVariables.statusMM = "Problem";
            }
        }

        private void TSFull_CheckedChanged(object sender, EventArgs e)
        {
            if (TSGI.Checked)
            {
                TSProblem.Checked = false;
                TSBacklog.Checked = false;
                ClsStaticVariables.statusMM = "Good Issue";
            }
        }

        private void TSBacklog_CheckedChanged(object sender, EventArgs e)
        {
            if (TSBacklog.Checked)
            {
                TSGI.Checked = false;
                TSProblem.Checked = false;
                ClsStaticVariables.statusMM = "BackLog";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(controllerManagement.UpdateStatusMaterialRequest(ClsStaticVariables.statusMM, txtManagementID.Text));

            //Update Status
            controllerManagement.UpdateStatusMaterialRequest(listData, ClsStaticVariables.statusMM);
            //Cek All Status 
            if(listData.Count == 0)
            {
                MessageBox.Show("Tidak ada Material yang di pilih !");
            }
            else
            {
                if (controllerManagement.CekMaterialRequestMainStatus(listData[0].Item1))
                {
                    controllerManagement.UpdateMaterialRequestMianstatus(listData[0].Item1, "Done");
                }
                else
                {
                    controllerManagement.UpdateMaterialRequestMianstatus(listData[0].Item1, "OnProcess");
                }
                MessageBox.Show("Status Material Request Berhasil Di Ubah");
            }
            this.Close();
        }
    }
}
