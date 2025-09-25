using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEALCHK.Data;
using SEALCHK.Model;

namespace SEALCHK.View
{
    public partial class AdminMenuForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();
        private TblUser currentUser = null;

        public AdminMenuForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var userList = _db.Users
                      .OrderBy(u => u.UserID)
                      .Select(u => new {
                          u.UserID,
                          u.UserName,
                          u.TipeUser
                      })
                      .ToList();

            dgvUserList.DataSource = userList;

            
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            cbxUserType.SelectedIndex = 1;
            DataGridViewHelper.ApplyDefaultStyle(dgvUserList);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            currentUser = null;
            ClearFields();
            txtUserID.Enabled = true;
            TCAdminMenu.SelectedTab = TPAddEditUser;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow == null) return;

            string id = dgvUserList.CurrentRow.Cells["UserID"].Value.ToString();
            currentUser = _db.Users.FirstOrDefault(u => u.UserID == id);
            if (currentUser != null)
            {
                txtUserID.Text = currentUser.UserID;
                txtUserID.Enabled = false;
                txtUserName.Text = currentUser.UserName;
                txtPassword.Text = "";
                txtConfirm.Text = "";
                cbxUserType.SelectedItem = currentUser.TipeUser ?? "OPERATOR";
                TCAdminMenu.SelectedTab = TPAddEditUser;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow == null) return;
            string id = dgvUserList.CurrentRow.Cells["UserID"].Value.ToString();

            var confirm = MessageBox.Show($"Delete user {id}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var user = _db.Users.FirstOrDefault(u => u.UserID == id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
                LoadUsers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) ||
            string.IsNullOrWhiteSpace(txtUserName.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text) ||
            string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashed = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text, workFactor: 12);

            if (currentUser == null)
            {
                var user = new TblUser
                {
                    UserID = txtUserID.Text.Trim(),
                    UserName = txtUserName.Text.Trim(),
                    Password = hashed,
                    TipeUser = cbxUserType.SelectedItem.ToString()
                };
                _db.Users.Add(user);
            }
            else
            {
                currentUser.UserName = txtUserName.Text.Trim();
                if (!string.IsNullOrEmpty(txtPassword.Text))
                    currentUser.Password = hashed;
                currentUser.TipeUser = cbxUserType.SelectedItem.ToString();
            }

            _db.SaveChanges();
            LoadUsers();
            ClearFields();
            currentUser = null;
            TCAdminMenu.SelectedTab = TPUserList;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            currentUser = null;
            txtUserID.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClearFields();
            currentUser = null;
            TCAdminMenu.SelectedTab = TPUserList;
        }

        private void ClearFields()
        {
            txtUserID.Text = "";
            txtUserID.Enabled = true;
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            cbxUserType.SelectedIndex = 0;
        }

        // Dispose context
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db.Dispose();
            base.OnFormClosed(e);
        }
    }
}
