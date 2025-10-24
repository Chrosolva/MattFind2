using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DEPTHCHK.Data;
using System.Linq;
using DEPTHCHK.Models;
using System.Configuration;
using System.Data.Entity;
using System.IO.Ports;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DEPTHCHK.Views
{
    public partial class FrmMainMenu : MaterialForm
    {
        private readonly depthchkDBContext _db = new depthchkDBContext();

        private readonly Color MenuDefaultColor = Color.FromArgb(33, 150, 243); // blue
        private readonly Color MenuHoverColor = Color.FromArgb(30, 136, 229);  // lighter blue
        private readonly Color MenuActiveColor = Color.FromArgb(0, 150, 0);    // green

        private MaterialButton activeButton = null;

        private SerialPort _port;
        private CancellationTokenSource _readerCts;
        private SerialPort _port2;
        private CancellationTokenSource _readerCts2;
        public event EventHandler<string> SerialDataReceived;

        public FrmMainMenu()
        {
            InitializeComponent();

            // Apply MaterialSkin theme
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            // Use DARK so teal/orange pops
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            this.Font = new Font("Tahoma", 10f, FontStyle.Regular);
            // make the manager keep your BackColor values
            skinManager.EnforceBackcolorOnAllComponents = true;

            // If your MaterialSkin2 has these enums, use them:
            skinManager.ColorScheme = new ColorScheme(
                Primary.Teal700,   // primary
                Primary.Teal900,   // primary dark (title bar)
                Primary.Teal400,   // primary light (ripple/hover)
                Accent.Orange400,  // accent
                TextShade.WHITE
            );


        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            InitializeMenuPanel();
            // Pick sizes to your taste
            var appFonts = GlobalFontHelper.Resolve(
                bodySize: 12f,           // typical body
                headerSize: 12.5f,       // slightly larger headers
                headerStyle: FontStyle.Bold
            );

            // Apply to the main form (and all its current controls)
            GlobalFontHelper.Apply(this, appFonts);

            if (Session.CurrentUser == null) return;

            lblStatus.Text = "SERVER : " + Session.SERVERADDRESS + " , USER ID = " + Session.CurrentUser.UserID;
            TryLoadTimeZone();

            // populate available ports
            cbxPort.Items.Clear();
            foreach (var p in SerialPort.GetPortNames().OrderBy(p => p))
                cbxPort.Items.Add(p);
            if (cbxPort.Items.Count > 0) cbxPort.SelectedIndex = 0;

            // NEW: populate secondary port list
            cbxPort2.Items.Clear();
            foreach (var p in SerialPort.GetPortNames().OrderBy(p => p))
                cbxPort2.Items.Add(p);
            if (cbxPort2.Items.Count > 1) cbxPort2.SelectedIndex = 1;

            //btnConnect.Click += btnMainConnect_Click;
            //btnDisconnect.Click += btnMainDisconnect_Click;
            UpdateUiForPortState(false);
            UpdateUiForPort2State(false);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // validate both combos
            if (cbxPort.SelectedItem == null || cbxPort2.SelectedItem == null)
            {
                MessageBox.Show("Please select both ports.");
                return;
            }

            string portName1 = cbxPort.SelectedItem.ToString();
            string portName2 = cbxPort2.SelectedItem.ToString();

            // prevent selecting the same COM port twice
            if (portName1.Equals(portName2, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Cannot use the same port for both connections. Choose two different ports.");
                return;
            }

            // ensure neither port is currently open
            if (Session.IsPortOpen || Session.IsPort2Open)
            {
                MessageBox.Show("One or both ports are already open. Please disconnect first.");
                return;
            }

            // open first port
            try
            {
                _port = new SerialPort(portName1, Convert.ToInt32(baudrateRFID.Value), Parity.None, 8, StopBits.One)
                {
                    NewLine = "\r\n",
                    ReadTimeout = 500,
                    WriteTimeout = 500,
                    DtrEnable = true,
                    RtsEnable = false,
                    Handshake = Handshake.None
                };
                _port.Open();
                Session.SetGlobalPort(_port);
                UpdateUiForPortState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open port 1: " + ex.Message);
                return;
            }

            // open second port
            try
            {
                _port2 = new SerialPort(portName2, Convert.ToInt32(NUDBaudRate.Value), Parity.None, 8, StopBits.One)
                {
                    NewLine = "\r\n",
                    ReadTimeout = 500,
                    WriteTimeout = 500,
                    DtrEnable = true,
                    RtsEnable = false,
                    Handshake = Handshake.None
                };
                _port2.Open();
                Session.SetGlobalPort2(_port2);
                UpdateUiForPort2State(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open port 2: " + ex.Message);
                // close first port if second fails
                try { _port.Close(); Session.SetGlobalPort(null); } catch { }
                UpdateUiForPortState(false);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // close port1 if open
            if (Session.IsPortOpen)
            {
                try
                {
                    Session.GlobalPort.Close();
                }
                catch { }
                Session.SetGlobalPort(null);
                UpdateUiForPortState(false);
            }

            // close port2 if open
            if (Session.IsPort2Open)
            {
                try
                {
                    Session.GlobalPort2.Close();
                }
                catch { }
                Session.SetGlobalPort2(null);
                UpdateUiForPort2State(false);
            }
        }

        private void TryLoadTimeZone()
        {
            var zones = _db.TimeSettings.AsNoTracking()
                    .OrderByDescending(z => z.Active)
                    .ThenBy(z => z.DisplayName)
                    .ToList();

            cbxTimeZone.DataSource = zones;
            cbxTimeZone.DisplayMember = "DisplayName";
            cbxTimeZone.ValueMember = "TimeZoneId";

            // Select the active one (if any)
            var active = zones.FirstOrDefault(z => z.Active);
            if (active != null)
                cbxTimeZone.SelectedValue = active.TimeZoneId;

            // Optional: show current time with the active zone
            ApplyTimeZone(active ?? zones.FirstOrDefault());
        }

        private void ApplyTimeZone(TblTimeSettings tz)
        {
            if (tz == null) return;
            try
            {
                var tzi = TimeZoneInfo.FindSystemTimeZoneById(tz.TimeZoneId);
                var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tzi);
                lblTime.Text = $"{tz.DisplayName}: {now:yyyy-MM-dd HH:mm:ss}";
                Session.Settzi(tzi);
            }
            catch (TimeZoneNotFoundException)
            {
                lblTime.Text = $"Timezone not found: {tz.TimeZoneId}";
            }
        }

        // -------------------------------
        // Panels Initialization
        // -------------------------------
        private void InitializeMenuPanel()
        {
            // Add menu buttons
            AddMenuButton("PENGIRIMAN", (s, e) => OpenChildForm(new PengirimanFormNew()), "OPERATOR", "SUPERADMIN");
            AddMenuButton("MOBIL TANGKI", (s, e) => OpenChildForm(new MobilTangkiForm()), "ADMIN", "SUPERADMIN");
            //AddMenuButton("TUJUAN", (s, e) => OpenChildForm(new DestinationForm()), "ADMIN", "SUPERADMIN");
            //AddMenuButton("HIS", (s, e) => OpenChildForm(new HistoryForm()), "ADMIN", "SUPERADMIN");
            AddMenuButton("REPORT", (s, e) => OpenChildForm(new ReportForm()), "ADMIN", "SUPERADMIN");
            AddMenuButton("USER", (s, e) => OpenChildForm(new AdminMenuForm()), "ADMIN", "SUPERADMIN");

            // Style panelMenu2 (already on form)
            this.panelMenu2.BackColor = Color.FromArgb(13, 148, 136);
        }

        // -------------------------------
        // Menu Button Creation
        // -------------------------------
        private void AddMenuButton(string text, EventHandler onClick, params string[] allowedRoles)
        {

            Panel container = new Panel
            {
                Dock = DockStyle.Left,
                Height = 40,
                Width = 140,
                Padding = new Padding(2, 2, 2, 0)
            };

            var btn = new MaterialButton
            {
                Text = text,
                Dock = DockStyle.Fill,
                Height = 40,
                Margin = new Padding(2),
                Tag = text,
                Name = "btn" + text,
                BackColor = MenuDefaultColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                UseAccentColor = true
            };
            btn.FlatAppearance.BorderSize = 0;

            // Hover effect
            btn.MouseEnter += (s, e) =>
            {
                if (btn != activeButton) btn.BackColor = MenuHoverColor;
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn != activeButton) btn.BackColor = MenuDefaultColor;
            };

            // Active effect + Click handler
            btn.Click += (s, e) =>
            {
                if (activeButton != null)
                    activeButton.BackColor = MenuDefaultColor;

                activeButton = btn;
                btn.BackColor = MenuActiveColor;

                // ✅ CLICK-TIME ACCESS CHECK (multiple roles)
                if (!HasAccess(allowedRoles))
                {
                    MessageBox.Show("Anda tidak memiliki hak akses ke menu ini.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                onClick(s, e); // Open form
            };

            container.Controls.Add(btn);
            panelMenu2.Controls.Add(container);
            panelMenu2.Controls.SetChildIndex(container, 0); // keep order
        }

        private bool HasAccess(string[] allowedRoles)
        {
            // If no roles specified, allow everyone
            if (allowedRoles == null || allowedRoles.Length == 0) return true;

            var user = Session.CurrentUser;
            if (user == null || string.IsNullOrWhiteSpace(user.TipeUser)) return false;

            // Compare case-insensitively
            return allowedRoles.Any(r => string.Equals(r, user.TipeUser, StringComparison.OrdinalIgnoreCase));
        }

        private Form _activeChild;

        // -------------------------------
        // Core Logic
        // -------------------------------
        private void OpenChildForm(Form childForm)
        {
            // If the form requires the serial port, enforce that the port is open first
            bool requiresPort =
                (childForm is PengirimanFormNew) ||
                (childForm is MobilTangkiForm);

            //bool requiresPort = false;

            // dispose the current child cleanly
            if (_activeChild != null)
            {
                try { (_activeChild as MobilTangkiForm)?.PrepareToClose(); } catch { }
                try { (_activeChild as PengirimanFormNew)?.PrepareToClose(); } catch { }
                try { _activeChild.Dispose(); } catch { }
                _activeChild = null;
            }

            if (requiresPort && !Session.IsPortOpen)
            {
                MessageBox.Show(
                    "Serial port is not connected. Please connect the port first in the main menu.",
                    "Port Not Connected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;  // Do not open the form
            }

            // dispose the current child cleanly
            if (_activeChild != null)
            {
                //try { (_activeChild as RegisterSealForm)?.PrepareToClose(); } catch { }
                try { _activeChild.Dispose(); } catch { }
                _activeChild = null;
            }

            ContentCard.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            var appFonts = GlobalFontHelper.Resolve(
                bodySize: 12f,           // typical body
                headerSize: 12.5f,       // slightly larger headers
                headerStyle: FontStyle.Bold
            );

            ContentCard.Controls.Add(childForm);
            GlobalFontHelper.Apply(childForm, appFonts);
            childForm.Show();

            _activeChild = childForm;
            //(_activeChild as IEmbeddable)?.PrepareToClose();

        }

        private void UpdateUiForPortState(bool connected)
        {

            lblPortStatus.Text = connected
                ? "Connected: " + Session.GlobalPort.PortName + " @ " + _port.BaudRate
                : "Disconnected";
            lblPortStatus.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
        }

        // NEW: update second port status
        private void UpdateUiForPort2State(bool connected)
        {
            lblPort2Status.Text = connected
                ? "Connected: " + Session.GlobalPort2.PortName + " @ " + _port2.BaudRate
                : "Disconnected";
            lblPort2Status.ForeColor = connected ? Color.ForestGreen : Color.Firebrick;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // This will close the current instance and start Program.Main again.
            Application.Restart();
        }

        private void btnSetActive_Click(object sender, EventArgs e)
        {
            var selected = cbxTimeZone.SelectedItem as TblTimeSettings;
            if (selected == null) return;

            using (var tx = _db.Database.BeginTransaction())
            {
                // Set all to inactive
                _db.Database.ExecuteSqlCommand("UPDATE TblTimeSettings SET Active = 0");

                // Activate selected
                _db.Database.ExecuteSqlCommand(
                    "UPDATE TblTimeSettings SET Active = 1 WHERE Id = @p0", selected.Id);

                tx.Commit();
            }

            // Reload UI and show current time using new active zone
            TryLoadTimeZone();
        }

        private void btnBackUP_Click(object sender, EventArgs e)
        {
            // Ask user where to save the .bak file
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQL Server backup (*.bak)|*.bak";
                sfd.Title = "Save Database Backup";
                sfd.FileName = "DEPTHCHK_" + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".bak";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    try
                    {
                        // Build a connection string using your server address
                        var builder = new SqlConnectionStringBuilder();
                        builder.ConnectionString = ConfigurationManager
                            .ConnectionStrings["DepthChkDb"].ConnectionString;
                        builder.DataSource = Session.SERVERADDRESS;
                        builder.InitialCatalog = "master";        // connect to master to run BACKUP
                        builder.IntegratedSecurity = true;       // or set builder.UserID/Password

                        using (SqlConnection conn = new SqlConnection(builder.ToString()))
                        {
                            conn.Open();
                            string backupSql = $"BACKUP DATABASE [DEPTHCHK] TO DISK=@file WITH INIT;";
                            using (SqlCommand cmd = new SqlCommand(backupSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@file", filePath);
                                cmd.CommandTimeout = 0; // allow long running
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Backup completed successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Backup failed: " + ex.Message);
                    }
                }
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cbxTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPort2Status_Click(object sender, EventArgs e)
        {

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ApplyMaximizedBounds();
        }

        private void ApplyMaximizedBounds()
        {
            // Clamp to monitor’s working area (excludes taskbar) — fixes 125% overshoot
            var scr = Screen.FromHandle(this.Handle);
            this.MaximizedBounds = scr.WorkingArea;
        }

        // Hard clamp via window message (works on all WinForms versions)
        protected override void WndProc(ref Message m)
        {
            const int WM_GETMINMAXINFO = 0x0024;
            const int WM_DPICHANGED = 0x02E0; // sent when moving between different DPI monitors

            if (m.Msg == WM_GETMINMAXINFO)
            {
                var wa = Screen.FromHandle(this.Handle).WorkingArea;
                var mmi = Marshal.PtrToStructure<MINMAXINFO>(m.LParam);
                mmi.ptMaxPosition = new POINT(wa.Left, wa.Top);
                mmi.ptMaxSize = new POINT(wa.Width, wa.Height);
                mmi.ptMaxTrackSize = new POINT(wa.Width, wa.Height);
                Marshal.StructureToPtr(mmi, m.LParam, true);
                base.WndProc(ref m);
                return;
            }
            else if (m.Msg == WM_DPICHANGED)
            {
                // Re-apply bounds when DPI changes at runtime
                ApplyMaximizedBounds();

                // If Windows provides a suggested rect, apply it (optional but nice)
                // lParam points to a RECT* with suggested new size/position.
                // You can read it if you want tighter control.
            }

            base.WndProc(ref m);
        }

        [StructLayout(LayoutKind.Sequential)]
        struct POINT { public int X; public int Y; public POINT(int x, int y) { X = x; Y = y; } }

        [StructLayout(LayoutKind.Sequential)]
        struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

    }
}
