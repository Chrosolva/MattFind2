using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.UC
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
            panel1.BackColor = Color.FromArgb(168, 30, 34);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }
    }
}
