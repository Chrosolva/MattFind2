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
    public partial class FormNESlocSlocBin : Form
    {

        #region properties

        public ControllerSlocs controllerSloc = new ControllerSlocs();

        #endregion

        public FormNESlocSlocBin()
        {
            InitializeComponent();
        }

        public FormNESlocSlocBin(string SlocID)
        {
            InitializeComponent();
            controllerSloc.getOneSloc(SlocID);
            //txtSlocID.Text = controllerSloc.clsSloc.Sloc;
            //txtSlocType.Text = controllerSloc.clsSloc.Sloc_Type;
            //txtSlocAddresses.Text = controllerSloc.clsSloc.Sloc_Addresses;
            DataGridViewRow newrow = (DataGridViewRow)dgvNESlocBin.Rows[0].Clone();
            newrow.Cells[0].Value = controllerSloc.clsSlocBin.SlocBin;
            newrow.Cells[1].Value = controllerSloc.clsSlocBin.Sloc;
            newrow.Cells[2].Value = controllerSloc.clsSlocBin.Is_Full;
            newrow.Cells[3].Value = controllerSloc.clsSlocBin.still_available;
            newrow.Cells[4].Value = controllerSloc.clsSlocBin.Is_Empty;
            dgvNESlocBin.Rows.Add(newrow);

            dgvNESlocBin.AllowUserToAddRows = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.AccessibleDescription.ToString() == "ADD")
            {
                // set ClsSlocBin 
                controllerSloc.listSlocBIn = new List<ClsSlocBin>();
                foreach (DataGridViewRow row in dgvNESlocBin.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        controllerSloc.clsSlocBin = new ClsSlocBin(row.Cells["SlocBinID"].Value.ToString(), row.Cells["Sloc"].Value.ToString(), Convert.ToBoolean(row.Cells["IsFull"].Value.ToString()), Convert.ToBoolean(row.Cells["Still_Available"].Value.ToString()),Convert.ToBoolean(row.Cells["IsEmpty"].Value.ToString()));
                        controllerSloc.listSlocBIn.Add(controllerSloc.clsSlocBin);
                    }
                }

                // Update Table SlocBin
                MessageBox.Show(controllerSloc.InsertDataSLocBin(controllerSloc.listSlocBIn));
                this.Close();
            }
            else if (this.AccessibleDescription.ToString() == "EDIT")
            {
                // set ClsSlocBin 
                controllerSloc.listSlocBIn = new List<ClsSlocBin>();
                dgvNESlocBin.EndEdit();
                foreach (DataGridViewRow row in dgvNESlocBin.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        controllerSloc.clsSlocBin = new ClsSlocBin(row.Cells["SlocBinID"].Value.ToString(), row.Cells["Sloc"].Value.ToString(), Convert.ToBoolean(row.Cells["IsFull"].Value.ToString()), Convert.ToBoolean(row.Cells["Still_Available"].Value.ToString()), Convert.ToBoolean(row.Cells["IsEmpty"].Value.ToString()));
                        controllerSloc.listSlocBIn.Add(controllerSloc.clsSlocBin);
                    }
                }

                // Update Table SlocBin
                MessageBox.Show(controllerSloc.UpdateSlocSlocBin(controllerSloc.clsSlocBin));
                this.Close();
            }
        }

        private void dgvNESlocBin_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvNESlocBin_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[2].Value = false;
            e.Row.Cells[3].Value = false;
            e.Row.Cells[4].Value = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNESlocBin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormNESlocSlocBin_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvNESlocBin_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
