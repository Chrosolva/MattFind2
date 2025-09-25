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
    public partial class CustomTextBox : UserControl
    {
        #region properties

        public string Texts = "";

        #endregion

        public CustomTextBox()
        {
            InitializeComponent();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0, 191, 255);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Texts = textBox1.Text;
        }

        
    }
}
