using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WBPOS.View
{
    public partial class FormLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public FormLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void xuiSuperButton3_MouseHover(object sender, EventArgs e)
        {
            btnExit.ButtonImage = Image.FromFile("D:\\Program\\WBPOS\\Login\\Icon\\exit.png");
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ButtonImage = Image.FromFile("D:\\Program\\WBPOS\\Login\\Icon\\exitblack.png");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.cbxPilihServer.SelectedIndex = 0;
        }
    }
}
