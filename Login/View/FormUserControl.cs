using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.UC;
using Master;
using Master.Controller;

namespace WBPOS.View
{
    public partial class FormUserControl : Form
    {
        public FormUserControl()
        {
            InitializeComponent();
        }

        private void FormUserControl_Load(object sender, EventArgs e)
        {
            CsttxtPassword.textBox1.PasswordChar = '*';
            CsttxtConfirm.textBox1.PasswordChar = '*';
            try
            {
                if(ClsStaticVariables.controllerUser.objUser.UserID.ToLower() == "superadmin" )
                {
                    dgvHakAkses.DataSource = ClsStaticVariables.controllerUser.getListHakAksesB();
                }
                else
                {
                    dgvHakAkses.DataSource = ClsStaticVariables.controllerUser.getListHakAkses();
                }
                dgvUser.DataSource = ClsStaticVariables.controllerUser.getListUser();
                dgvHakAkses.Columns[1].ReadOnly = true;
                dgvHakAkses.Columns[2].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("terjadi kesalahan ketika load data user dan hak akses,", ex.Message);
            }

        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHakAkses.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in dgvHakAkses.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)item.Cells[0];
                    cell.Value = false;
                }
                foreach (DataGridViewRow row in dgvHakAkses.Rows)
                {
                    if (dgvUser.CurrentRow.Cells["HakAkses"].Value.ToString().Contains(row.Cells["HakID"].Value.ToString()))
                    {
                        row.Cells[0].Value = true;
                    }
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnAdd.Tag.ToString()) || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
            {
                bool next = true;
                if (csttxtUserID.textBox1.Text.Trim() == null || csttxtUserID.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi user ID terlebih dahulu ");
                }
                if (csttxtUsername.textBox1.Text.Trim() == null || csttxtUsername.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi user Name terlebih dahulu ");
                }
                if (CsttxtPassword.textBox1.Text.Trim() == null || CsttxtPassword.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi Password terlebih dahulu ");
                }
                if (CsttxtConfirm.textBox1.Text.Trim() == null || CsttxtConfirm.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi Confirm Password terlebih dahulu ");
                }

                if(next)
                {
                    if (CsttxtPassword.textBox1.Text == CsttxtConfirm.textBox1.Text)
                    {
                        string tmp = "";
                        dgvHakAkses.EndEdit();
                        for (int i = 0; i < dgvHakAkses.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dgvHakAkses.Rows[i].Cells[0].Value) == true)
                            {
                                tmp += dgvHakAkses.Rows[i].Cells["HakID"].Value.ToString() + ";";
                            }
                        }

                        try
                        {
                            ClsStaticVariables.controllerUser.other = new Models.ClsUser(csttxtUserID.textBox1.Text, csttxtUsername.textBox1.Text, new ClsCrypthography().EncryptString(CsttxtPassword.textBox1.Text), tmp);
                            ClsStaticVariables.controllerUser.InsertUser(ClsStaticVariables.controllerUser.other);
                            MessageBox.Show("DataUser Berhasil ditambah");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi Kesalahan pada penambahan data user", ex.Message);
                        }
                        csttxtUserID.textBox1.Text = "";
                        CsttxtPassword.textBox1.Text = "";
                        csttxtUsername.textBox1.Text = "";
                        CsttxtConfirm.textBox1.Text = "";
                        dgvUser.DataSource = ClsStaticVariables.controllerUser.getListUser();
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Maaf , anda tidak punya hak untuk layanan ini");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnEdit.Tag.ToString()) || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
            {
                bool next = true;
                if (csttxtUserID.textBox1.Text.Trim() == null || csttxtUserID.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi user ID terlebih dahulu ");
                }
                if (csttxtUsername.textBox1.Text.Trim() == null || csttxtUsername.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi user Name terlebih dahulu ");
                }
                if (CsttxtPassword.textBox1.Text.Trim() == null || CsttxtPassword.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi Password terlebih dahulu ");
                }
                if (CsttxtConfirm.textBox1.Text.Trim() == null || CsttxtConfirm.textBox1.Text.Trim() == "")
                {
                    next = false;
                    MessageBox.Show("Mohon di isi Confirm Password terlebih dahulu ");
                }

                if(next)
                {
                    if (CsttxtPassword.textBox1.Text == CsttxtConfirm.textBox1.Text)
                    {
                        string tmp = "";
                        dgvHakAkses.EndEdit();
                        for (int i = 0; i < dgvHakAkses.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dgvHakAkses.Rows[i].Cells[0].Value) == true)
                            {
                                tmp += dgvHakAkses.Rows[i].Cells["HakID"].Value.ToString() + ";";
                            }
                        }

                        try
                        {
                            ClsStaticVariables.controllerUser.other = new Models.ClsUser(csttxtUserID.textBox1.Text, csttxtUsername.textBox1.Text, new ClsCrypthography().EncryptString(CsttxtPassword.textBox1.Text), tmp);
                            ClsStaticVariables.controllerUser.EditUser(ClsStaticVariables.controllerUser.other);
                            MessageBox.Show("DataUser Berhasil diubah");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi Kesalahan pada perubahan data user", ex.Message);
                        }
                        csttxtUserID.textBox1.Text = "";
                        CsttxtPassword.textBox1.Text = "";
                        csttxtUsername.textBox1.Text = "";
                        CsttxtConfirm.textBox1.Text = "";
                        dgvUser.DataSource = ClsStaticVariables.controllerUser.getListUser();
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Maaf , anda tidak punya hak untuk layanan ini");
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            csttxtUserID.textBox1.Text = dgvUser.CurrentRow.Cells["UserID"].Value.ToString();
            csttxtUsername.textBox1.Text = dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            CsttxtPassword.textBox1.Text = new ClsCrypthography().DecryptString(dgvUser.CurrentRow.Cells["Password"].Value.ToString());
            CsttxtConfirm.textBox1.Text = new ClsCrypthography().DecryptString(dgvUser.CurrentRow.Cells["Password"].Value.ToString());
            if(dgvUser.CurrentRow.Cells[0].Value.ToString().ToLower() == "superadmin")
            {
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }

            if(ClsStaticVariables.controllerUser.objUser.UserID.ToLower() == "superadmin")
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnDelete.Tag.ToString()) || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data user ID  " + csttxtUserID.Texts+ " ? ", " Warning ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string tmp = "";
                        dgvHakAkses.EndEdit();
                        for (int i = 0; i < dgvHakAkses.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dgvHakAkses.Rows[i].Cells[0].Value) == true)
                            {
                                tmp += dgvHakAkses.Rows[i].Cells["HakID"].Value.ToString() + ";";
                            }
                        }
                        ClsStaticVariables.controllerUser.other = new Models.ClsUser(csttxtUserID.textBox1.Text, csttxtUsername.textBox1.Text, new ClsCrypthography().EncryptString(CsttxtPassword.textBox1.Text), tmp);
                        ClsStaticVariables.controllerUser.DeleteUser(ClsStaticVariables.controllerUser.other);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Data gagal dihapus, " , ex.Message);
                    }

                    csttxtUserID.textBox1.Text = "";
                    CsttxtPassword.textBox1.Text = "";
                    csttxtUsername.textBox1.Text = "";
                    CsttxtConfirm.textBox1.Text = "";
                    dgvUser.DataSource = ClsStaticVariables.controllerUser.getListUser();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            else
            {
                MessageBox.Show("Maaf Anda tidak punya hak untuk layanan ini ");
            }
        }

        private void btnUpdateHakAkses_Click(object sender, EventArgs e)
        {
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnEdit.Tag.ToString()) || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin"))
            {
                if (csttxtUserID.textBox1.Text.Trim() == null || csttxtUserID.textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Mohon di isi user ID terlebih dahulu ");
                }
                if (csttxtUsername.textBox1.Text.Trim() == null || csttxtUsername.textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Mohon di isi user Name terlebih dahulu ");
                }
                if (CsttxtPassword.textBox1.Text.Trim() == null || CsttxtPassword.textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Mohon di isi Password terlebih dahulu ");
                }
                if (CsttxtConfirm.textBox1.Text.Trim() == null || CsttxtConfirm.textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Mohon di isi Confirm Password terlebih dahulu ");
                }
                else
                {
                    if (CsttxtPassword.textBox1.Text == CsttxtConfirm.textBox1.Text)
                    {
                        string tmp = "";
                        dgvHakAkses.EndEdit();
                        for (int i = 0; i < dgvHakAkses.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dgvHakAkses.Rows[i].Cells[0].Value) == true)
                            {
                                tmp += dgvHakAkses.Rows[i].Cells["HakID"].Value.ToString() + ";";
                            }
                        }

                        try
                        {
                            ClsStaticVariables.controllerUser.other = new Models.ClsUser(csttxtUserID.textBox1.Text, csttxtUsername.textBox1.Text, new ClsCrypthography().EncryptString(CsttxtPassword.textBox1.Text), tmp);
                            ClsStaticVariables.controllerUser.EditHakAksesonly(ClsStaticVariables.controllerUser.other);
                            MessageBox.Show("HakAkses Berhasil diubah");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi Kesalahan pada perubahan data HakAkses User", ex.Message);
                        }
                        csttxtUserID.textBox1.Text = "";
                        CsttxtPassword.textBox1.Text = "";
                        csttxtUsername.textBox1.Text = "";
                        CsttxtConfirm.textBox1.Text = "";
                        dgvUser.DataSource = ClsStaticVariables.controllerUser.getListUser();
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Maaf , anda tidak punya hak untuk layanan ini");
            }
        }
    }
}
