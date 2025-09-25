using System;
using System.Linq;
using System.Windows.Forms;
using SEALCHK.Data;
using SEALCHK.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SEALCHK.View
{
    public partial class VerifyDispose : MaterialForm
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        public string VerifiedAdminId { get; private set; }

        public VerifyDispose()
        {
            InitializeComponent();
            btnOK.Click += btnOK_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string uid = (txtUserID.Text ?? "").Trim();
            string pwd = (txtPassword.Text ?? "").Trim();

            var admin = _db.Users
                  .Where(u => u.UserID == uid && (u.TipeUser == "ADMIN" || u.TipeUser == "SUPERADMIN") )
                  .FirstOrDefault();

            if (admin == null || !BCrypt.Net.BCrypt.Verify(pwd, admin.Password))
            {
                MessageBox.Show("User/Password salah atau bukan ADMIN.", "Verify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VerifiedAdminId = admin.UserID;
            Session.SetVerifiedUser(admin);
            DialogResult = DialogResult.OK;
        }

       
    }
}
