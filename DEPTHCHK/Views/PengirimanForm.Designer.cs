namespace DEPTHCHK.Views
{
    partial class PengirimanForm
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
            this.TCPengiriman = new MaterialSkin.Controls.MaterialTabControl();
            this.TPPengiriman = new System.Windows.Forms.TabPage();
            this.RightCard = new MaterialSkin.Controls.MaterialCard();
            this.dgvDetailPengiriman = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.chkAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPengiriman = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.UpCard = new MaterialSkin.Controls.MaterialCard();
            this.btnDelete = new DEPTHCHK.Custom.CustomMaterialButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.dtpPengTo = new System.Windows.Forms.DateTimePicker();
            this.dtpPengFrom = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxPengSearchBy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearchPeng = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.TPAddPengiriman = new System.Windows.Forms.TabPage();
            this.CardCRUD = new MaterialSkin.Controls.MaterialCard();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.grpRegisLive = new System.Windows.Forms.GroupBox();
            this.dgvPengirimanLive = new System.Windows.Forms.DataGridView();
            this.pnlTopRLive = new System.Windows.Forms.Panel();
            this.btnSendACK = new MaterialSkin.Controls.MaterialButton();
            this.btnReListen = new MaterialSkin.Controls.MaterialButton();
            this.btnRelistenAll = new MaterialSkin.Controls.MaterialButton();
            this.btnClearLog = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnStartListen = new MaterialSkin.Controls.MaterialButton();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.txtSerialLog = new System.Windows.Forms.RichTextBox();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.lblRFID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.lblIDPengiriman = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNoPlat = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.pnlTujuan = new System.Windows.Forms.Panel();
            this.btnSetTujuan = new MaterialSkin.Controls.MaterialButton();
            this.txtTujuan = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblJlhCapacity = new MaterialSkin.Controls.MaterialLabel();
            this.lblJlhCompartment = new MaterialSkin.Controls.MaterialLabel();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TCPengiriman.SuspendLayout();
            this.TPPengiriman.SuspendLayout();
            this.RightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPengiriman)).BeginInit();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.UpCard.SuspendLayout();
            this.TPAddPengiriman.SuspendLayout();
            this.CardCRUD.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.grpRegisLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengirimanLive)).BeginInit();
            this.pnlTopRLive.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.pnlTujuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCPengiriman
            // 
            this.TCPengiriman.Controls.Add(this.TPPengiriman);
            this.TCPengiriman.Controls.Add(this.TPAddPengiriman);
            this.TCPengiriman.Depth = 0;
            this.TCPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCPengiriman.Location = new System.Drawing.Point(0, 48);
            this.TCPengiriman.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCPengiriman.Multiline = true;
            this.TCPengiriman.Name = "TCPengiriman";
            this.TCPengiriman.SelectedIndex = 0;
            this.TCPengiriman.Size = new System.Drawing.Size(1085, 528);
            this.TCPengiriman.TabIndex = 6;
            // 
            // TPPengiriman
            // 
            this.TPPengiriman.Controls.Add(this.RightCard);
            this.TPPengiriman.Controls.Add(this.LeftCard);
            this.TPPengiriman.Controls.Add(this.TopPanel);
            this.TPPengiriman.Location = new System.Drawing.Point(4, 22);
            this.TPPengiriman.Name = "TPPengiriman";
            this.TPPengiriman.Padding = new System.Windows.Forms.Padding(3);
            this.TPPengiriman.Size = new System.Drawing.Size(1077, 502);
            this.TPPengiriman.TabIndex = 0;
            this.TPPengiriman.Text = "DAFTAR PENGIRIMAN";
            this.TPPengiriman.UseVisualStyleBackColor = true;
            // 
            // RightCard
            // 
            this.RightCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightCard.Controls.Add(this.dgvDetailPengiriman);
            this.RightCard.Controls.Add(this.materialLabel2);
            this.RightCard.Depth = 0;
            this.RightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RightCard.Location = new System.Drawing.Point(3, 384);
            this.RightCard.Margin = new System.Windows.Forms.Padding(14);
            this.RightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightCard.Name = "RightCard";
            this.RightCard.Padding = new System.Windows.Forms.Padding(3);
            this.RightCard.Size = new System.Drawing.Size(1071, 115);
            this.RightCard.TabIndex = 9;
            // 
            // dgvDetailPengiriman
            // 
            this.dgvDetailPengiriman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPengiriman.Location = new System.Drawing.Point(6, 29);
            this.dgvDetailPengiriman.Name = "dgvDetailPengiriman";
            this.dgvDetailPengiriman.Size = new System.Drawing.Size(1059, 78);
            this.dgvDetailPengiriman.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "DETAIL PENGIRIMAN";
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
            this.LeftCard.Location = new System.Drawing.Point(3, 83);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(14);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(3);
            this.LeftCard.Size = new System.Drawing.Size(1071, 301);
            this.LeftCard.TabIndex = 8;
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
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 7);
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
            this.dgvPengiriman.Size = new System.Drawing.Size(1059, 252);
            this.dgvPengiriman.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.UpCard);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1071, 80);
            this.TopPanel.TabIndex = 0;
            // 
            // UpCard
            // 
            this.UpCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpCard.Controls.Add(this.btnDelete);
            this.UpCard.Controls.Add(this.btnPrint);
            this.UpCard.Controls.Add(this.btnFilter);
            this.UpCard.Controls.Add(this.dtpPengTo);
            this.UpCard.Controls.Add(this.dtpPengFrom);
            this.UpCard.Controls.Add(this.materialLabel10);
            this.UpCard.Controls.Add(this.cbxPengSearchBy);
            this.UpCard.Controls.Add(this.materialLabel9);
            this.UpCard.Controls.Add(this.txtSearchPeng);
            this.UpCard.Controls.Add(this.btnNew);
            this.UpCard.Depth = 0;
            this.UpCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpCard.Location = new System.Drawing.Point(0, 0);
            this.UpCard.Margin = new System.Windows.Forms.Padding(14);
            this.UpCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpCard.Name = "UpCard";
            this.UpCard.Padding = new System.Windows.Forms.Padding(14);
            this.UpCard.Size = new System.Drawing.Size(1071, 80);
            this.UpCard.TabIndex = 0;
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
            this.btnDelete.Location = new System.Drawing.Point(154, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = true;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(83, 29);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(64, 36);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(916, 29);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(68, 36);
            this.btnFilter.TabIndex = 31;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dtpPengTo
            // 
            this.dtpPengTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpPengTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPengTo.Location = new System.Drawing.Point(700, 55);
            this.dtpPengTo.Name = "dtpPengTo";
            this.dtpPengTo.Size = new System.Drawing.Size(200, 20);
            this.dtpPengTo.TabIndex = 30;
            // 
            // dtpPengFrom
            // 
            this.dtpPengFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpPengFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPengFrom.Location = new System.Drawing.Point(700, 29);
            this.dtpPengFrom.Name = "dtpPengFrom";
            this.dtpPengFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpPengFrom.TabIndex = 29;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(700, 9);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(211, 19);
            this.materialLabel10.TabIndex = 28;
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
            this.cbxPengSearchBy.Location = new System.Drawing.Point(569, 28);
            this.cbxPengSearchBy.MaxDropDownItems = 4;
            this.cbxPengSearchBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPengSearchBy.Name = "cbxPengSearchBy";
            this.cbxPengSearchBy.Size = new System.Drawing.Size(125, 49);
            this.cbxPengSearchBy.StartIndex = 0;
            this.cbxPengSearchBy.TabIndex = 27;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(579, 9);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(89, 19);
            this.materialLabel9.TabIndex = 26;
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
            this.txtSearchPeng.Location = new System.Drawing.Point(303, 29);
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
            this.txtSearchPeng.Size = new System.Drawing.Size(260, 48);
            this.txtSearchPeng.TabIndex = 8;
            this.txtSearchPeng.TabStop = false;
            this.txtSearchPeng.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchPeng.TrailingIcon = null;
            this.txtSearchPeng.UseSystemPasswordChar = false;
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = null;
            this.btnNew.Location = new System.Drawing.Point(11, 29);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(64, 36);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "ADD";
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // TPAddPengiriman
            // 
            this.TPAddPengiriman.Controls.Add(this.CardCRUD);
            this.TPAddPengiriman.Location = new System.Drawing.Point(4, 22);
            this.TPAddPengiriman.Name = "TPAddPengiriman";
            this.TPAddPengiriman.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddPengiriman.Size = new System.Drawing.Size(1077, 502);
            this.TPAddPengiriman.TabIndex = 1;
            this.TPAddPengiriman.Text = "ADD PENGIRIMAN";
            this.TPAddPengiriman.UseVisualStyleBackColor = true;
            // 
            // CardCRUD
            // 
            this.CardCRUD.AutoScroll = true;
            this.CardCRUD.AutoSize = true;
            this.CardCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardCRUD.Controls.Add(this.leftPanel);
            this.CardCRUD.Controls.Add(this.RightPanel);
            this.CardCRUD.Controls.Add(this.UpPanel);
            this.CardCRUD.Depth = 0;
            this.CardCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardCRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardCRUD.Location = new System.Drawing.Point(3, 3);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(14);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(8);
            this.CardCRUD.Size = new System.Drawing.Size(1071, 496);
            this.CardCRUD.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.grpRegisLive);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(8, 162);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(811, 326);
            this.leftPanel.TabIndex = 1;
            // 
            // grpRegisLive
            // 
            this.grpRegisLive.Controls.Add(this.dgvPengirimanLive);
            this.grpRegisLive.Controls.Add(this.pnlTopRLive);
            this.grpRegisLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegisLive.Location = new System.Drawing.Point(0, 0);
            this.grpRegisLive.Name = "grpRegisLive";
            this.grpRegisLive.Size = new System.Drawing.Size(811, 326);
            this.grpRegisLive.TabIndex = 31;
            this.grpRegisLive.TabStop = false;
            this.grpRegisLive.Text = "REGISTER DATA";
            // 
            // dgvPengirimanLive
            // 
            this.dgvPengirimanLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengirimanLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPengirimanLive.Location = new System.Drawing.Point(3, 82);
            this.dgvPengirimanLive.Name = "dgvPengirimanLive";
            this.dgvPengirimanLive.Size = new System.Drawing.Size(805, 241);
            this.dgvPengirimanLive.TabIndex = 11;
            // 
            // pnlTopRLive
            // 
            this.pnlTopRLive.Controls.Add(this.btnSendACK);
            this.pnlTopRLive.Controls.Add(this.btnReListen);
            this.pnlTopRLive.Controls.Add(this.btnRelistenAll);
            this.pnlTopRLive.Controls.Add(this.btnClearLog);
            this.pnlTopRLive.Controls.Add(this.btnSave);
            this.pnlTopRLive.Controls.Add(this.btnStartListen);
            this.pnlTopRLive.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopRLive.Location = new System.Drawing.Point(3, 16);
            this.pnlTopRLive.Name = "pnlTopRLive";
            this.pnlTopRLive.Size = new System.Drawing.Size(805, 66);
            this.pnlTopRLive.TabIndex = 13;
            // 
            // btnSendACK
            // 
            this.btnSendACK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendACK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSendACK.Depth = 0;
            this.btnSendACK.HighEmphasis = true;
            this.btnSendACK.Icon = null;
            this.btnSendACK.Location = new System.Drawing.Point(326, 9);
            this.btnSendACK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendACK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendACK.Name = "btnSendACK";
            this.btnSendACK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSendACK.Size = new System.Drawing.Size(90, 36);
            this.btnSendACK.TabIndex = 23;
            this.btnSendACK.Text = "GET DATA";
            this.btnSendACK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSendACK.UseAccentColor = false;
            this.btnSendACK.UseVisualStyleBackColor = true;
            this.btnSendACK.Click += new System.EventHandler(this.btnSendACK_Click);
            // 
            // btnReListen
            // 
            this.btnReListen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReListen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReListen.Depth = 0;
            this.btnReListen.HighEmphasis = true;
            this.btnReListen.Icon = null;
            this.btnReListen.Location = new System.Drawing.Point(226, 9);
            this.btnReListen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReListen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReListen.Name = "btnReListen";
            this.btnReListen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReListen.Size = new System.Drawing.Size(92, 36);
            this.btnReListen.TabIndex = 22;
            this.btnReListen.Text = "RE-LISTEN";
            this.btnReListen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReListen.UseAccentColor = false;
            this.btnReListen.UseVisualStyleBackColor = true;
            this.btnReListen.Click += new System.EventHandler(this.btnReListen_Click);
            // 
            // btnRelistenAll
            // 
            this.btnRelistenAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelistenAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRelistenAll.Depth = 0;
            this.btnRelistenAll.HighEmphasis = true;
            this.btnRelistenAll.Icon = null;
            this.btnRelistenAll.Location = new System.Drawing.Point(89, 8);
            this.btnRelistenAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRelistenAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelistenAll.Name = "btnRelistenAll";
            this.btnRelistenAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRelistenAll.Size = new System.Drawing.Size(121, 36);
            this.btnRelistenAll.TabIndex = 21;
            this.btnRelistenAll.Text = "RE-LISTEN ALL";
            this.btnRelistenAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRelistenAll.UseAccentColor = false;
            this.btnRelistenAll.UseVisualStyleBackColor = true;
            this.btnRelistenAll.Click += new System.EventHandler(this.btnRelistenAll_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearLog.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearLog.Depth = 0;
            this.btnClearLog.HighEmphasis = true;
            this.btnClearLog.Icon = null;
            this.btnClearLog.Location = new System.Drawing.Point(729, 9);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearLog.Size = new System.Drawing.Size(66, 36);
            this.btnClearLog.TabIndex = 20;
            this.btnClearLog.Text = "CLEAR";
            this.btnClearLog.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearLog.UseAccentColor = false;
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(584, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = true;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnStartListen
            // 
            this.btnStartListen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartListen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartListen.Depth = 0;
            this.btnStartListen.HighEmphasis = true;
            this.btnStartListen.Icon = null;
            this.btnStartListen.Location = new System.Drawing.Point(14, 8);
            this.btnStartListen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartListen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartListen.Size = new System.Drawing.Size(67, 36);
            this.btnStartListen.TabIndex = 15;
            this.btnStartListen.Text = "START ";
            this.btnStartListen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartListen.UseAccentColor = false;
            this.btnStartListen.UseVisualStyleBackColor = true;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.txtSerialLog);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(819, 162);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(3);
            this.RightPanel.Size = new System.Drawing.Size(244, 326);
            this.RightPanel.TabIndex = 2;
            // 
            // txtSerialLog
            // 
            this.txtSerialLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSerialLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialLog.Location = new System.Drawing.Point(3, 3);
            this.txtSerialLog.Name = "txtSerialLog";
            this.txtSerialLog.Size = new System.Drawing.Size(238, 320);
            this.txtSerialLog.TabIndex = 15;
            this.txtSerialLog.Text = "";
            // 
            // UpPanel
            // 
            this.UpPanel.AutoScroll = true;
            this.UpPanel.Controls.Add(this.btnBack);
            this.UpPanel.Controls.Add(this.lblRFID);
            this.UpPanel.Controls.Add(this.materialLabel4);
            this.UpPanel.Controls.Add(this.lblPortStatus);
            this.UpPanel.Controls.Add(this.lblIDPengiriman);
            this.UpPanel.Controls.Add(this.materialLabel3);
            this.UpPanel.Controls.Add(this.materialLabel11);
            this.UpPanel.Controls.Add(this.lblNoPlat);
            this.UpPanel.Controls.Add(this.materialLabel5);
            this.UpPanel.Controls.Add(this.materialLabel6);
            this.UpPanel.Controls.Add(this.materialLabel7);
            this.UpPanel.Controls.Add(this.grpRegister);
            this.UpPanel.Controls.Add(this.lblJlhCapacity);
            this.UpPanel.Controls.Add(this.lblJlhCompartment);
            this.UpPanel.Controls.Add(this.lblType);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(8, 8);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1055, 154);
            this.UpPanel.TabIndex = 0;
            this.UpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpPanel_Paint);
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(756, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(64, 36);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Depth = 0;
            this.lblRFID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRFID.Location = new System.Drawing.Point(248, 87);
            this.lblRFID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(35, 19);
            this.lblRFID.TabIndex = 41;
            this.lblRFID.Text = "RFID";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(215, 87);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(35, 19);
            this.materialLabel4.TabIndex = 40;
            this.materialLabel4.Text = "RFID";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(14, 136);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(63, 13);
            this.lblPortStatus.TabIndex = 39;
            this.lblPortStatus.Text = "Port Status";
            // 
            // lblIDPengiriman
            // 
            this.lblIDPengiriman.AutoSize = true;
            this.lblIDPengiriman.Depth = 0;
            this.lblIDPengiriman.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIDPengiriman.Location = new System.Drawing.Point(136, 8);
            this.lblIDPengiriman.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIDPengiriman.Name = "lblIDPengiriman";
            this.lblIDPengiriman.Size = new System.Drawing.Size(105, 19);
            this.lblIDPengiriman.TabIndex = 38;
            this.lblIDPengiriman.Text = "ID Pengiriman ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 8);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "ID Pengiriman";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(14, 39);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(49, 19);
            this.materialLabel11.TabIndex = 36;
            this.materialLabel11.Text = "NoPlat";
            // 
            // lblNoPlat
            // 
            this.lblNoPlat.AutoSize = true;
            this.lblNoPlat.Depth = 0;
            this.lblNoPlat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoPlat.Location = new System.Drawing.Point(136, 39);
            this.lblNoPlat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoPlat.Name = "lblNoPlat";
            this.lblNoPlat.Size = new System.Drawing.Size(49, 19);
            this.lblNoPlat.TabIndex = 35;
            this.lblNoPlat.Text = "NoPlat";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(14, 112);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "Capacity";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(14, 87);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(98, 19);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "Compartment";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(14, 64);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(36, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Type";
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.pnlTujuan);
            this.grpRegister.Location = new System.Drawing.Point(392, 3);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(328, 146);
            this.grpRegister.TabIndex = 29;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "REGISTER DATA";
            // 
            // pnlTujuan
            // 
            this.pnlTujuan.Controls.Add(this.btnSetTujuan);
            this.pnlTujuan.Controls.Add(this.txtTujuan);
            this.pnlTujuan.Controls.Add(this.materialLabel8);
            this.pnlTujuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTujuan.Location = new System.Drawing.Point(3, 16);
            this.pnlTujuan.Name = "pnlTujuan";
            this.pnlTujuan.Size = new System.Drawing.Size(322, 127);
            this.pnlTujuan.TabIndex = 0;
            // 
            // btnSetTujuan
            // 
            this.btnSetTujuan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetTujuan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetTujuan.Depth = 0;
            this.btnSetTujuan.HighEmphasis = true;
            this.btnSetTujuan.Icon = null;
            this.btnSetTujuan.Location = new System.Drawing.Point(84, 74);
            this.btnSetTujuan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetTujuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetTujuan.Name = "btnSetTujuan";
            this.btnSetTujuan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetTujuan.Size = new System.Drawing.Size(149, 36);
            this.btnSetTujuan.TabIndex = 10;
            this.btnSetTujuan.Text = "SET DATA TUJUAN";
            this.btnSetTujuan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetTujuan.UseAccentColor = false;
            this.btnSetTujuan.UseVisualStyleBackColor = true;
            this.btnSetTujuan.Click += new System.EventHandler(this.btnSetTujuan_Click);
            // 
            // txtTujuan
            // 
            this.txtTujuan.AnimateReadOnly = false;
            this.txtTujuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTujuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTujuan.Depth = 0;
            this.txtTujuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTujuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTujuan.HideSelection = true;
            this.txtTujuan.Hint = "TUJUAN";
            this.txtTujuan.LeadingIcon = null;
            this.txtTujuan.Location = new System.Drawing.Point(0, 19);
            this.txtTujuan.MaxLength = 32767;
            this.txtTujuan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTujuan.Name = "txtTujuan";
            this.txtTujuan.PasswordChar = '\0';
            this.txtTujuan.PrefixSuffixText = null;
            this.txtTujuan.ReadOnly = true;
            this.txtTujuan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTujuan.SelectedText = "";
            this.txtTujuan.SelectionLength = 0;
            this.txtTujuan.SelectionStart = 0;
            this.txtTujuan.ShortcutsEnabled = true;
            this.txtTujuan.Size = new System.Drawing.Size(322, 48);
            this.txtTujuan.TabIndex = 8;
            this.txtTujuan.TabStop = false;
            this.txtTujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTujuan.TrailingIcon = null;
            this.txtTujuan.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(0, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(102, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "DESTINATION";
            // 
            // lblJlhCapacity
            // 
            this.lblJlhCapacity.AutoSize = true;
            this.lblJlhCapacity.Depth = 0;
            this.lblJlhCapacity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblJlhCapacity.Location = new System.Drawing.Point(136, 112);
            this.lblJlhCapacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJlhCapacity.Name = "lblJlhCapacity";
            this.lblJlhCapacity.Size = new System.Drawing.Size(63, 19);
            this.lblJlhCapacity.TabIndex = 7;
            this.lblJlhCapacity.Text = "Capacity";
            // 
            // lblJlhCompartment
            // 
            this.lblJlhCompartment.AutoSize = true;
            this.lblJlhCompartment.Depth = 0;
            this.lblJlhCompartment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblJlhCompartment.Location = new System.Drawing.Point(136, 87);
            this.lblJlhCompartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJlhCompartment.Name = "lblJlhCompartment";
            this.lblJlhCompartment.Size = new System.Drawing.Size(98, 19);
            this.lblJlhCompartment.TabIndex = 6;
            this.lblJlhCompartment.Text = "Compartment";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Depth = 0;
            this.lblType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblType.Location = new System.Drawing.Point(136, 64);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 19);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TCPengiriman;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1085, 48);
            this.TabSelector.TabIndex = 7;
            this.TabSelector.Text = "materialTabSelector1";
            this.TabSelector.Visible = false;
            // 
            // PengirimanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 576);
            this.Controls.Add(this.TCPengiriman);
            this.Controls.Add(this.TabSelector);
            this.Name = "PengirimanForm";
            this.Text = "PengirimanForm";
            this.Load += new System.EventHandler(this.PengirimanForm_Load);
            this.TCPengiriman.ResumeLayout(false);
            this.TPPengiriman.ResumeLayout(false);
            this.RightCard.ResumeLayout(false);
            this.RightCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPengiriman)).EndInit();
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.UpCard.ResumeLayout(false);
            this.UpCard.PerformLayout();
            this.TPAddPengiriman.ResumeLayout(false);
            this.TPAddPengiriman.PerformLayout();
            this.CardCRUD.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.grpRegisLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengirimanLive)).EndInit();
            this.pnlTopRLive.ResumeLayout(false);
            this.pnlTopRLive.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.pnlTujuan.ResumeLayout(false);
            this.pnlTujuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCPengiriman;
        private System.Windows.Forms.TabPage TPPengiriman;
        private MaterialSkin.Controls.MaterialCard RightCard;
        private System.Windows.Forms.DataGridView dgvDetailPengiriman;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard LeftCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvPengiriman;
        private System.Windows.Forms.Panel TopPanel;
        private MaterialSkin.Controls.MaterialCard UpCard;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.DateTimePicker dtpPengTo;
        private System.Windows.Forms.DateTimePicker dtpPengFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox cbxPengSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchPeng;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private System.Windows.Forms.TabPage TPAddPengiriman;
        private MaterialSkin.Controls.MaterialCard CardCRUD;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel UpPanel;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialLabel lblJlhCapacity;
        private MaterialSkin.Controls.MaterialLabel lblJlhCompartment;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Panel pnlTujuan;
        private MaterialSkin.Controls.MaterialButton btnSetTujuan;
        private MaterialSkin.Controls.MaterialTextBox2 txtTujuan;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.RichTextBox txtSerialLog;
        private System.Windows.Forms.GroupBox grpRegisLive;
        private System.Windows.Forms.DataGridView dgvPengirimanLive;
        private System.Windows.Forms.Panel pnlTopRLive;
        private MaterialSkin.Controls.MaterialButton btnClearLog;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnStartListen;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel lblNoPlat;
        private MaterialSkin.Controls.MaterialLabel lblIDPengiriman;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label lblPortStatus;
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private MaterialSkin.Controls.MaterialCheckbox chkAll;
        private MaterialSkin.Controls.MaterialLabel lblRFID;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnRelistenAll;
        private MaterialSkin.Controls.MaterialButton btnReListen;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private Custom.CustomMaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSendACK;
    }
}