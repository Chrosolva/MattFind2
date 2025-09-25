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
using Master.UC;
using Master;
using Master.Controller;

namespace Master
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
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
            csttxtPassword.textBox1.PasswordChar = '*';
            cbxPilihServer.SelectedIndex = 0;
            csttxtPassword.textBox1.KeyDown += Login;
        }

        public void Login (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClsStaticVariables.setNewConnection("WareHouseMS", cbxPilihServer.Text);
            if(csttxtuserid.textBox1.Text.Trim() == "" || csttxtuserid.textBox1.Text.Trim() == null)
            {
                MessageBox.Show("UserID atau Password Kosong");
            }
            else if(csttxtPassword.textBox1.Text.Trim() == "" || csttxtPassword.textBox1.Text.Trim() == null)
            {
                MessageBox.Show("UserID atau Password Kosong");
            }
            else
            {
                try
                {
                    ClsStaticVariables.controllerUser.objUser = ClsStaticVariables.controllerUser.getOneUser(csttxtuserid.textBox1.Text, csttxtPassword.textBox1.Text);
                    if(ClsStaticVariables.controllerUser.objUser == null)
                    {
                        MessageBox.Show("UserID atau Password Salah");
                    }
                    else
                    {
                        
                        if(csttxtPassword.textBox1.Text == new ClsCrypthography().DecryptString(ClsStaticVariables.controllerUser.objUser.Password))
                        {
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("UserID atau Password Salah");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
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

        public void csttxtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
