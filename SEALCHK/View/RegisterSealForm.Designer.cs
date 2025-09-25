namespace SEALCHK.View
{
    partial class RegisterSealForm
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
            if (disposing)
            {
                PrepareToClose();         // make sure port is closed
                components?.Dispose();
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
            this.OuterMostPanel = new System.Windows.Forms.Panel();
            this.TCRegisterSeal = new MaterialSkin.Controls.MaterialTabControl();
            this.TPRegister = new System.Windows.Forms.TabPage();
            this.RightCard = new MaterialSkin.Controls.MaterialCard();
            this.dgvDetailRegister = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.UpCard = new MaterialSkin.Controls.MaterialCard();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.dtpRegTo = new System.Windows.Forms.DateTimePicker();
            this.dtpRegFrom = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxRegSearchBy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRegSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new SEALCHK.CustomMaterialButton();
            this.TPAddEditSeal = new System.Windows.Forms.TabPage();
            this.CardCRUD = new MaterialSkin.Controls.MaterialCard();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.grpRegisLive = new System.Windows.Forms.GroupBox();
            this.dgvRegisLive = new System.Windows.Forms.DataGridView();
            this.txtSerialLog = new System.Windows.Forms.RichTextBox();
            this.pnlTopRLive = new System.Windows.Forms.Panel();
            this.btnSortDesc = new MaterialSkin.Controls.MaterialButton();
            this.btnSortAsc = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new SEALCHK.CustomMaterialButton();
            this.btnClearLog = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.ProListen = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnStartListen = new MaterialSkin.Controls.MaterialButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.grpPartList = new System.Windows.Forms.GroupBox();
            this.pnlPartList = new System.Windows.Forms.Panel();
            this.dgvPCovPart = new System.Windows.Forms.DataGridView();
            this.SelPCov = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvManComPart = new System.Windows.Forms.DataGridView();
            this.SelManCom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkAllPCov = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.chkAllManCom = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkAllBotLoad = new MaterialSkin.Controls.MaterialCheckbox();
            this.dgvBotLoadPart = new System.Windows.Forms.DataGridView();
            this.SelBotLoad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.grpSerialPort = new System.Windows.Forms.GroupBox();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.pnlTujuan = new System.Windows.Forms.Panel();
            this.btnSetTujuan = new MaterialSkin.Controls.MaterialButton();
            this.txtTujuan = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.grpMTSelector = new System.Windows.Forms.GroupBox();
            this.lblPanelCover = new MaterialSkin.Controls.MaterialLabel();
            this.lblJlhCompartment = new MaterialSkin.Controls.MaterialLabel();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.btnFind = new MaterialSkin.Controls.MaterialButton();
            this.cbxNoPlat = new MaterialSkin.Controls.MaterialComboBox();
            this.TPCollectSeal = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCollectBuffer = new System.Windows.Forms.DataGridView();
            this.txtCollect = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStopCollect = new SEALCHK.CustomMaterialButton();
            this.lblCollectStatus = new System.Windows.Forms.Label();
            this.btnClearCollect = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveCollect = new MaterialSkin.Controls.MaterialButton();
            this.btnStartCollect = new MaterialSkin.Controls.MaterialButton();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRecreatePort = new MaterialSkin.Controls.MaterialButton();
            this.OuterMostPanel.SuspendLayout();
            this.TCRegisterSeal.SuspendLayout();
            this.TPRegister.SuspendLayout();
            this.RightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRegister)).BeginInit();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.UpCard.SuspendLayout();
            this.TPAddEditSeal.SuspendLayout();
            this.CardCRUD.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.grpRegisLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisLive)).BeginInit();
            this.pnlTopRLive.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.grpPartList.SuspendLayout();
            this.pnlPartList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCovPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManComPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBotLoadPart)).BeginInit();
            this.UpPanel.SuspendLayout();
            this.grpSerialPort.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.pnlTujuan.SuspendLayout();
            this.grpMTSelector.SuspendLayout();
            this.TPCollectSeal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectBuffer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterMostPanel
            // 
            this.OuterMostPanel.AutoScroll = true;
            this.OuterMostPanel.Controls.Add(this.TCRegisterSeal);
            this.OuterMostPanel.Controls.Add(this.TabSelector);
            this.OuterMostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuterMostPanel.Location = new System.Drawing.Point(0, 0);
            this.OuterMostPanel.Name = "OuterMostPanel";
            this.OuterMostPanel.Size = new System.Drawing.Size(1192, 642);
            this.OuterMostPanel.TabIndex = 0;
            // 
            // TCRegisterSeal
            // 
            this.TCRegisterSeal.Controls.Add(this.TPRegister);
            this.TCRegisterSeal.Controls.Add(this.TPAddEditSeal);
            this.TCRegisterSeal.Controls.Add(this.TPCollectSeal);
            this.TCRegisterSeal.Depth = 0;
            this.TCRegisterSeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCRegisterSeal.Location = new System.Drawing.Point(0, 48);
            this.TCRegisterSeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCRegisterSeal.Multiline = true;
            this.TCRegisterSeal.Name = "TCRegisterSeal";
            this.TCRegisterSeal.SelectedIndex = 0;
            this.TCRegisterSeal.Size = new System.Drawing.Size(1192, 594);
            this.TCRegisterSeal.TabIndex = 4;
            // 
            // TPRegister
            // 
            this.TPRegister.Controls.Add(this.RightCard);
            this.TPRegister.Controls.Add(this.LeftCard);
            this.TPRegister.Controls.Add(this.TopPanel);
            this.TPRegister.Location = new System.Drawing.Point(4, 22);
            this.TPRegister.Name = "TPRegister";
            this.TPRegister.Padding = new System.Windows.Forms.Padding(3);
            this.TPRegister.Size = new System.Drawing.Size(1184, 568);
            this.TPRegister.TabIndex = 0;
            this.TPRegister.Text = "REGISTER LIST";
            this.TPRegister.UseVisualStyleBackColor = true;
            // 
            // RightCard
            // 
            this.RightCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightCard.Controls.Add(this.dgvDetailRegister);
            this.RightCard.Controls.Add(this.materialLabel2);
            this.RightCard.Depth = 0;
            this.RightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RightCard.Location = new System.Drawing.Point(3, 302);
            this.RightCard.Margin = new System.Windows.Forms.Padding(14);
            this.RightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightCard.Name = "RightCard";
            this.RightCard.Padding = new System.Windows.Forms.Padding(3);
            this.RightCard.Size = new System.Drawing.Size(1178, 263);
            this.RightCard.TabIndex = 9;
            // 
            // dgvDetailRegister
            // 
            this.dgvDetailRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailRegister.Location = new System.Drawing.Point(6, 29);
            this.dgvDetailRegister.Name = "dgvDetailRegister";
            this.dgvDetailRegister.Size = new System.Drawing.Size(1166, 228);
            this.dgvDetailRegister.TabIndex = 3;
            this.dgvDetailRegister.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailRegister_CellFormatting);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "REGISTER DETAIL";
            // 
            // LeftCard
            // 
            this.LeftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftCard.Controls.Add(this.materialLabel1);
            this.LeftCard.Controls.Add(this.dgvRegister);
            this.LeftCard.Depth = 0;
            this.LeftCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftCard.Location = new System.Drawing.Point(3, 83);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(14);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(3);
            this.LeftCard.Size = new System.Drawing.Size(1178, 219);
            this.LeftCard.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "LIST REGISTER";
            // 
            // dgvRegister
            // 
            this.dgvRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Location = new System.Drawing.Point(6, 29);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.Size = new System.Drawing.Size(1166, 184);
            this.dgvRegister.TabIndex = 0;
            this.dgvRegister.SelectionChanged += new System.EventHandler(this.dgvRegister_SelectionChanged);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.UpCard);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1178, 80);
            this.TopPanel.TabIndex = 0;
            // 
            // UpCard
            // 
            this.UpCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpCard.Controls.Add(this.btnFilter);
            this.UpCard.Controls.Add(this.dtpRegTo);
            this.UpCard.Controls.Add(this.dtpRegFrom);
            this.UpCard.Controls.Add(this.materialLabel10);
            this.UpCard.Controls.Add(this.cbxRegSearchBy);
            this.UpCard.Controls.Add(this.materialLabel9);
            this.UpCard.Controls.Add(this.txtRegSearch);
            this.UpCard.Controls.Add(this.btnNew);
            this.UpCard.Controls.Add(this.btnDelete);
            this.UpCard.Depth = 0;
            this.UpCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpCard.Location = new System.Drawing.Point(0, 0);
            this.UpCard.Margin = new System.Windows.Forms.Padding(14);
            this.UpCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpCard.Name = "UpCard";
            this.UpCard.Padding = new System.Windows.Forms.Padding(14);
            this.UpCard.Size = new System.Drawing.Size(1178, 80);
            this.UpCard.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(887, 29);
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
            // dtpRegTo
            // 
            this.dtpRegTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpRegTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegTo.Location = new System.Drawing.Point(671, 55);
            this.dtpRegTo.Name = "dtpRegTo";
            this.dtpRegTo.Size = new System.Drawing.Size(200, 20);
            this.dtpRegTo.TabIndex = 30;
            // 
            // dtpRegFrom
            // 
            this.dtpRegFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpRegFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegFrom.Location = new System.Drawing.Point(671, 29);
            this.dtpRegFrom.Name = "dtpRegFrom";
            this.dtpRegFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpRegFrom.TabIndex = 29;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(671, 9);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(211, 19);
            this.materialLabel10.TabIndex = 28;
            this.materialLabel10.Text = "FILTER TGL_INPUT FROM TO";
            // 
            // cbxRegSearchBy
            // 
            this.cbxRegSearchBy.AutoResize = false;
            this.cbxRegSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxRegSearchBy.Depth = 0;
            this.cbxRegSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxRegSearchBy.DropDownHeight = 174;
            this.cbxRegSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegSearchBy.DropDownWidth = 121;
            this.cbxRegSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxRegSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxRegSearchBy.FormattingEnabled = true;
            this.cbxRegSearchBy.IntegralHeight = false;
            this.cbxRegSearchBy.ItemHeight = 43;
            this.cbxRegSearchBy.Location = new System.Drawing.Point(540, 28);
            this.cbxRegSearchBy.MaxDropDownItems = 4;
            this.cbxRegSearchBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxRegSearchBy.Name = "cbxRegSearchBy";
            this.cbxRegSearchBy.Size = new System.Drawing.Size(125, 49);
            this.cbxRegSearchBy.StartIndex = 0;
            this.cbxRegSearchBy.TabIndex = 27;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(550, 9);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(89, 19);
            this.materialLabel9.TabIndex = 26;
            this.materialLabel9.Text = "SEARCH BY:";
            // 
            // txtRegSearch
            // 
            this.txtRegSearch.AnimateReadOnly = false;
            this.txtRegSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegSearch.Depth = 0;
            this.txtRegSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegSearch.HideSelection = true;
            this.txtRegSearch.Hint = "SEARCH REGISTER";
            this.txtRegSearch.LeadingIcon = null;
            this.txtRegSearch.Location = new System.Drawing.Point(274, 29);
            this.txtRegSearch.MaxLength = 32767;
            this.txtRegSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegSearch.Name = "txtRegSearch";
            this.txtRegSearch.PasswordChar = '\0';
            this.txtRegSearch.PrefixSuffixText = null;
            this.txtRegSearch.ReadOnly = false;
            this.txtRegSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegSearch.SelectedText = "";
            this.txtRegSearch.SelectionLength = 0;
            this.txtRegSearch.SelectionStart = 0;
            this.txtRegSearch.ShortcutsEnabled = true;
            this.txtRegSearch.Size = new System.Drawing.Size(260, 48);
            this.txtRegSearch.TabIndex = 8;
            this.txtRegSearch.TabStop = false;
            this.txtRegSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegSearch.TrailingIcon = null;
            this.txtRegSearch.UseSystemPasswordChar = false;
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = null;
            this.btnNew.Location = new System.Drawing.Point(18, 29);
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
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(179, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TPAddEditSeal
            // 
            this.TPAddEditSeal.Controls.Add(this.CardCRUD);
            this.TPAddEditSeal.Location = new System.Drawing.Point(4, 22);
            this.TPAddEditSeal.Name = "TPAddEditSeal";
            this.TPAddEditSeal.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddEditSeal.Size = new System.Drawing.Size(1184, 568);
            this.TPAddEditSeal.TabIndex = 1;
            this.TPAddEditSeal.Text = "REGISTER SEAL";
            this.TPAddEditSeal.UseVisualStyleBackColor = true;
            // 
            // CardCRUD
            // 
            this.CardCRUD.AutoScroll = true;
            this.CardCRUD.AutoSize = true;
            this.CardCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardCRUD.Controls.Add(this.RightPanel);
            this.CardCRUD.Controls.Add(this.leftPanel);
            this.CardCRUD.Controls.Add(this.UpPanel);
            this.CardCRUD.Depth = 0;
            this.CardCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardCRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardCRUD.Location = new System.Drawing.Point(3, 3);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(14);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(14);
            this.CardCRUD.Size = new System.Drawing.Size(1178, 562);
            this.CardCRUD.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.grpRegisLive);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(487, 160);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(677, 388);
            this.RightPanel.TabIndex = 2;
            // 
            // grpRegisLive
            // 
            this.grpRegisLive.Controls.Add(this.dgvRegisLive);
            this.grpRegisLive.Controls.Add(this.txtSerialLog);
            this.grpRegisLive.Controls.Add(this.pnlTopRLive);
            this.grpRegisLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegisLive.Location = new System.Drawing.Point(0, 0);
            this.grpRegisLive.Name = "grpRegisLive";
            this.grpRegisLive.Size = new System.Drawing.Size(677, 388);
            this.grpRegisLive.TabIndex = 30;
            this.grpRegisLive.TabStop = false;
            this.grpRegisLive.Text = "REGISTER DATA";
            // 
            // dgvRegisLive
            // 
            this.dgvRegisLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegisLive.Location = new System.Drawing.Point(3, 82);
            this.dgvRegisLive.Name = "dgvRegisLive";
            this.dgvRegisLive.Size = new System.Drawing.Size(423, 303);
            this.dgvRegisLive.TabIndex = 11;
            // 
            // txtSerialLog
            // 
            this.txtSerialLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSerialLog.Location = new System.Drawing.Point(426, 82);
            this.txtSerialLog.Name = "txtSerialLog";
            this.txtSerialLog.Size = new System.Drawing.Size(248, 303);
            this.txtSerialLog.TabIndex = 14;
            this.txtSerialLog.Text = "";
            // 
            // pnlTopRLive
            // 
            this.pnlTopRLive.Controls.Add(this.btnSortDesc);
            this.pnlTopRLive.Controls.Add(this.btnSortAsc);
            this.pnlTopRLive.Controls.Add(this.btnCancel);
            this.pnlTopRLive.Controls.Add(this.btnClearLog);
            this.pnlTopRLive.Controls.Add(this.btnSave);
            this.pnlTopRLive.Controls.Add(this.ProListen);
            this.pnlTopRLive.Controls.Add(this.btnStartListen);
            this.pnlTopRLive.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopRLive.Location = new System.Drawing.Point(3, 16);
            this.pnlTopRLive.Name = "pnlTopRLive";
            this.pnlTopRLive.Size = new System.Drawing.Size(671, 66);
            this.pnlTopRLive.TabIndex = 13;
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSortDesc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSortDesc.Depth = 0;
            this.btnSortDesc.HighEmphasis = true;
            this.btnSortDesc.Icon = null;
            this.btnSortDesc.Location = new System.Drawing.Point(240, 9);
            this.btnSortDesc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSortDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSortDesc.Size = new System.Drawing.Size(64, 36);
            this.btnSortDesc.TabIndex = 22;
            this.btnSortDesc.Text = "DESC";
            this.btnSortDesc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSortDesc.UseAccentColor = false;
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSortAsc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSortAsc.Depth = 0;
            this.btnSortAsc.HighEmphasis = true;
            this.btnSortAsc.Icon = null;
            this.btnSortAsc.Location = new System.Drawing.Point(166, 8);
            this.btnSortAsc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSortAsc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSortAsc.Size = new System.Drawing.Size(64, 36);
            this.btnSortAsc.TabIndex = 21;
            this.btnSortAsc.Text = "ASC";
            this.btnSortAsc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSortAsc.UseAccentColor = false;
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(81, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearLog.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearLog.Depth = 0;
            this.btnClearLog.HighEmphasis = true;
            this.btnClearLog.Icon = null;
            this.btnClearLog.Location = new System.Drawing.Point(591, 9);
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
            this.btnSave.Location = new System.Drawing.Point(340, 7);
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
            // ProListen
            // 
            this.ProListen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProListen.Depth = 0;
            this.ProListen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.ProListen.Location = new System.Drawing.Point(6, 52);
            this.ProListen.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProListen.Name = "ProListen";
            this.ProListen.Size = new System.Drawing.Size(408, 5);
            this.ProListen.TabIndex = 16;
            // 
            // btnStartListen
            // 
            this.btnStartListen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartListen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartListen.Depth = 0;
            this.btnStartListen.HighEmphasis = true;
            this.btnStartListen.Icon = null;
            this.btnStartListen.Location = new System.Drawing.Point(6, 8);
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
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.grpPartList);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(14, 160);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(473, 388);
            this.leftPanel.TabIndex = 1;
            // 
            // grpPartList
            // 
            this.grpPartList.AutoSize = true;
            this.grpPartList.Controls.Add(this.pnlPartList);
            this.grpPartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPartList.Location = new System.Drawing.Point(0, 0);
            this.grpPartList.Name = "grpPartList";
            this.grpPartList.Size = new System.Drawing.Size(473, 388);
            this.grpPartList.TabIndex = 27;
            this.grpPartList.TabStop = false;
            this.grpPartList.Text = "MT PART LIST";
            // 
            // pnlPartList
            // 
            this.pnlPartList.AutoScroll = true;
            this.pnlPartList.Controls.Add(this.dgvPCovPart);
            this.pnlPartList.Controls.Add(this.dgvManComPart);
            this.pnlPartList.Controls.Add(this.chkAllPCov);
            this.pnlPartList.Controls.Add(this.materialLabel4);
            this.pnlPartList.Controls.Add(this.materialLabel5);
            this.pnlPartList.Controls.Add(this.chkAllManCom);
            this.pnlPartList.Controls.Add(this.chkAllBotLoad);
            this.pnlPartList.Controls.Add(this.dgvBotLoadPart);
            this.pnlPartList.Controls.Add(this.materialLabel3);
            this.pnlPartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPartList.Location = new System.Drawing.Point(3, 16);
            this.pnlPartList.Name = "pnlPartList";
            this.pnlPartList.Size = new System.Drawing.Size(467, 369);
            this.pnlPartList.TabIndex = 0;
            // 
            // dgvPCovPart
            // 
            this.dgvPCovPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCovPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelPCov});
            this.dgvPCovPart.Location = new System.Drawing.Point(17, 490);
            this.dgvPCovPart.Name = "dgvPCovPart";
            this.dgvPCovPart.Size = new System.Drawing.Size(414, 132);
            this.dgvPCovPart.TabIndex = 28;
            this.dgvPCovPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPCovPart_CellClick);
            // 
            // SelPCov
            // 
            this.SelPCov.HeaderText = "SEL";
            this.SelPCov.Name = "SelPCov";
            this.SelPCov.Width = 30;
            // 
            // dgvManComPart
            // 
            this.dgvManComPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManComPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelManCom});
            this.dgvManComPart.Location = new System.Drawing.Point(17, 48);
            this.dgvManComPart.Name = "dgvManComPart";
            this.dgvManComPart.RowHeadersWidth = 25;
            this.dgvManComPart.Size = new System.Drawing.Size(414, 177);
            this.dgvManComPart.TabIndex = 29;
            this.dgvManComPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManComPart_CellClick);
            // 
            // SelManCom
            // 
            this.SelManCom.HeaderText = "SEL";
            this.SelManCom.Name = "SelManCom";
            this.SelManCom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelManCom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelManCom.Width = 30;
            // 
            // chkAllPCov
            // 
            this.chkAllPCov.AutoSize = true;
            this.chkAllPCov.Depth = 0;
            this.chkAllPCov.Location = new System.Drawing.Point(344, 450);
            this.chkAllPCov.Margin = new System.Windows.Forms.Padding(0);
            this.chkAllPCov.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAllPCov.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAllPCov.Name = "chkAllPCov";
            this.chkAllPCov.ReadOnly = false;
            this.chkAllPCov.Ripple = true;
            this.chkAllPCov.Size = new System.Drawing.Size(53, 37);
            this.chkAllPCov.TabIndex = 25;
            this.chkAllPCov.Text = "All";
            this.chkAllPCov.UseVisualStyleBackColor = true;
            this.chkAllPCov.CheckedChanged += new System.EventHandler(this.chkAllPCov_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(11, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(199, 19);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "MANHOLE COMPARTMENT";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(11, 459);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(104, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "PANEL COVER";
            // 
            // chkAllManCom
            // 
            this.chkAllManCom.AutoSize = true;
            this.chkAllManCom.Depth = 0;
            this.chkAllManCom.Location = new System.Drawing.Point(344, 8);
            this.chkAllManCom.Margin = new System.Windows.Forms.Padding(0);
            this.chkAllManCom.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAllManCom.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAllManCom.Name = "chkAllManCom";
            this.chkAllManCom.ReadOnly = false;
            this.chkAllManCom.Ripple = true;
            this.chkAllManCom.Size = new System.Drawing.Size(53, 37);
            this.chkAllManCom.TabIndex = 28;
            this.chkAllManCom.Text = "All";
            this.chkAllManCom.UseVisualStyleBackColor = true;
            this.chkAllManCom.CheckedChanged += new System.EventHandler(this.chkAllManCom_CheckedChanged);
            // 
            // chkAllBotLoad
            // 
            this.chkAllBotLoad.AutoSize = true;
            this.chkAllBotLoad.Depth = 0;
            this.chkAllBotLoad.Location = new System.Drawing.Point(344, 222);
            this.chkAllBotLoad.Margin = new System.Windows.Forms.Padding(0);
            this.chkAllBotLoad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAllBotLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAllBotLoad.Name = "chkAllBotLoad";
            this.chkAllBotLoad.ReadOnly = false;
            this.chkAllBotLoad.Ripple = true;
            this.chkAllBotLoad.Size = new System.Drawing.Size(53, 37);
            this.chkAllBotLoad.TabIndex = 24;
            this.chkAllBotLoad.Text = "All";
            this.chkAllBotLoad.UseVisualStyleBackColor = true;
            this.chkAllBotLoad.CheckedChanged += new System.EventHandler(this.chkAllBotLoad_CheckedChanged);
            // 
            // dgvBotLoadPart
            // 
            this.dgvBotLoadPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBotLoadPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelBotLoad});
            this.dgvBotLoadPart.Location = new System.Drawing.Point(17, 262);
            this.dgvBotLoadPart.Name = "dgvBotLoadPart";
            this.dgvBotLoadPart.Size = new System.Drawing.Size(414, 182);
            this.dgvBotLoadPart.TabIndex = 27;
            this.dgvBotLoadPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBotLoadPart_CellClick);
            // 
            // SelBotLoad
            // 
            this.SelBotLoad.HeaderText = "SEL";
            this.SelBotLoad.Name = "SelBotLoad";
            this.SelBotLoad.Width = 30;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(11, 228);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(131, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "BOTTOM LOADER";
            // 
            // UpPanel
            // 
            this.UpPanel.AutoScroll = true;
            this.UpPanel.Controls.Add(this.grpSerialPort);
            this.UpPanel.Controls.Add(this.grpRegister);
            this.UpPanel.Controls.Add(this.grpMTSelector);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(14, 14);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1150, 146);
            this.UpPanel.TabIndex = 0;
            // 
            // grpSerialPort
            // 
            this.grpSerialPort.Controls.Add(this.lblPortStatus);
            this.grpSerialPort.Controls.Add(this.materialLabel6);
            this.grpSerialPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpSerialPort.Location = new System.Drawing.Point(728, 0);
            this.grpSerialPort.Name = "grpSerialPort";
            this.grpSerialPort.Size = new System.Drawing.Size(417, 146);
            this.grpSerialPort.TabIndex = 29;
            this.grpSerialPort.TabStop = false;
            this.grpSerialPort.Text = "Serial Port Settings";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(10, 38);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(63, 13);
            this.lblPortStatus.TabIndex = 9;
            this.lblPortStatus.Text = "Port Status";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(10, 18);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "PORT";
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.pnlTujuan);
            this.grpRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpRegister.Location = new System.Drawing.Point(400, 0);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(328, 146);
            this.grpRegister.TabIndex = 28;
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
            this.txtTujuan.Enabled = false;
            this.txtTujuan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTujuan.HideSelection = true;
            this.txtTujuan.Hint = "TUJUAN";
            this.txtTujuan.LeadingIcon = null;
            this.txtTujuan.Location = new System.Drawing.Point(0, 19);
            this.txtTujuan.MaxLength = 32767;
            this.txtTujuan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTujuan.Name = "txtTujuan";
            this.txtTujuan.PasswordChar = '\0';
            this.txtTujuan.PrefixSuffixText = null;
            this.txtTujuan.ReadOnly = false;
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
            // grpMTSelector
            // 
            this.grpMTSelector.Controls.Add(this.lblPanelCover);
            this.grpMTSelector.Controls.Add(this.lblJlhCompartment);
            this.grpMTSelector.Controls.Add(this.lblType);
            this.grpMTSelector.Controls.Add(this.btnFind);
            this.grpMTSelector.Controls.Add(this.cbxNoPlat);
            this.grpMTSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpMTSelector.Location = new System.Drawing.Point(0, 0);
            this.grpMTSelector.Name = "grpMTSelector";
            this.grpMTSelector.Size = new System.Drawing.Size(400, 146);
            this.grpMTSelector.TabIndex = 26;
            this.grpMTSelector.TabStop = false;
            this.grpMTSelector.Text = "MT SELECTOR";
            // 
            // lblPanelCover
            // 
            this.lblPanelCover.AutoSize = true;
            this.lblPanelCover.Depth = 0;
            this.lblPanelCover.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPanelCover.Location = new System.Drawing.Point(165, 106);
            this.lblPanelCover.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPanelCover.Name = "lblPanelCover";
            this.lblPanelCover.Size = new System.Drawing.Size(85, 19);
            this.lblPanelCover.TabIndex = 4;
            this.lblPanelCover.Text = "Panel Cover";
            // 
            // lblJlhCompartment
            // 
            this.lblJlhCompartment.AutoSize = true;
            this.lblJlhCompartment.Depth = 0;
            this.lblJlhCompartment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblJlhCompartment.Location = new System.Drawing.Point(165, 81);
            this.lblJlhCompartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJlhCompartment.Name = "lblJlhCompartment";
            this.lblJlhCompartment.Size = new System.Drawing.Size(98, 19);
            this.lblJlhCompartment.TabIndex = 3;
            this.lblJlhCompartment.Text = "Compartment";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Depth = 0;
            this.lblType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblType.Location = new System.Drawing.Point(165, 32);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 19);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // btnFind
            // 
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFind.Depth = 0;
            this.btnFind.HighEmphasis = true;
            this.btnFind.Icon = null;
            this.btnFind.Location = new System.Drawing.Point(12, 90);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFind.Name = "btnFind";
            this.btnFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFind.Size = new System.Drawing.Size(64, 36);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "FIND";
            this.btnFind.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFind.UseAccentColor = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbxNoPlat
            // 
            this.cbxNoPlat.AutoResize = false;
            this.cbxNoPlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxNoPlat.Depth = 0;
            this.cbxNoPlat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxNoPlat.DropDownHeight = 174;
            this.cbxNoPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNoPlat.DropDownWidth = 121;
            this.cbxNoPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxNoPlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxNoPlat.FormattingEnabled = true;
            this.cbxNoPlat.Hint = "No Plat";
            this.cbxNoPlat.IntegralHeight = false;
            this.cbxNoPlat.ItemHeight = 43;
            this.cbxNoPlat.Location = new System.Drawing.Point(9, 32);
            this.cbxNoPlat.MaxDropDownItems = 4;
            this.cbxNoPlat.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxNoPlat.Name = "cbxNoPlat";
            this.cbxNoPlat.Size = new System.Drawing.Size(150, 49);
            this.cbxNoPlat.StartIndex = 0;
            this.cbxNoPlat.TabIndex = 0;
            this.cbxNoPlat.SelectedIndexChanged += new System.EventHandler(this.cbxNoPlat_SelectedIndexChanged);
            // 
            // TPCollectSeal
            // 
            this.TPCollectSeal.Controls.Add(this.groupBox1);
            this.TPCollectSeal.Location = new System.Drawing.Point(4, 22);
            this.TPCollectSeal.Name = "TPCollectSeal";
            this.TPCollectSeal.Padding = new System.Windows.Forms.Padding(3);
            this.TPCollectSeal.Size = new System.Drawing.Size(1184, 568);
            this.TPCollectSeal.TabIndex = 2;
            this.TPCollectSeal.Text = "COLLECT SEAL";
            this.TPCollectSeal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCollectBuffer);
            this.groupBox1.Controls.Add(this.txtCollect);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 562);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLLECT DATA";
            // 
            // dgvCollectBuffer
            // 
            this.dgvCollectBuffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollectBuffer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollectBuffer.Location = new System.Drawing.Point(3, 82);
            this.dgvCollectBuffer.Name = "dgvCollectBuffer";
            this.dgvCollectBuffer.Size = new System.Drawing.Size(954, 477);
            this.dgvCollectBuffer.TabIndex = 11;
            this.dgvCollectBuffer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCollectBuffer_CellFormatting);
            // 
            // txtCollect
            // 
            this.txtCollect.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCollect.Location = new System.Drawing.Point(957, 82);
            this.txtCollect.Name = "txtCollect";
            this.txtCollect.Size = new System.Drawing.Size(218, 477);
            this.txtCollect.TabIndex = 14;
            this.txtCollect.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRecreatePort);
            this.panel1.Controls.Add(this.btnStopCollect);
            this.panel1.Controls.Add(this.lblCollectStatus);
            this.panel1.Controls.Add(this.btnClearCollect);
            this.panel1.Controls.Add(this.btnSaveCollect);
            this.panel1.Controls.Add(this.btnStartCollect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 66);
            this.panel1.TabIndex = 13;
            // 
            // btnStopCollect
            // 
            this.btnStopCollect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStopCollect.CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnStopCollect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStopCollect.Depth = 0;
            this.btnStopCollect.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCollect.HighEmphasis = true;
            this.btnStopCollect.Icon = null;
            this.btnStopCollect.Location = new System.Drawing.Point(89, 20);
            this.btnStopCollect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStopCollect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStopCollect.Name = "btnStopCollect";
            this.btnStopCollect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStopCollect.Size = new System.Drawing.Size(64, 36);
            this.btnStopCollect.TabIndex = 22;
            this.btnStopCollect.Text = "STOP";
            this.btnStopCollect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStopCollect.UseAccentColor = false;
            this.btnStopCollect.UseVisualStyleBackColor = true;
            // 
            // lblCollectStatus
            // 
            this.lblCollectStatus.AutoSize = true;
            this.lblCollectStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectStatus.Location = new System.Drawing.Point(197, 32);
            this.lblCollectStatus.Name = "lblCollectStatus";
            this.lblCollectStatus.Size = new System.Drawing.Size(77, 13);
            this.lblCollectStatus.TabIndex = 21;
            this.lblCollectStatus.Text = "Collect Status";
            // 
            // btnClearCollect
            // 
            this.btnClearCollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCollect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearCollect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearCollect.Depth = 0;
            this.btnClearCollect.HighEmphasis = true;
            this.btnClearCollect.Icon = null;
            this.btnClearCollect.Location = new System.Drawing.Point(1092, 9);
            this.btnClearCollect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearCollect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearCollect.Name = "btnClearCollect";
            this.btnClearCollect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearCollect.Size = new System.Drawing.Size(66, 36);
            this.btnClearCollect.TabIndex = 20;
            this.btnClearCollect.Text = "CLEAR";
            this.btnClearCollect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearCollect.UseAccentColor = false;
            this.btnClearCollect.UseVisualStyleBackColor = true;
            // 
            // btnSaveCollect
            // 
            this.btnSaveCollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCollect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveCollect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveCollect.Depth = 0;
            this.btnSaveCollect.HighEmphasis = true;
            this.btnSaveCollect.Icon = null;
            this.btnSaveCollect.Location = new System.Drawing.Point(878, 21);
            this.btnSaveCollect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveCollect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveCollect.Name = "btnSaveCollect";
            this.btnSaveCollect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveCollect.Size = new System.Drawing.Size(64, 36);
            this.btnSaveCollect.TabIndex = 19;
            this.btnSaveCollect.Text = "SAVE";
            this.btnSaveCollect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveCollect.UseAccentColor = true;
            this.btnSaveCollect.UseVisualStyleBackColor = true;
            // 
            // btnStartCollect
            // 
            this.btnStartCollect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartCollect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartCollect.Depth = 0;
            this.btnStartCollect.HighEmphasis = true;
            this.btnStartCollect.Icon = null;
            this.btnStartCollect.Location = new System.Drawing.Point(4, 21);
            this.btnStartCollect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartCollect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartCollect.Name = "btnStartCollect";
            this.btnStartCollect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartCollect.Size = new System.Drawing.Size(67, 36);
            this.btnStartCollect.TabIndex = 15;
            this.btnStartCollect.Text = "START ";
            this.btnStartCollect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartCollect.UseAccentColor = false;
            this.btnStartCollect.UseVisualStyleBackColor = true;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TCRegisterSeal;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1192, 48);
            this.TabSelector.TabIndex = 5;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRecreatePort
            // 
            this.btnRecreatePort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecreatePort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecreatePort.Depth = 0;
            this.btnRecreatePort.HighEmphasis = true;
            this.btnRecreatePort.Icon = null;
            this.btnRecreatePort.Location = new System.Drawing.Point(324, 20);
            this.btnRecreatePort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecreatePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecreatePort.Name = "btnRecreatePort";
            this.btnRecreatePort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecreatePort.Size = new System.Drawing.Size(111, 36);
            this.btnRecreatePort.TabIndex = 23;
            this.btnRecreatePort.Text = "RE-CONNECT";
            this.btnRecreatePort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecreatePort.UseAccentColor = false;
            this.btnRecreatePort.UseVisualStyleBackColor = true;
            this.btnRecreatePort.Click += new System.EventHandler(this.btnRecreatePort_Click);
            // 
            // RegisterSealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1192, 642);
            this.Controls.Add(this.OuterMostPanel);
            this.Name = "RegisterSealForm";
            this.Text = "REGISTER SEAL";
            this.Load += new System.EventHandler(this.RegisterSealForm_Load);
            this.OuterMostPanel.ResumeLayout(false);
            this.TCRegisterSeal.ResumeLayout(false);
            this.TPRegister.ResumeLayout(false);
            this.RightCard.ResumeLayout(false);
            this.RightCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRegister)).EndInit();
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.UpCard.ResumeLayout(false);
            this.UpCard.PerformLayout();
            this.TPAddEditSeal.ResumeLayout(false);
            this.TPAddEditSeal.PerformLayout();
            this.CardCRUD.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.grpRegisLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisLive)).EndInit();
            this.pnlTopRLive.ResumeLayout(false);
            this.pnlTopRLive.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.grpPartList.ResumeLayout(false);
            this.pnlPartList.ResumeLayout(false);
            this.pnlPartList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCovPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManComPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBotLoadPart)).EndInit();
            this.UpPanel.ResumeLayout(false);
            this.grpSerialPort.ResumeLayout(false);
            this.grpSerialPort.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.pnlTujuan.ResumeLayout(false);
            this.pnlTujuan.PerformLayout();
            this.grpMTSelector.ResumeLayout(false);
            this.grpMTSelector.PerformLayout();
            this.TPCollectSeal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectBuffer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OuterMostPanel;
        private MaterialSkin.Controls.MaterialTabControl TCRegisterSeal;
        private System.Windows.Forms.TabPage TPRegister;
        private MaterialSkin.Controls.MaterialCard RightCard;
        private System.Windows.Forms.DataGridView dgvDetailRegister;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard LeftCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TabPage TPAddEditSeal;
        private MaterialSkin.Controls.MaterialCard CardCRUD;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.GroupBox grpMTSelector;
        private MaterialSkin.Controls.MaterialLabel lblPanelCover;
        private MaterialSkin.Controls.MaterialLabel lblJlhCompartment;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private MaterialSkin.Controls.MaterialButton btnFind;
        private MaterialSkin.Controls.MaterialComboBox cbxNoPlat;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox grpPartList;
        private System.Windows.Forms.Panel pnlPartList;
        private System.Windows.Forms.DataGridView dgvPCovPart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelPCov;
        private System.Windows.Forms.DataGridView dgvManComPart;
        private MaterialSkin.Controls.MaterialCheckbox chkAllPCov;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCheckbox chkAllManCom;
        private MaterialSkin.Controls.MaterialCheckbox chkAllBotLoad;
        private System.Windows.Forms.DataGridView dgvBotLoadPart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelBotLoad;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.GroupBox grpRegisLive;
        private System.Windows.Forms.DataGridView dgvRegisLive;
        private System.Windows.Forms.Panel pnlTopRLive;
        private MaterialSkin.Controls.MaterialProgressBar ProListen;
        private MaterialSkin.Controls.MaterialButton btnStartListen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelManCom;
        private System.Windows.Forms.RichTextBox txtSerialLog;
        private MaterialSkin.Controls.MaterialButton btnClearLog;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private CustomMaterialButton btnCancel;
        private System.Windows.Forms.Panel pnlTujuan;
        private MaterialSkin.Controls.MaterialTextBox2 txtTujuan;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnSetTujuan;
        private MaterialSkin.Controls.MaterialCard UpCard;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegSearch;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private CustomMaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialComboBox cbxRegSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.DateTimePicker dtpRegTo;
        private System.Windows.Forms.DateTimePicker dtpRegFrom;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.GroupBox grpSerialPort;
        private System.Windows.Forms.Label lblPortStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage TPCollectSeal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCollectBuffer;
        private System.Windows.Forms.RichTextBox txtCollect;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnClearCollect;
        private MaterialSkin.Controls.MaterialButton btnSaveCollect;
        private MaterialSkin.Controls.MaterialButton btnStartCollect;
        private System.Windows.Forms.Label lblCollectStatus;
        private CustomMaterialButton btnStopCollect;
        private MaterialSkin.Controls.MaterialButton btnSortDesc;
        private MaterialSkin.Controls.MaterialButton btnSortAsc;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialButton btnRecreatePort;
    }
}