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

namespace Login.View
{
    public partial class FormNEMaterial : Form
    {
        #region properties

        public ControllerMaterial controllerMaterial = new ControllerMaterial();
        public string filepath;

        #endregion
        public FormNEMaterial()
        {
            InitializeComponent();
        }

        public FormNEMaterial(string MaterialNumber )
        {
            InitializeComponent();
            controllerMaterial.GetOneMaterial(MaterialNumber);
            txtMaterialNumber.Text = controllerMaterial.clsMaterial.MaterialNumber;
            txtMaterialNumber.Enabled = false;
            txtMaterialDescription.Text = controllerMaterial.clsMaterial.MaterialDescription;
            txtBaseUnit.Text = controllerMaterial.clsMaterial.BaseUnit;
            txtDocumentHT.Text = controllerMaterial.clsMaterial.DocumentHeaderText;
            txtQty.Text = controllerMaterial.clsMaterial.Qty.ToString();
            txtValue.Text = controllerMaterial.clsMaterial.Value.ToString();
            if(controllerMaterial.clsMaterial.Status == true)
            {
                TSStatus.Checked = true;
            }
            else
            {
                TSStatus.Checked = false;
            }

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.AccessibleDescription.ToString() == "ADD")
            {
                if (txtMaterialNumber.Text.Trim() == "" || txtMaterialNumber.Text.Trim() == null)
                {
                    MessageBox.Show("Mohon di isi Material Number nya");
                }
                else if (txtMaterialDescription.Text.Trim() == "" || txtMaterialDescription.Text.Trim() == null)
                {
                    MessageBox.Show("Mohon di isi Material Description nya.");
                }
                else
                {
                    //set Cls Material
                    string status = "";
                    if (TSStatus.Checked)
                    {
                        status = "Active";
                    }
                    else
                    {
                        status = "Inactive";
                    }
                    controllerMaterial.clsMaterial = new ClsMaterial(txtMaterialNumber.Text, txtMaterialDescription.Text, Convert.ToDecimal(txtQty.Text), txtBaseUnit.Text.ToUpper(), TSStatus.Checked, Convert.ToDecimal(txtValue.Text), txtDocumentHT.Text ?? "", txtImagePath.Text ?? "C:\\WareHousePict\\notfound.png");

                    // Update Table Material
                    MessageBox.Show(controllerMaterial.InsertMaterial(controllerMaterial.clsMaterial));
                    this.Close();
                }
            }
            else if (this.AccessibleDescription.ToString() == "EDIT")
            {
                //set Cls Material
                string status = "";
                if (TSStatus.Checked)
                {
                    status = "Active";
                }
                else
                {
                    status = "Inactive";
                }
                controllerMaterial.clsMaterial = new ClsMaterial(txtMaterialNumber.Text, txtMaterialDescription.Text, Convert.ToDecimal(txtQty.Text), txtBaseUnit.Text.ToUpper(), TSStatus.Checked, Convert.ToDecimal(txtValue.Text), txtDocumentHT.Text ?? "", txtImagePath.Text ?? "C:\\WareHousePict\\notfound.png");

                // Update Table Material
                MessageBox.Show(controllerMaterial.UpdateMaterial(controllerMaterial.clsMaterial));
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Files|*.jpg;*.jpeg;*.png;...;";
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;
            filepath = od.FileName.ToString();
            txtImagePath.Text = filepath;
        }
    }
}
