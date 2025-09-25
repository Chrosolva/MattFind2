using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBPOS.UC
{
    public partial class CustomNUD : UserControl
    {
        #region properties

        public int nilai;

        #endregion

        public CustomNUD()
        {
            InitializeComponent();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nilai = Convert.ToInt32( numericUpDown1.Value);
        }

        private void btnAddVal_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != numericUpDown1.Maximum)
            {
                numericUpDown1.Value += 1;
                numericUpDown1.Focus();
            }
        }

        public void btnMinusVal_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != numericUpDown1.Minimum)
            {
                numericUpDown1.Value -= 1;
                numericUpDown1.Focus();
            }
        }

        
    }
}
