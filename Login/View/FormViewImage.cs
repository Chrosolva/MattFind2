using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.View
{
    public partial class FormViewImage : Form
    {
        public FormViewImage()
        {
            InitializeComponent();
        }

        public FormViewImage(Image img)
        {
            InitializeComponent();
            this.PBView.Image = img;
        }

        private void FormViewImage_Load(object sender, EventArgs e)
        {

        }
    }
}
