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
using DEPTHCHK.Views;
using System.Configuration;
using System.Data.SqlClient;
using DEPTHCHK.Data;

namespace DEPTHCHK
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
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.AddFormToManage(this);

            // Define a custom color scheme (Green accent for login button)
            // If your MaterialSkin2 has these enums, use them:
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal700,   // primary
                Primary.Teal900,   // primary dark (title bar)
                Primary.Teal400,   // primary light (ripple/hover)
                Accent.Orange400,  // accent
                TextShade.WHITE
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Build a connection string based on the server entered by the user
            string baseConn = ConfigurationManager.ConnectionStrings["DepthChkDb"].ConnectionString;

            var csb = new SqlConnectionStringBuilder(baseConn);
            csb.DataSource = txtServerAdd.Text.Trim(); // “localhost” or SERVER\INSTANCE
            string newConnString = csb.ToString();

            // 2. Use that connection string to create a context
            using (var context = new depthchkDBContext(newConnString))
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

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                Environment.Exit(1);
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
}
