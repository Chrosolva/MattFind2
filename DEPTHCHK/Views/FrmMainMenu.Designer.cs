namespace DEPTHCHK.Views
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.NUDBaudRate = new System.Windows.Forms.NumericUpDown();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxPort = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ContentCard = new MaterialSkin.Controls.MaterialCard();
            this.btnBackUP = new MaterialSkin.Controls.MaterialButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SPRegis = new System.IO.Ports.SerialPort(this.components);
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.cbxPort2 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPort2Status = new System.Windows.Forms.Label();
            this.baudrateRFID = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSetActive = new MaterialSkin.Controls.MaterialButton();
            this.cbxTimeZone = new MaterialSkin.Controls.MaterialComboBox();
            this.btnLogOut = new DEPTHCHK.Custom.CustomMaterialButton();
            this.btnDisconnect = new DEPTHCHK.Custom.CustomMaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudrateRFID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(789, 649);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "TIME";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(7, 294);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnect.Size = new System.Drawing.Size(89, 36);
            this.btnConnect.TabIndex = 29;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // NUDBaudRate
            // 
            this.NUDBaudRate.Location = new System.Drawing.Point(132, 230);
            this.NUDBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.NUDBaudRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDBaudRate.Name = "NUDBaudRate";
            this.NUDBaudRate.Size = new System.Drawing.Size(77, 20);
            this.NUDBaudRate.TabIndex = 30;
            this.NUDBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(139, 87);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(70, 19);
            this.materialLabel7.TabIndex = 28;
            this.materialLabel7.Text = "BaudRate";
            // 
            // cbxPort
            // 
            this.cbxPort.AutoResize = false;
            this.cbxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPort.Depth = 0;
            this.cbxPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPort.DropDownHeight = 174;
            this.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort.DropDownWidth = 121;
            this.cbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Hint = "PORT";
            this.cbxPort.IntegralHeight = false;
            this.cbxPort.ItemHeight = 43;
            this.cbxPort.Location = new System.Drawing.Point(7, 110);
            this.cbxPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPort.MaxDropDownItems = 4;
            this.cbxPort.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(112, 49);
            this.cbxPort.StartIndex = 0;
            this.cbxPort.TabIndex = 26;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(7, 87);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(80, 19);
            this.materialLabel6.TabIndex = 27;
            this.materialLabel6.Text = "RFID PORT";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(235, 649);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(189, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "SERVER : LOCALHOST , USER ID = ";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // ContentCard
            // 
            this.ContentCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentCard.AutoScroll = true;
            this.ContentCard.AutoScrollMinSize = new System.Drawing.Size(1200, 500);
            this.ContentCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContentCard.Depth = 0;
            this.ContentCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContentCard.Location = new System.Drawing.Point(221, 74);
            this.ContentCard.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.ContentCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContentCard.Name = "ContentCard";
            this.ContentCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentCard.Size = new System.Drawing.Size(1281, 571);
            this.ContentCard.TabIndex = 22;
            // 
            // btnBackUP
            // 
            this.btnBackUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackUP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackUP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackUP.Depth = 0;
            this.btnBackUP.HighEmphasis = true;
            this.btnBackUP.Icon = null;
            this.btnBackUP.Location = new System.Drawing.Point(7, 571);
            this.btnBackUP.Margin = new System.Windows.Forms.Padding(5, 7, 6, 7);
            this.btnBackUP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackUP.Name = "btnBackUP";
            this.btnBackUP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackUP.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnBackUP.Size = new System.Drawing.Size(104, 36);
            this.btnBackUP.TabIndex = 1;
            this.btnBackUP.Text = "BACK UP DB";
            this.btnBackUP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackUP.UseAccentColor = true;
            this.btnBackUP.UseVisualStyleBackColor = true;
            this.btnBackUP.Click += new System.EventHandler(this.btnBackUP_Click);
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(4, 163);
            this.lblPortStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(63, 13);
            this.lblPortStatus.TabIndex = 25;
            this.lblPortStatus.Text = "Port Status";
            // 
            // panelMenu2
            // 
            this.panelMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.panelMenu2.Location = new System.Drawing.Point(221, 26);
            this.panelMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panelMenu2.Size = new System.Drawing.Size(1210, 44);
            this.panelMenu2.TabIndex = 21;
            // 
            // cbxPort2
            // 
            this.cbxPort2.AutoResize = false;
            this.cbxPort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPort2.Depth = 0;
            this.cbxPort2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPort2.DropDownHeight = 174;
            this.cbxPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort2.DropDownWidth = 121;
            this.cbxPort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPort2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPort2.FormattingEnabled = true;
            this.cbxPort2.Hint = "PORT";
            this.cbxPort2.IntegralHeight = false;
            this.cbxPort2.ItemHeight = 43;
            this.cbxPort2.Location = new System.Drawing.Point(7, 214);
            this.cbxPort2.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPort2.MaxDropDownItems = 4;
            this.cbxPort2.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPort2.Name = "cbxPort2";
            this.cbxPort2.Size = new System.Drawing.Size(112, 49);
            this.cbxPort2.StartIndex = 0;
            this.cbxPort2.TabIndex = 34;
            // 
            // lblPort2Status
            // 
            this.lblPort2Status.AutoSize = true;
            this.lblPort2Status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort2Status.Location = new System.Drawing.Point(4, 274);
            this.lblPort2Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort2Status.Name = "lblPort2Status";
            this.lblPort2Status.Size = new System.Drawing.Size(72, 13);
            this.lblPort2Status.TabIndex = 35;
            this.lblPort2Status.Text = "Port 2 Status";
            this.lblPort2Status.Click += new System.EventHandler(this.lblPort2Status_Click);
            // 
            // baudrateRFID
            // 
            this.baudrateRFID.Location = new System.Drawing.Point(132, 126);
            this.baudrateRFID.Margin = new System.Windows.Forms.Padding(4);
            this.baudrateRFID.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.baudrateRFID.Name = "baudrateRFID";
            this.baudrateRFID.Size = new System.Drawing.Size(77, 20);
            this.baudrateRFID.TabIndex = 36;
            this.baudrateRFID.Value = new decimal(new int[] {
            57600,
            0,
            0,
            0});
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 191);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "MEASUREMENT PORT";
            // 
            // btnSetActive
            // 
            this.btnSetActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetActive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetActive.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetActive.Depth = 0;
            this.btnSetActive.HighEmphasis = true;
            this.btnSetActive.Icon = null;
            this.btnSetActive.Location = new System.Drawing.Point(155, 466);
            this.btnSetActive.Margin = new System.Windows.Forms.Padding(5, 7, 6, 7);
            this.btnSetActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetActive.Name = "btnSetActive";
            this.btnSetActive.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetActive.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnSetActive.Size = new System.Drawing.Size(64, 36);
            this.btnSetActive.TabIndex = 38;
            this.btnSetActive.Text = "SET";
            this.btnSetActive.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetActive.UseAccentColor = true;
            this.btnSetActive.UseVisualStyleBackColor = true;
            this.btnSetActive.Click += new System.EventHandler(this.btnSetActive_Click);
            // 
            // cbxTimeZone
            // 
            this.cbxTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxTimeZone.AutoResize = false;
            this.cbxTimeZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTimeZone.Depth = 0;
            this.cbxTimeZone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTimeZone.DropDownHeight = 174;
            this.cbxTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeZone.DropDownWidth = 121;
            this.cbxTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTimeZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTimeZone.FormattingEnabled = true;
            this.cbxTimeZone.Hint = "TIMEZONE";
            this.cbxTimeZone.IntegralHeight = false;
            this.cbxTimeZone.ItemHeight = 43;
            this.cbxTimeZone.Location = new System.Drawing.Point(7, 461);
            this.cbxTimeZone.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTimeZone.MaxDropDownItems = 4;
            this.cbxTimeZone.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTimeZone.Name = "cbxTimeZone";
            this.cbxTimeZone.Size = new System.Drawing.Size(146, 49);
            this.cbxTimeZone.StartIndex = 0;
            this.cbxTimeZone.TabIndex = 39;
            this.cbxTimeZone.SelectedIndexChanged += new System.EventHandler(this.cbxTimeZone_SelectedIndexChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.CustomColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(7, 620);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnLogOut.Size = new System.Drawing.Size(78, 36);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisconnect.CustomColor = System.Drawing.Color.DarkRed;
            this.btnDisconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDisconnect.Depth = 0;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.HighEmphasis = true;
            this.btnDisconnect.Icon = null;
            this.btnDisconnect.Location = new System.Drawing.Point(7, 343);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDisconnect.Size = new System.Drawing.Size(112, 36);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDisconnect.UseAccentColor = false;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 666);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.cbxTimeZone);
            this.Controls.Add(this.btnSetActive);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.baudrateRFID);
            this.Controls.Add(this.lblPort2Status);
            this.Controls.Add(this.cbxPort2);
            this.Controls.Add(this.panelMenu2);
            this.Controls.Add(this.btnBackUP);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.NUDBaudRate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ContentCard);
            this.Controls.Add(this.lblPortStatus);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMainMenu";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPTHCHK";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudrateRFID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private Custom.CustomMaterialButton btnDisconnect;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private System.Windows.Forms.NumericUpDown NUDBaudRate;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cbxPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Label lblStatus;
        private MaterialSkin.Controls.MaterialCard ContentCard;
        private MaterialSkin.Controls.MaterialButton btnBackUP;
        private Custom.CustomMaterialButton btnLogOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort SPRegis;
        private System.Windows.Forms.Label lblPortStatus;
        private System.Windows.Forms.Panel panelMenu2;
        private MaterialSkin.Controls.MaterialComboBox cbxPort2;
        private System.Windows.Forms.Label lblPort2Status;
        private System.Windows.Forms.NumericUpDown baudrateRFID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnSetActive;
        private MaterialSkin.Controls.MaterialComboBox cbxTimeZone;
    }
}