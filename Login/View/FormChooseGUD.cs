using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.Controller;
using Login.Controller;
using Login.Models;
using Master;
using Login.UC;

namespace Login.View
{
    public partial class FormChooseGUD : Form
    {
        #region properties

        public ControllerManagement controllerManagement = new ControllerManagement();
        public DataTable dt = new DataTable();
        public ControllerSlocs controllerSloc = new ControllerSlocs();

        public string[] namagudang = { "Gudang Material 1 (G01)", "Gudang Material 2 (G02)", "Gudang Chemical & Catalyst (G03)", "Gudang Spent Catalyst (G04)", "Gudang Fresh Catalyst (G05)" , "Gudang Tabung (G06)" , "Gudang Open Yard (G07)" };

        #endregion

        public FormChooseGUD()
        {
            InitializeComponent();
        }

        public void generateMainGudang()
        {
            panelUp.Controls.Clear();
            FLGUD.Controls.Clear();
            int jlhGUD = 7;
            for(int i =1; i<=jlhGUD; i++)
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.FillColor = Color.FromArgb(250, 234, 216);
                btn.ForeColor = Color.FromArgb(168, 30, 34);
                btn.Size = new Size(180, 180);
                btn.Name = "G" + i.ToString("D2");
                btn.Text = namagudang[i-1];
                btn.Font = new Font("Arial", 14);
                btn.Click += new EventHandler(btn_mainclick);
                FLGUD.Controls.Add(btn);
            }
        }

        public void generateGudang()
        {
            panelUp.Controls.Clear();
            FLGUD.Controls.Clear();
            if(ClsStaticVariables.GudangInit.Equals("G01"))
            {
                dt = controllerManagement.getAllGudang(ClsStaticVariables.GudangInit, "GD01");
            }
            else
            {
                dt = controllerManagement.getAllGudang(ClsStaticVariables.GudangInit, ClsStaticVariables.GudangInit);
            }

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.FillColor = Color.FromArgb(250, 234, 216);
                btn.ForeColor = Color.FromArgb(168, 30, 34);
                btn.Size = new Size(180, 180);
                btn.Name = row["GudangID"].ToString();
                btn.Text = row["GudangDesc"].ToString();
                btn.Font = new Font("Arial", 14);
                btn.Click += new EventHandler(btn_click);
                FLGUD.Controls.Add(btn);
            }
            Guna.UI2.WinForms.Guna2Button btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnBack.Text = "Back";
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 40);
            btnBack.FillColor = Color.FromArgb(168, 30, 34);
            btnBack.ForeColor = Color.PeachPuff;
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.Anchor = AnchorStyles.Left;
            btnBack.Click += new EventHandler(btnBackMain_Click);
            panelUp.Controls.Add(btnBack);
        }

        public void generateHeader()
        {
            panelUp.Controls.Clear();
            FLGUD.Controls.Clear();
            dt = controllerManagement.getAllRakHeader(ClsStaticVariables.GudangID);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.FillColor = Color.FromArgb(250, 234, 216);
                btn.ForeColor = Color.FromArgb(168, 30, 34);
                btn.Size = new Size(120, 120);
                btn.Name = row["RakNo"].ToString();
                btn.Text = row["RakNo"].ToString();
                btn.Font = new Font("Arial", 14);
                btn.Click += new EventHandler(btnHeader_click);
                FLGUD.Controls.Add(btn);
            }
            Guna.UI2.WinForms.Guna2Button btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnBack.Text = "Back";
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 40);
            btnBack.FillColor = Color.FromArgb(168, 30, 34);
            btnBack.ForeColor = Color.PeachPuff;
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.Anchor = AnchorStyles.Left;

            btnBack.Click += new EventHandler(btnBack_Click);
            panelUp.Controls.Add(btnBack);
        }

        private void FormChooseGUD_Load(object sender, EventArgs e)
        {
            generateMainGudang();
            cbxJenis.SelectedIndex = 0;
        }

        public void btn_mainclick(object sender, EventArgs e)
        {
            var item = (Guna.UI2.WinForms.Guna2Button)sender;
            ClsStaticVariables.GudangInit = item.Name;
            generateGudang();
        }

        public void btn_click(object sender, EventArgs e)
        {
            var item = (Guna.UI2.WinForms.Guna2Button)sender;
            ClsStaticVariables.GudangID = item.Name;
            ClsStaticVariables.GudangDesc = item.Text;
            generateHeader();
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            generateGudang();
        }
        public void btnBackMain_Click(object sender, EventArgs e)
        {
            generateMainGudang();
        }

        public void btnBacktoHeader_Click(object sender, EventArgs e)
        {
            generateHeader();
        }

        public void btnHeader_click(object sender, EventArgs e)
        {
            var item = (Guna.UI2.WinForms.Guna2Button)sender;
            ClsStaticVariables.HeaderID = item.Name;
            //FormWareHouseDetail frmDashBoard = new FormWareHouseDetail();
            //frmDashBoard.Text = "SlocBin Mapping for Each WareHouse";
            //frmDashBoard.ShowDialog();
            generateDenah();
        }

        public void generateDenah()
        {
            FLGUD.Controls.Clear();
            panelUp.Controls.Clear();
            dt = controllerSloc.getSlocBinEachGUD(ClsStaticVariables.HeaderID);
            SlocBinCard slocbincd = new SlocBinCard();
            this.Cursor = Cursors.WaitCursor;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.Click += new EventHandler(btnSlocBinDetail_click);
                btn.Size = new Size(187, 49);
                btn.Font = new Font("Arial", 12);
                btn.Name = dt.Rows[i]["SlocBin"].ToString();
                if (Convert.ToBoolean(dt.Rows[i]["Is_Full"].ToString()))
                {
                    btn.Text = dt.Rows[i]["SlocBin"].ToString() + "\n" + "Full";
                    btn.FillColor = Color.FromArgb(168, 30, 34);
                    btn.Tag = "Full";
                }
                else if (Convert.ToBoolean(dt.Rows[i]["Still_Available"].ToString()))
                {
                    btn.Text = dt.Rows[i]["SlocBin"].ToString() + "\n" + "Available";
                    btn.FillColor = Color.FromArgb(62, 90, 128);
                    btn.Tag = "Available";
                }
                else if (Convert.ToBoolean(dt.Rows[i]["Is_Empty"].ToString()))
                {
                    btn.Text = dt.Rows[i]["SlocBin"].ToString() + "\n" + "Empty";
                    btn.FillColor = Color.FromArgb(0, 166, 110);
                    btn.Tag = "Empty";
                }
                FLGUD.Controls.Add(btn);
            }
            this.Cursor = Cursors.Arrow;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    if (Convert.ToBoolean(dt.Rows[i]["Is_Full"].ToString()))
            //    {
            //        slocbincd = new SlocBinCard(dt.Rows[i]["SlocBin"].ToString(), "Full");
            //    }
            //    else if (Convert.ToBoolean(dt.Rows[i]["Still_Available"].ToString()))
            //    {
            //        slocbincd = new SlocBinCard(dt.Rows[i]["SlocBin"].ToString(), "Available");
            //    }
            //    else if (Convert.ToBoolean(dt.Rows[i]["Is_Empty"].ToString()))
            //    {
            //        slocbincd = new SlocBinCard(dt.Rows[i]["SlocBin"].ToString(), "Empty");
            //    }
            //    FLGUD.Controls.Add(slocbincd);
            //}
            Guna.UI2.WinForms.Guna2Button btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnBack.Text = "Back";
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 40);
            btnBack.FillColor = Color.FromArgb(168, 30, 34);
            btnBack.ForeColor = Color.PeachPuff;
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.Anchor = AnchorStyles.Left;
            btnBack.Click += new EventHandler(btnBacktoHeader_Click);
            panelUp.Controls.Add(btnBack);
        }

        public void btnSlocBinDetail_click (object sender, EventArgs e)
        {
            var item = (Guna.UI2.WinForms.Guna2Button)sender;
            ClsStaticVariables.status = controllerManagement.cekStatusSlocBin(item.Name);
            FormSlocBinDetails frmSlocBinDetails = new FormSlocBinDetails(item.Name);
            ClsStaticVariables.status = item.Tag.ToString();
            frmSlocBinDetails.WindowState = FormWindowState.Maximized;
            frmSlocBinDetails.ShowDialog();
            setStatus(sender, e);
        }

        public void setStatus(object sender, EventArgs e)
        {
            var item = (Guna.UI2.WinForms.Guna2Button)sender;
            if (ClsStaticVariables.status == "Empty")
            {
                item.Text = item.Name.ToString() + "\n" + "Empty";
                item.FillColor = Color.FromArgb(0, 166, 110);
            }
            else if (ClsStaticVariables.status == "Available")
            {
                item.Text = item.Name.ToString() + "\n" + "Available";
                item.FillColor = Color.FromArgb(62, 90, 128);
            }
            else if (ClsStaticVariables.status == "Full")
            {
                item.Text = item.Name.ToString() + "\n" + "Full";
                item.FillColor = Color.FromArgb(168, 30, 34);
            }
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string[] split = txtScanCode.Text.Split('|', ' ');
                    // Search Material in SlocBinDetail Order By Tgl
                    ClsStaticVariables.MaterialNumber = split[0];
                    
                    if(cbxJenis.Text == "Material")
                    {
                        FormListItem frmListItem = new FormListItem();
                        frmListItem.Tag = "MaterialSearchViaSlocBin";
                        frmListItem.Show();
                    }
                    else
                    {
                        FormSlocBinDetails frmSlocBinDetails = new FormSlocBinDetails(txtScanCode.Text);
                        frmSlocBinDetails.WindowState = FormWindowState.Maximized;
                        frmSlocBinDetails.ShowDialog();
                    }
                    

                    txtScanCode.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kode Material Number Salah atau tidak Ditemukan ! , error Message = " + ex.Message);
                }
            }
        }

        private void FLGUD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
