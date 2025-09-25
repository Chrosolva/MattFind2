using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SEALCHK.View;
using System.Configuration;
using System.Data.SqlClient;
using SEALCHK.Data;

namespace SEALCHK
{
    public partial class FrmLogin : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FrmLogin()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;

            // Create a skin manager instance
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Define a custom color scheme (Green accent for login button)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,   // Primary color
                Primary.Blue700,   // Dark primary
                Primary.Blue200,   // Light primary
                Accent.Green700,   // Accent color (used by login button)
                TextShade.WHITE    // Text color
            );


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // 1. Build a connection string based on the server entered by the user
            string baseConn = ConfigurationManager.ConnectionStrings["SealCheckDb"].ConnectionString;

            var csb = new SqlConnectionStringBuilder(baseConn);
            csb.DataSource = txtServerAdd.Text.Trim(); // “localhost” or SERVER\INSTANCE
            string newConnString = csb.ToString();

            // 2. Use that connection string to create a context
            using (var context = new SealCheckContext(newConnString))
            {
                string userId = txtUserID.Text.Trim();
                string password = txtPassword.Text;

                var user = context.Users.FirstOrDefault(u => u.UserID == userId);

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    // success: close login and allow main menu to open
                    Session.SetUser(user);    // store the logged user
                    Session.SetServerAddress(txtServerAdd.Text);    // store Server Address
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials", "Login");
                }
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Session.CurrentUser == null)
            {
                Environment.Exit(1);
            }
        }
    }


    public class CustomMaterialButton : MaterialButton
    {
        public Color CustomColor { get; set; } = Color.Red;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var brush = new SolidBrush(CustomColor))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Draw text on top
            TextRenderer.DrawText(
                e.Graphics,
                this.Text,
                this.Font,
                this.ClientRectangle,
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
