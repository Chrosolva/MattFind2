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
            this.SPRegis = new System.IO.Ports.SerialPort(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.btnBackUP = new MaterialSkin.Controls.MaterialButton();
            this.btnLogOut = new SEALCHK.Custom.CustomMaterialButton();
            this.ContentCard = new MaterialSkin.Controls.MaterialCard();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxPort = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.NUDBaudRate = new System.Windows.Forms.NumericUpDown();
            this.btnDisconnect = new SEALCHK.Custom.CustomMaterialButton();
            this.btnSetActive = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbxTimeZone = new System.Windows.Forms.ComboBox();
            this.panelMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBaudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu2
            // 
            this.panelMenu2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelMenu2.Controls.Add(this.btnBackUP);
            this.panelMenu2.Controls.Add(this.btnLogOut);
            this.panelMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu2.Location = new System.Drawing.Point(3, 64);
            this.panelMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panelMenu2.Size = new System.Drawing.Size(204, 565);
            this.panelMenu2.TabIndex = 1;
            // 
            // btnBackUP
            // 
            this.btnBackUP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackUP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackUP.Depth = 0;
            this.btnBackUP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBackUP.HighEmphasis = true;
            this.btnBackUP.Icon = null;
            this.btnBackUP.Location = new System.Drawing.Point(0, 493);
            this.btnBackUP.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBackUP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackUP.Name = "btnBackUP";
            this.btnBackUP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackUP.Size = new System.Drawing.Size(204, 36);
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
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(0, 529);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Size = new System.Drawing.Size(204, 36);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LOGOUT";
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
            this.ContentCard.Location = new System.Drawing.Point(212, 73);
            this.ContentCard.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.ContentCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContentCard.Name = "ContentCard";
            this.ContentCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentCard.Size = new System.Drawing.Size(1436, 502);
            this.ContentCard.TabIndex = 2;
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(226, 605);
            this.lblPortStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(76, 19);
            this.lblPortStatus.TabIndex = 12;
            this.lblPortStatus.Text = "Port Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(226, 581);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(289, 17);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "CONNECTED TO LOCALHOST , USER ID = ";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(835, 597);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(70, 19);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "BaudRate";
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
            this.cbxPort.Location = new System.Drawing.Point(655, 581);
            this.cbxPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPort.MaxDropDownItems = 4;
            this.cbxPort.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(169, 49);
            this.cbxPort.StartIndex = 0;
            this.cbxPort.TabIndex = 13;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(591, 602);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(1005, 588);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnect.Size = new System.Drawing.Size(89, 36);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // NUDBaudRate
            // 
            this.NUDBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NUDBaudRate.Location = new System.Drawing.Point(918, 591);
            this.NUDBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.NUDBaudRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDBaudRate.Name = "NUDBaudRate";
            this.NUDBaudRate.Size = new System.Drawing.Size(77, 22);
            this.NUDBaudRate.TabIndex = 17;
            this.NUDBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
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
            this.btnDisconnect.Location = new System.Drawing.Point(1103, 588);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDisconnect.Size = new System.Drawing.Size(112, 36);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDisconnect.UseAccentColor = false;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSetActive
            // 
            this.btnSetActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetActive.Location = new System.Drawing.Point(1272, 580);
            this.btnSetActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetActive.Name = "btnSetActive";
            this.btnSetActive.Size = new System.Drawing.Size(63, 28);
            this.btnSetActive.TabIndex = 18;
            this.btnSetActive.Text = "SET";
            this.btnSetActive.UseVisualStyleBackColor = true;
            this.btnSetActive.Click += new System.EventHandler(this.btnSetActive_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1268, 612);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 17);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "TIME";
            // 
            // cbxTimeZone
            // 
            this.cbxTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTimeZone.FormattingEnabled = true;
            this.cbxTimeZone.Location = new System.Drawing.Point(1343, 580);
            this.cbxTimeZone.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTimeZone.Name = "cbxTimeZone";
            this.cbxTimeZone.Size = new System.Drawing.Size(160, 24);
            this.cbxTimeZone.TabIndex = 19;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 632);
            this.Controls.Add(this.btnSetActive);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbxTimeZone);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.NUDBaudRate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblPortStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ContentCard);
            this.Controls.Add(this.panelMenu2);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panelMenu2.ResumeLayout(false);
            this.panelMenu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBaudRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SPRegis;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panelMenu2;
        private MaterialSkin.Controls.MaterialButton btnBackUP;
        private SEALCHK.Custom.CustomMaterialButton btnLogOut;
        private MaterialSkin.Controls.MaterialCard ContentCard;
        private System.Windows.Forms.Label lblPortStatus;
        private System.Windows.Forms.Label lblStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cbxPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private System.Windows.Forms.NumericUpDown NUDBaudRate;
        private SEALCHK.Custom.CustomMaterialButton btnDisconnect;
        private System.Windows.Forms.Button btnSetActive;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbxTimeZone;
    }
}