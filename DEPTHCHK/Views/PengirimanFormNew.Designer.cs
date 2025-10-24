namespace DEPTHCHK.Views
{
    partial class PengirimanFormNew
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.leftbottomPanel = new System.Windows.Forms.Panel();
            this.grpDetailPengiriman = new System.Windows.Forms.GroupBox();
            this.FLDetailPengiriman = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.chkAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPengiriman = new System.Windows.Forms.DataGridView();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPengirimanLive = new System.Windows.Forms.DataGridView();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.txtSerialLog = new System.Windows.Forms.RichTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnSavePrint = new MaterialSkin.Controls.MaterialButton();
            this.btnGetData = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentNoPlat = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentCapacity = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentJlhCompartment = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentType = new MaterialSkin.Controls.MaterialLabel();
            this.chkPrintPreview = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.btnDelete = new DEPTHCHK.Custom.CustomMaterialButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.dtpPengTo = new System.Windows.Forms.DateTimePicker();
            this.dtpPengFrom = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxPengSearchBy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearchPeng = new MaterialSkin.Controls.MaterialTextBox2();
            this.LeftPanel.SuspendLayout();
            this.leftbottomPanel.SuspendLayout();
            this.grpDetailPengiriman.SuspendLayout();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).BeginInit();
            this.UpPanel.SuspendLayout();
            this.contentpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengirimanLive)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.leftbottomPanel);
            this.LeftPanel.Controls.Add(this.LeftCard);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(3, 100);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(811, 608);
            this.LeftPanel.TabIndex = 0;
            // 
            // leftbottomPanel
            // 
            this.leftbottomPanel.Controls.Add(this.grpDetailPengiriman);
            this.leftbottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftbottomPanel.Location = new System.Drawing.Point(0, 257);
            this.leftbottomPanel.Name = "leftbottomPanel";
            this.leftbottomPanel.Size = new System.Drawing.Size(811, 351);
            this.leftbottomPanel.TabIndex = 10;
            // 
            // grpDetailPengiriman
            // 
            this.grpDetailPengiriman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.grpDetailPengiriman.Controls.Add(this.FLDetailPengiriman);
            this.grpDetailPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetailPengiriman.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpDetailPengiriman.Location = new System.Drawing.Point(0, 0);
            this.grpDetailPengiriman.Name = "grpDetailPengiriman";
            this.grpDetailPengiriman.Size = new System.Drawing.Size(811, 351);
            this.grpDetailPengiriman.TabIndex = 0;
            this.grpDetailPengiriman.TabStop = false;
            this.grpDetailPengiriman.Text = "DETAIL PENGIRIMAN";
            // 
            // FLDetailPengiriman
            // 
            this.FLDetailPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLDetailPengiriman.Location = new System.Drawing.Point(3, 16);
            this.FLDetailPengiriman.Name = "FLDetailPengiriman";
            this.FLDetailPengiriman.Size = new System.Drawing.Size(805, 332);
            this.FLDetailPengiriman.TabIndex = 0;
            // 
            // LeftCard
            // 
            this.LeftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftCard.Controls.Add(this.chkAll);
            this.LeftCard.Controls.Add(this.materialLabel1);
            this.LeftCard.Controls.Add(this.dgvPengiriman);
            this.LeftCard.Depth = 0;
            this.LeftCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftCard.Location = new System.Drawing.Point(0, 0);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(14);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(3);
            this.LeftCard.Size = new System.Drawing.Size(811, 257);
            this.LeftCard.TabIndex = 9;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Depth = 0;
            this.chkAll.Location = new System.Drawing.Point(172, 3);
            this.chkAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAll.Name = "chkAll";
            this.chkAll.ReadOnly = false;
            this.chkAll.Ripple = true;
            this.chkAll.Size = new System.Drawing.Size(124, 37);
            this.chkAll.TabIndex = 29;
            this.chkAll.Text = "SELECT ALL";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "DAFTAR PENGIRIMAN";
            // 
            // dgvPengiriman
            // 
            this.dgvPengiriman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengiriman.Location = new System.Drawing.Point(6, 43);
            this.dgvPengiriman.Name = "dgvPengiriman";
            this.dgvPengiriman.Size = new System.Drawing.Size(799, 208);
            this.dgvPengiriman.TabIndex = 0;
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.UpPanel.Controls.Add(this.chkPrintPreview);
            this.UpPanel.Controls.Add(this.lblPortStatus);
            this.UpPanel.Controls.Add(this.btnDelete);
            this.UpPanel.Controls.Add(this.btnPrint);
            this.UpPanel.Controls.Add(this.btnFilter);
            this.UpPanel.Controls.Add(this.dtpPengTo);
            this.UpPanel.Controls.Add(this.dtpPengFrom);
            this.UpPanel.Controls.Add(this.materialLabel10);
            this.UpPanel.Controls.Add(this.cbxPengSearchBy);
            this.UpPanel.Controls.Add(this.materialLabel9);
            this.UpPanel.Controls.Add(this.txtSearchPeng);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(3, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1290, 100);
            this.UpPanel.TabIndex = 1;
            // 
            // contentpanel
            // 
            this.contentpanel.Controls.Add(this.groupBox1);
            this.contentpanel.Controls.Add(this.RightPanel);
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(814, 100);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(479, 608);
            this.contentpanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.groupBox1.Controls.Add(this.dgvPengirimanLive);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 351);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEASUREMENT";
            // 
            // dgvPengirimanLive
            // 
            this.dgvPengirimanLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengirimanLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPengirimanLive.Location = new System.Drawing.Point(3, 16);
            this.dgvPengirimanLive.Name = "dgvPengirimanLive";
            this.dgvPengirimanLive.Size = new System.Drawing.Size(473, 332);
            this.dgvPengirimanLive.TabIndex = 12;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.txtSerialLog);
            this.RightPanel.Controls.Add(this.materialCard1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(3);
            this.RightPanel.Size = new System.Drawing.Size(479, 257);
            this.RightPanel.TabIndex = 3;
            // 
            // txtSerialLog
            // 
            this.txtSerialLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.txtSerialLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSerialLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSerialLog.Location = new System.Drawing.Point(3, 112);
            this.txtSerialLog.Name = "txtSerialLog";
            this.txtSerialLog.Size = new System.Drawing.Size(473, 142);
            this.txtSerialLog.TabIndex = 15;
            this.txtSerialLog.Text = "";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnSavePrint);
            this.materialCard1.Controls.Add(this.btnGetData);
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.lblCurrentNoPlat);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.lblCurrentCapacity);
            this.materialCard1.Controls.Add(this.lblCurrentJlhCompartment);
            this.materialCard1.Controls.Add(this.lblCurrentType);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(473, 109);
            this.materialCard1.TabIndex = 16;
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSavePrint.Depth = 0;
            this.btnSavePrint.HighEmphasis = true;
            this.btnSavePrint.Icon = null;
            this.btnSavePrint.Location = new System.Drawing.Point(336, 57);
            this.btnSavePrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSavePrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSavePrint.Size = new System.Drawing.Size(134, 36);
            this.btnSavePrint.TabIndex = 45;
            this.btnSavePrint.Text = "SAVE N PRINT[2]";
            this.btnSavePrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSavePrint.UseAccentColor = true;
            this.btnSavePrint.UseVisualStyleBackColor = true;
            // 
            // btnGetData
            // 
            this.btnGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGetData.Depth = 0;
            this.btnGetData.HighEmphasis = true;
            this.btnGetData.Icon = null;
            this.btnGetData.Location = new System.Drawing.Point(397, 9);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGetData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGetData.Size = new System.Drawing.Size(69, 36);
            this.btnGetData.TabIndex = 34;
            this.btnGetData.Text = "GET [1]";
            this.btnGetData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGetData.UseAccentColor = false;
            this.btnGetData.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(17, 9);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(49, 19);
            this.materialLabel11.TabIndex = 44;
            this.materialLabel11.Text = "NoPlat";
            // 
            // lblCurrentNoPlat
            // 
            this.lblCurrentNoPlat.AutoSize = true;
            this.lblCurrentNoPlat.Depth = 0;
            this.lblCurrentNoPlat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentNoPlat.Location = new System.Drawing.Point(139, 9);
            this.lblCurrentNoPlat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentNoPlat.Name = "lblCurrentNoPlat";
            this.lblCurrentNoPlat.Size = new System.Drawing.Size(49, 19);
            this.lblCurrentNoPlat.TabIndex = 43;
            this.lblCurrentNoPlat.Text = "NoPlat";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 82);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "Capacity";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(17, 57);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(98, 19);
            this.materialLabel6.TabIndex = 41;
            this.materialLabel6.Text = "Compartment";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 34);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(36, 19);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "Type";
            // 
            // lblCurrentCapacity
            // 
            this.lblCurrentCapacity.AutoSize = true;
            this.lblCurrentCapacity.Depth = 0;
            this.lblCurrentCapacity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentCapacity.Location = new System.Drawing.Point(139, 82);
            this.lblCurrentCapacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentCapacity.Name = "lblCurrentCapacity";
            this.lblCurrentCapacity.Size = new System.Drawing.Size(63, 19);
            this.lblCurrentCapacity.TabIndex = 39;
            this.lblCurrentCapacity.Text = "Capacity";
            // 
            // lblCurrentJlhCompartment
            // 
            this.lblCurrentJlhCompartment.AutoSize = true;
            this.lblCurrentJlhCompartment.Depth = 0;
            this.lblCurrentJlhCompartment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentJlhCompartment.Location = new System.Drawing.Point(139, 57);
            this.lblCurrentJlhCompartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentJlhCompartment.Name = "lblCurrentJlhCompartment";
            this.lblCurrentJlhCompartment.Size = new System.Drawing.Size(98, 19);
            this.lblCurrentJlhCompartment.TabIndex = 38;
            this.lblCurrentJlhCompartment.Text = "Compartment";
            // 
            // lblCurrentType
            // 
            this.lblCurrentType.AutoSize = true;
            this.lblCurrentType.Depth = 0;
            this.lblCurrentType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentType.Location = new System.Drawing.Point(139, 34);
            this.lblCurrentType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentType.Name = "lblCurrentType";
            this.lblCurrentType.Size = new System.Drawing.Size(36, 19);
            this.lblCurrentType.TabIndex = 37;
            this.lblCurrentType.Text = "Type";
            // 
            // chkPrintPreview
            // 
            this.chkPrintPreview.AutoSize = true;
            this.chkPrintPreview.Depth = 0;
            this.chkPrintPreview.Location = new System.Drawing.Point(1129, 47);
            this.chkPrintPreview.Margin = new System.Windows.Forms.Padding(0);
            this.chkPrintPreview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPrintPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPrintPreview.Name = "chkPrintPreview";
            this.chkPrintPreview.ReadOnly = false;
            this.chkPrintPreview.Ripple = true;
            this.chkPrintPreview.Size = new System.Drawing.Size(150, 37);
            this.chkPrintPreview.TabIndex = 46;
            this.chkPrintPreview.Text = "PRINT PREVIEW";
            this.chkPrintPreview.UseVisualStyleBackColor = true;
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.ForeColor = System.Drawing.Color.White;
            this.lblPortStatus.Location = new System.Drawing.Point(807, 81);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(63, 13);
            this.lblPortStatus.TabIndex = 51;
            this.lblPortStatus.Text = "Port Status";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.CustomColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(82, 26);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = true;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(11, 26);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(64, 36);
            this.btnPrint.TabIndex = 49;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(915, 26);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(68, 36);
            this.btnFilter.TabIndex = 48;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dtpPengTo
            // 
            this.dtpPengTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpPengTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPengTo.Location = new System.Drawing.Point(699, 52);
            this.dtpPengTo.Name = "dtpPengTo";
            this.dtpPengTo.Size = new System.Drawing.Size(200, 20);
            this.dtpPengTo.TabIndex = 47;
            // 
            // dtpPengFrom
            // 
            this.dtpPengFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpPengFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPengFrom.Location = new System.Drawing.Point(699, 26);
            this.dtpPengFrom.Name = "dtpPengFrom";
            this.dtpPengFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpPengFrom.TabIndex = 45;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(699, 6);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(211, 19);
            this.materialLabel10.TabIndex = 44;
            this.materialLabel10.Text = "FILTER TGL_INPUT FROM TO";
            // 
            // cbxPengSearchBy
            // 
            this.cbxPengSearchBy.AutoResize = false;
            this.cbxPengSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPengSearchBy.Depth = 0;
            this.cbxPengSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPengSearchBy.DropDownHeight = 174;
            this.cbxPengSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPengSearchBy.DropDownWidth = 121;
            this.cbxPengSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPengSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPengSearchBy.FormattingEnabled = true;
            this.cbxPengSearchBy.IntegralHeight = false;
            this.cbxPengSearchBy.ItemHeight = 43;
            this.cbxPengSearchBy.Location = new System.Drawing.Point(568, 25);
            this.cbxPengSearchBy.MaxDropDownItems = 4;
            this.cbxPengSearchBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPengSearchBy.Name = "cbxPengSearchBy";
            this.cbxPengSearchBy.Size = new System.Drawing.Size(125, 49);
            this.cbxPengSearchBy.StartIndex = 0;
            this.cbxPengSearchBy.TabIndex = 43;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(578, 6);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(89, 19);
            this.materialLabel9.TabIndex = 42;
            this.materialLabel9.Text = "SEARCH BY:";
            // 
            // txtSearchPeng
            // 
            this.txtSearchPeng.AnimateReadOnly = false;
            this.txtSearchPeng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchPeng.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchPeng.Depth = 0;
            this.txtSearchPeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPeng.HideSelection = true;
            this.txtSearchPeng.Hint = "SEARCH PENGIRIMAN";
            this.txtSearchPeng.LeadingIcon = null;
            this.txtSearchPeng.Location = new System.Drawing.Point(172, 26);
            this.txtSearchPeng.MaxLength = 32767;
            this.txtSearchPeng.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchPeng.Name = "txtSearchPeng";
            this.txtSearchPeng.PasswordChar = '\0';
            this.txtSearchPeng.PrefixSuffixText = null;
            this.txtSearchPeng.ReadOnly = false;
            this.txtSearchPeng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchPeng.SelectedText = "";
            this.txtSearchPeng.SelectionLength = 0;
            this.txtSearchPeng.SelectionStart = 0;
            this.txtSearchPeng.ShortcutsEnabled = true;
            this.txtSearchPeng.Size = new System.Drawing.Size(390, 48);
            this.txtSearchPeng.TabIndex = 41;
            this.txtSearchPeng.TabStop = false;
            this.txtSearchPeng.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchPeng.TrailingIcon = null;
            this.txtSearchPeng.UseSystemPasswordChar = false;
            // 
            // PengirimanFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 711);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.UpPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "PengirimanFormNew";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "PengirimanFormNew";
            this.Load += new System.EventHandler(this.PengirimanFormNew_Load);
            this.LeftPanel.ResumeLayout(false);
            this.leftbottomPanel.ResumeLayout(false);
            this.grpDetailPengiriman.ResumeLayout(false);
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).EndInit();
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.contentpanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengirimanLive)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel leftbottomPanel;
        private System.Windows.Forms.GroupBox grpDetailPengiriman;
        private System.Windows.Forms.FlowLayoutPanel FLDetailPengiriman;
        private MaterialSkin.Controls.MaterialCard LeftCard;
        private MaterialSkin.Controls.MaterialCheckbox chkAll;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvPengiriman;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.RichTextBox txtSerialLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPengirimanLive;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel lblCurrentNoPlat;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblCurrentCapacity;
        private MaterialSkin.Controls.MaterialLabel lblCurrentJlhCompartment;
        private MaterialSkin.Controls.MaterialLabel lblCurrentType;
        private MaterialSkin.Controls.MaterialButton btnSavePrint;
        private MaterialSkin.Controls.MaterialButton btnGetData;
        private MaterialSkin.Controls.MaterialCheckbox chkPrintPreview;
        private System.Windows.Forms.Label lblPortStatus;
        private Custom.CustomMaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.DateTimePicker dtpPengTo;
        private System.Windows.Forms.DateTimePicker dtpPengFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox cbxPengSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchPeng;
    }
}