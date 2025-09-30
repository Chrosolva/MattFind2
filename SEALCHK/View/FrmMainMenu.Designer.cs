namespace SEALCHK.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.btnBackUP = new MaterialSkin.Controls.MaterialButton();
            this.btnLogOut = new SEALCHK.CustomMaterialButton();
            this.ContentCard = new MaterialSkin.Controls.MaterialCard();
            this.cbxTimeZone = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSetActive = new System.Windows.Forms.Button();
            this.cbxPort = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.NUDBaudRate = new System.Windows.Forms.NumericUpDown();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.SPRegis = new System.IO.Ports.SerialPort(this.components);
            this.btnReconnect = new MaterialSkin.Controls.MaterialButton();
            this.btnDisconnect = new SEALCHK.CustomMaterialButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.panelMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBaudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu2
            // 
            this.panelMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelMenu2.Controls.Add(this.btnBackUP);
            this.panelMenu2.Controls.Add(this.btnLogOut);
            this.panelMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu2.Location = new System.Drawing.Point(4, 79);
            this.panelMenu2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panelMenu2.Size = new System.Drawing.Size(192, 694);
            this.panelMenu2.TabIndex = 0;
            // 
            // btnBackUP
            // 
            this.btnBackUP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackUP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackUP.Depth = 0;
            this.btnBackUP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBackUP.HighEmphasis = true;
            this.btnBackUP.Icon = null;
            this.btnBackUP.Location = new System.Drawing.Point(0, 622);
            this.btnBackUP.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBackUP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackUP.Name = "btnBackUP";
            this.btnBackUP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackUP.Size = new System.Drawing.Size(192, 36);
            this.btnBackUP.TabIndex = 1;
            this.btnBackUP.Text = "BACK UP DB";
            this.btnBackUP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackUP.UseAccentColor = true;
            this.btnBackUP.UseVisualStyleBackColor = true;
            this.btnBackUP.Click += new System.EventHandler(this.btnBackUP_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.CustomColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(0, 658);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Size = new System.Drawing.Size(192, 36);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ContentCard
            // 
            this.ContentCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentCard.AutoScroll = true;
            this.ContentCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContentCard.Depth = 0;
            this.ContentCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContentCard.Location = new System.Drawing.Point(200, 82);
            this.ContentCard.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.ContentCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContentCard.Name = "ContentCard";
            this.ContentCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentCard.Size = new System.Drawing.Size(1612, 628);
            this.ContentCard.TabIndex = 1;
            // 
            // cbxTimeZone
            // 
            this.cbxTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTimeZone.FormattingEnabled = true;
            this.cbxTimeZone.Location = new System.Drawing.Point(1559, 720);
            this.cbxTimeZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTimeZone.Name = "cbxTimeZone";
            this.cbxTimeZone.Size = new System.Drawing.Size(160, 24);
            this.cbxTimeZone.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1484, 752);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "TIME";
            // 
            // btnSetActive
            // 
            this.btnSetActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetActive.Location = new System.Drawing.Point(1488, 720);
            this.btnSetActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetActive.Name = "btnSetActive";
            this.btnSetActive.Size = new System.Drawing.Size(63, 28);
            this.btnSetActive.TabIndex = 0;
            this.btnSetActive.Text = "SET";
            this.btnSetActive.UseVisualStyleBackColor = true;
            this.btnSetActive.Click += new System.EventHandler(this.btnSetActive_Click);
            // 
            // cbxPort
            // 
            this.cbxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.cbxPort.Location = new System.Drawing.Point(661, 716);
            this.cbxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPort.MaxDropDownItems = 4;
            this.cbxPort.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(169, 49);
            this.cbxPort.StartIndex = 0;
            this.cbxPort.TabIndex = 6;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(597, 737);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "PORT";
            // 
            // NUDBaudRate
            // 
            this.NUDBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NUDBaudRate.Location = new System.Drawing.Point(956, 731);
            this.NUDBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUDBaudRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDBaudRate.Name = "NUDBaudRate";
            this.NUDBaudRate.Size = new System.Drawing.Size(77, 22);
            this.NUDBaudRate.TabIndex = 9;
            this.NUDBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(841, 732);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(70, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "BaudRate";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(1043, 728);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnect.Size = new System.Drawing.Size(89, 36);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnReconnect
            // 
            this.btnReconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReconnect.Depth = 0;
            this.btnReconnect.HighEmphasis = true;
            this.btnReconnect.Icon = null;
            this.btnReconnect.Location = new System.Drawing.Point(1332, 728);
            this.btnReconnect.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnReconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReconnect.Size = new System.Drawing.Size(74, 36);
            this.btnReconnect.TabIndex = 11;
            this.btnReconnect.Text = "RE-CON";
            this.btnReconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReconnect.UseAccentColor = false;
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Visible = false;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisconnect.CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDisconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDisconnect.Depth = 0;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.HighEmphasis = true;
            this.btnDisconnect.Icon = null;
            this.btnDisconnect.Location = new System.Drawing.Point(1172, 727);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDisconnect.Size = new System.Drawing.Size(112, 36);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDisconnect.UseAccentColor = false;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(205, 724);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(289, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "CONNECTED TO LOCALHOST , USER ID = ";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(205, 748);
            this.lblPortStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(76, 19);
            this.lblPortStatus.TabIndex = 10;
            this.lblPortStatus.Text = "Port Status";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 777);
            this.Controls.Add(this.btnReconnect);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblPortStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.NUDBaudRate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.btnSetActive);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbxTimeZone);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ContentCard);
            this.Controls.Add(this.panelMenu2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMainMenu";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "SEAL CHECK";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panelMenu2.ResumeLayout(false);
            this.panelMenu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBaudRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu2;
        private MaterialSkin.Controls.MaterialCard ContentCard;
        private CustomMaterialButton btnLogOut;
        private System.Windows.Forms.ComboBox cbxTimeZone;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSetActive;
        private MaterialSkin.Controls.MaterialComboBox cbxPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.NumericUpDown NUDBaudRate;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private CustomMaterialButton btnDisconnect;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private System.IO.Ports.SerialPort SPRegis;
        private MaterialSkin.Controls.MaterialButton btnBackUP;
        public MaterialSkin.Controls.MaterialButton btnReconnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPortStatus;
    }
}