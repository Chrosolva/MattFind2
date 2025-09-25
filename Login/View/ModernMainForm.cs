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
using Master;
using WBPOS.View;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using QRCoder;
using CrystalDecisions.CrystalReports.Engine;
using Login.Reports;
using Login.View;
using CrystalDecisions.Windows.Forms;

namespace WBPOS.View
{
    public partial class ModernMainMDI : Form
    {
        //Fields 
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private ReportDocument otherdoc = new ReportDocument();

        //Constructor
        public ModernMainMDI()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderBtn);

            //Form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color SpaceCadet = Color.FromArgb(37, 39, 77);
            public static Color Independent = Color.FromArgb(70, 72, 102);
            public static Color CadetBlueCrayola = Color.FromArgb(170, 171, 184);
            public static Color BlueGreen = Color.FromArgb(46, 156, 202);
            public static Color SaphireBLue = Color.FromArgb(41, 100, 138);
            public static Color GreenPantone = Color.FromArgb(53, 178, 89);
            public static Color ICterine = Color.FromArgb(242, 242, 113);
            public static Color RedSalsa = Color.FromArgb(241, 76, 76);
            public static Color RaisinBlack = Color.FromArgb(28, 26, 40);
            public static Color MyOWncustomizeMaroon = Color.FromArgb(114, 7, 15);
            public static Color BlackDark = Color.FromArgb(28,30,34);
        }

        //Methods 
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = RGBColors.BlackDark;
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currenBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Cbild Form
                IconCurrentChildForm.IconChar = currenBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currenBtn != null)
            {

                currenBtn.BackColor = Color.WhiteSmoke;
                currenBtn.ForeColor = Color.FromArgb(168,30,34);
                currenBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenBtn.IconColor = Color.FromArgb(168, 30, 34); ;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only a single form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            btnDashBoard.Controls.Add(childForm);
            btnDashBoard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            //if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnTicket.AccessibleDescription.ToString()))
            //{
            //    //FormTicket formticket = new FormTicket();
            //    //formticket.Text = "Ticket";
            //    FormNewOrder formNewOrder = new FormNewOrder();
            //    formNewOrder.Text = "Ticket & Order List";
            //    OpenChildForm(formNewOrder);
            //}
            //else
            //{
            //    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            //}
            //FormWareHouseDetail frmDashBoard = new FormWareHouseDetail();
            //frmDashBoard.Text = "SlocBin Mapping for Each WareHouse";
            //OpenChildForm(frmDashBoard);
            FormChooseGUD frmChooseGud = new FormChooseGUD();
            frmChooseGud.Text = "Choose WareHouse";
            OpenChildForm(frmChooseGud);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            //if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnOrder.AccessibleDescription.ToString()))
            //{
            //    FormOrder formOrder = new FormOrder();
            //    formOrder.Text = "Orders";
            //    OpenChildForm(formOrder);
            //}
            //else
            //{
            //    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            //}
            FormMaterialManagement frmMM = new FormMaterialManagement();
            frmMM.Text = "Material Management";
            OpenChildForm(frmMM);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnUser.AccessibleDescription.ToString()))
            {
                FormUserControl frmusrcontrol = new FormUserControl();
                frmusrcontrol.Text = "Users";
                //frmusrcontrol.MdiParent = this;
                //frmusrcontrol.Show();
                OpenChildForm(frmusrcontrol);

            }
            else
            {
                MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnSloc.AccessibleDescription.ToString()))
            {
                FormSloc frmSloc = new FormSloc();
                frmSloc.Text = "Sloc & SlocBin";
                OpenChildForm(frmSloc);
            }
            else
            {
                MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            }
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            FormMaterial frmMats = new FormMaterial();
            frmMats.Text = "Master Data - Materials";
            OpenChildForm(frmMats);

        }

        private void btnSpecialDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            //if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnSpecialDate.AccessibleDescription.ToString()))
            //{
            //    FormSpecialDate formSpecialDate = new FormSpecialDate();
            //    formSpecialDate.Text = "Price / Date";
            //    OpenChildForm(formSpecialDate);
            //}
            //else
            //{
            //    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            //}
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            //if (ClsStaticVariables.controllerUser.objUser.HakAkses.Contains("admin") || ClsStaticVariables.controllerUser.objUser.HakAkses.Contains(btnReport.AccessibleDescription.ToString()))
            //{
            //    FormReport formReport = new FormReport();
            //    OpenChildForm(formReport);
            //}
            //else
            //{
            //    MessageBox.Show("Maaf Anda tidak punya hak akses untuk layanan ini, silahkan hubungi admin anda ");
            //}
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Application.Exit();
            //Environment.Exit(1);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ModernMainMDI_Load(object sender, EventArgs e)
        {
            lblCopyRight.Text = "CopyRight © " + DateTime.Now.Year.ToString();
            this.btnDrop.Text = ClsStaticVariables.controllerUser.objUser.UserName;
            this.lblStatus.Text = "Connected to " + ClsStaticVariables.objConnection.Server;
            OpenChildForm(new FormChooseGUD());
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if(PanelDrop.Visible == false)
            {
                PanelDrop.Visible = true;
                PanelDrop.BringToFront();
            }
            else
            {
                PanelDrop.Visible = false;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            PanelDrop.Visible = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            this.Hide();
            new FormLogin().ShowDialog();
            this.Show();
            ModernMainMDI_Load(sender,e);
        }

        private void btnDateCode_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Print QR Code Kalibrasi Tanggal ?", " Warning ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string tmp = DateTime.Now.ToString("*MMM dd yyyy, H:mm:ss#").Replace(".", ":");

                QRCodeGenerator qrGenerator = new QRCodeGenerator();

                QRCodeData qrCodeData = qrGenerator.CreateQrCode(tmp, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);

                byte[] yourByteArray;
                using (var mStream = new System.IO.MemoryStream())
                {
                    qrCodeImage.Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
                    yourByteArray = mStream.ToArray();

                }
                DataSet ds = new DataSet();

                DataTable TblQRCode = new DataTable();
                TblQRCode.TableName = "TblQRCode";
                TblQRCode.Columns.Add("TicketID", typeof(string));
                TblQRCode.Columns.Add("QRCode", typeof(byte[]));

                DataRow row = TblQRCode.NewRow();
                row["TicketID"] = tmp;
                row["QRCode"] = yourByteArray;
                TblQRCode.Rows.Add(row);

                ds.Tables.Add(TblQRCode);

                otherdoc = new PrintSlocBinQRCode();
                otherdoc.SetDataSource(ds);

                ////View CRViewer
                //FormListItem formListItem = new FormListItem();
                //CrystalReportViewer crViewer = new CrystalReportViewer();
                //crViewer.ReportSource = otherdoc;
                //crViewer.Size = new Size(800, 400);
                //formListItem.FLListItem.Controls.Add(crViewer);
                //formListItem.ShowDialog();

                //DirectPrint Using Default Printer
                if (otherdoc != null)
                {
                    otherdoc.PrintToPrinter(1, false, 0, 0);
                }
                else
                {
                    MessageBox.Show("Tidak ada QRCode yang akan di cetak");
                }


            }
            else if (dialogResult == DialogResult.No) { }

            
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKartuRayon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            FormTKartuRayon frmKR = new FormTKartuRayon();
            frmKR.Text = "Kartu Rayon";
            OpenChildForm(frmKR);
        }

        private void btnTitipan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            FormTitipan frmTT = new FormTitipan();
            frmTT.Text = "Titipan";
            OpenChildForm(frmTT);
        }

        private void btnMAllocation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.RedSalsa);
            FormMaterialAllocation frmMA = new FormMaterialAllocation();
            frmMA.Text = "Material Allocation";
            OpenChildForm(frmMA);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormBackUpDB frmBackup = new FormBackUpDB();
            frmBackup.Show();
        }
    }
}
