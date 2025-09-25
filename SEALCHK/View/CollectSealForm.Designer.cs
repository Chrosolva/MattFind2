namespace SEALCHK.View
{
    partial class CollectSealForm
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
            this.btnCollect = new MaterialSkin.Controls.MaterialButton();
            this.TPCollectSeal = new System.Windows.Forms.TabPage();
            this.CardCRUD = new MaterialSkin.Controls.MaterialCard();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.grpRegisLive = new System.Windows.Forms.GroupBox();
            this.dgvCollectDetail = new System.Windows.Forms.DataGridView();
            this.txtSerialLog = new System.Windows.Forms.RichTextBox();
            this.pnlTopRLive = new System.Windows.Forms.Panel();
            this.btnClearLog = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.ProListen = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnStartListen = new MaterialSkin.Controls.MaterialButton();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.grpSerialPort = new System.Windows.Forms.GroupBox();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.grpRegSelector = new System.Windows.Forms.GroupBox();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserInput = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTujuan = new MaterialSkin.Controls.MaterialLabel();
            this.lblTglInput = new MaterialSkin.Controls.MaterialLabel();
            this.lblNoPlat = new MaterialSkin.Controls.MaterialLabel();
            this.btnFind = new MaterialSkin.Controls.MaterialButton();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.OuterMostPanel.SuspendLayout();
            this.TCRegisterSeal.SuspendLayout();
            this.TPRegister.SuspendLayout();
            this.RightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRegister)).BeginInit();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.UpCard.SuspendLayout();
            this.TPCollectSeal.SuspendLayout();
            this.CardCRUD.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.grpRegisLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectDetail)).BeginInit();
            this.pnlTopRLive.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.grpSerialPort.SuspendLayout();
            this.grpRegSelector.SuspendLayout();
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
            this.OuterMostPanel.Size = new System.Drawing.Size(1318, 504);
            this.OuterMostPanel.TabIndex = 1;
            // 
            // TCRegisterSeal
            // 
            this.TCRegisterSeal.Controls.Add(this.TPRegister);
            this.TCRegisterSeal.Controls.Add(this.TPCollectSeal);
            this.TCRegisterSeal.Depth = 0;
            this.TCRegisterSeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCRegisterSeal.Location = new System.Drawing.Point(0, 48);
            this.TCRegisterSeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCRegisterSeal.Multiline = true;
            this.TCRegisterSeal.Name = "TCRegisterSeal";
            this.TCRegisterSeal.SelectedIndex = 0;
            this.TCRegisterSeal.Size = new System.Drawing.Size(1318, 456);
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
            this.TPRegister.Size = new System.Drawing.Size(1310, 430);
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
            this.RightCard.Location = new System.Drawing.Point(3, 236);
            this.RightCard.Margin = new System.Windows.Forms.Padding(14);
            this.RightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightCard.Name = "RightCard";
            this.RightCard.Padding = new System.Windows.Forms.Padding(3);
            this.RightCard.Size = new System.Drawing.Size(1304, 191);
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
            this.dgvDetailRegister.Size = new System.Drawing.Size(1292, 156);
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
            this.LeftCard.Size = new System.Drawing.Size(1304, 153);
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
            this.dgvRegister.Size = new System.Drawing.Size(1292, 118);
            this.dgvRegister.TabIndex = 0;
            this.dgvRegister.SelectionChanged += new System.EventHandler(this.dgvRegister_SelectionChanged);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.UpCard);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1304, 80);
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
            this.UpCard.Controls.Add(this.btnCollect);
            this.UpCard.Depth = 0;
            this.UpCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpCard.Location = new System.Drawing.Point(0, 0);
            this.UpCard.Margin = new System.Windows.Forms.Padding(14);
            this.UpCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpCard.Name = "UpCard";
            this.UpCard.Padding = new System.Windows.Forms.Padding(14);
            this.UpCard.Size = new System.Drawing.Size(1304, 80);
            this.UpCard.TabIndex = 0;
            this.UpCard.Paint += new System.Windows.Forms.PaintEventHandler(this.UpCard_Paint);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(1001, 22);
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
            this.dtpRegTo.Location = new System.Drawing.Point(783, 54);
            this.dtpRegTo.Name = "dtpRegTo";
            this.dtpRegTo.Size = new System.Drawing.Size(200, 20);
            this.dtpRegTo.TabIndex = 30;
            // 
            // dtpRegFrom
            // 
            this.dtpRegFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpRegFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegFrom.Location = new System.Drawing.Point(783, 28);
            this.dtpRegFrom.Name = "dtpRegFrom";
            this.dtpRegFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpRegFrom.TabIndex = 29;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(783, 8);
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
            this.cbxRegSearchBy.Location = new System.Drawing.Point(652, 15);
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
            this.materialLabel9.Location = new System.Drawing.Point(557, 32);
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
            this.txtRegSearch.Location = new System.Drawing.Point(291, 15);
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
            // btnCollect
            // 
            this.btnCollect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCollect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCollect.Depth = 0;
            this.btnCollect.HighEmphasis = true;
            this.btnCollect.Icon = null;
            this.btnCollect.Location = new System.Drawing.Point(9, 24);
            this.btnCollect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCollect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCollect.Size = new System.Drawing.Size(123, 36);
            this.btnCollect.TabIndex = 7;
            this.btnCollect.Text = "COLLECT SEAL";
            this.btnCollect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCollect.UseAccentColor = false;
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // TPCollectSeal
            // 
            this.TPCollectSeal.Controls.Add(this.CardCRUD);
            this.TPCollectSeal.Location = new System.Drawing.Point(4, 22);
            this.TPCollectSeal.Name = "TPCollectSeal";
            this.TPCollectSeal.Padding = new System.Windows.Forms.Padding(3);
            this.TPCollectSeal.Size = new System.Drawing.Size(1310, 430);
            this.TPCollectSeal.TabIndex = 1;
            this.TPCollectSeal.Text = "COLLECT SEAL";
            this.TPCollectSeal.UseVisualStyleBackColor = true;
            // 
            // CardCRUD
            // 
            this.CardCRUD.AutoScroll = true;
            this.CardCRUD.AutoSize = true;
            this.CardCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardCRUD.Controls.Add(this.RightPanel);
            this.CardCRUD.Controls.Add(this.UpPanel);
            this.CardCRUD.Depth = 0;
            this.CardCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardCRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardCRUD.Location = new System.Drawing.Point(3, 3);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(14);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(14);
            this.CardCRUD.Size = new System.Drawing.Size(1304, 424);
            this.CardCRUD.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.grpRegisLive);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(14, 160);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(1276, 250);
            this.RightPanel.TabIndex = 2;
            // 
            // grpRegisLive
            // 
            this.grpRegisLive.Controls.Add(this.dgvCollectDetail);
            this.grpRegisLive.Controls.Add(this.txtSerialLog);
            this.grpRegisLive.Controls.Add(this.pnlTopRLive);
            this.grpRegisLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegisLive.Location = new System.Drawing.Point(0, 0);
            this.grpRegisLive.Name = "grpRegisLive";
            this.grpRegisLive.Size = new System.Drawing.Size(1276, 250);
            this.grpRegisLive.TabIndex = 30;
            this.grpRegisLive.TabStop = false;
            this.grpRegisLive.Text = "REGISTER DATA";
            // 
            // dgvCollectDetail
            // 
            this.dgvCollectDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollectDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollectDetail.Location = new System.Drawing.Point(3, 82);
            this.dgvCollectDetail.Name = "dgvCollectDetail";
            this.dgvCollectDetail.Size = new System.Drawing.Size(1052, 165);
            this.dgvCollectDetail.TabIndex = 11;
            // 
            // txtSerialLog
            // 
            this.txtSerialLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSerialLog.Location = new System.Drawing.Point(1055, 82);
            this.txtSerialLog.Name = "txtSerialLog";
            this.txtSerialLog.Size = new System.Drawing.Size(218, 165);
            this.txtSerialLog.TabIndex = 14;
            this.txtSerialLog.Text = "";
            // 
            // pnlTopRLive
            // 
            this.pnlTopRLive.Controls.Add(this.btnClearLog);
            this.pnlTopRLive.Controls.Add(this.btnSave);
            this.pnlTopRLive.Controls.Add(this.ProListen);
            this.pnlTopRLive.Controls.Add(this.btnStartListen);
            this.pnlTopRLive.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopRLive.Location = new System.Drawing.Point(3, 16);
            this.pnlTopRLive.Name = "pnlTopRLive";
            this.pnlTopRLive.Size = new System.Drawing.Size(1270, 66);
            this.pnlTopRLive.TabIndex = 13;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearLog.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearLog.Depth = 0;
            this.btnClearLog.HighEmphasis = true;
            this.btnClearLog.Icon = null;
            this.btnClearLog.Location = new System.Drawing.Point(1190, 9);
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
            this.btnSave.Location = new System.Drawing.Point(778, 8);
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
            this.ProListen.Size = new System.Drawing.Size(836, 5);
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
            // UpPanel
            // 
            this.UpPanel.AutoScroll = true;
            this.UpPanel.Controls.Add(this.grpSerialPort);
            this.UpPanel.Controls.Add(this.grpRegSelector);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(14, 14);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1276, 146);
            this.UpPanel.TabIndex = 0;
            // 
            // grpSerialPort
            // 
            this.grpSerialPort.Controls.Add(this.lblPortStatus);
            this.grpSerialPort.Controls.Add(this.materialLabel6);
            this.grpSerialPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpSerialPort.Location = new System.Drawing.Point(638, 0);
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
            this.lblPortStatus.Location = new System.Drawing.Point(10, 45);
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
            // grpRegSelector
            // 
            this.grpRegSelector.Controls.Add(this.lblStatus);
            this.grpRegSelector.Controls.Add(this.materialLabel8);
            this.grpRegSelector.Controls.Add(this.lblUserInput);
            this.grpRegSelector.Controls.Add(this.materialLabel5);
            this.grpRegSelector.Controls.Add(this.materialLabel4);
            this.grpRegSelector.Controls.Add(this.materialLabel3);
            this.grpRegSelector.Controls.Add(this.lblTujuan);
            this.grpRegSelector.Controls.Add(this.lblTglInput);
            this.grpRegSelector.Controls.Add(this.lblNoPlat);
            this.grpRegSelector.Controls.Add(this.btnFind);
            this.grpRegSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpRegSelector.Location = new System.Drawing.Point(0, 0);
            this.grpRegSelector.Name = "grpRegSelector";
            this.grpRegSelector.Size = new System.Drawing.Size(638, 146);
            this.grpRegSelector.TabIndex = 26;
            this.grpRegSelector.TabStop = false;
            this.grpRegSelector.Text = "REGISTER SELECTOR";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.Location = new System.Drawing.Point(81, 125);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 19);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "STATUS :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(9, 125);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "STATUS :";
            // 
            // lblUserInput
            // 
            this.lblUserInput.AutoSize = true;
            this.lblUserInput.Depth = 0;
            this.lblUserInput.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserInput.Location = new System.Drawing.Point(67, 103);
            this.lblUserInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(52, 19);
            this.lblUserInput.TabIndex = 10;
            this.lblUserInput.Text = "USER : ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(9, 45);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(91, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "TGL_INPUT :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(9, 19);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(70, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "NOPLAT :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(9, 103);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "USER : ";
            // 
            // lblTujuan
            // 
            this.lblTujuan.AutoSize = true;
            this.lblTujuan.Depth = 0;
            this.lblTujuan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTujuan.Location = new System.Drawing.Point(9, 74);
            this.lblTujuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTujuan.Name = "lblTujuan";
            this.lblTujuan.Size = new System.Drawing.Size(616, 19);
            this.lblTujuan.TabIndex = 6;
            this.lblTujuan.Text = "TUJUAN : C1: 14201167 | C2: 14201167 | C3: 14201197 | C4: 14201197 | C5: 14201197" +
    "";
            // 
            // lblTglInput
            // 
            this.lblTglInput.AutoSize = true;
            this.lblTglInput.Depth = 0;
            this.lblTglInput.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTglInput.Location = new System.Drawing.Point(106, 45);
            this.lblTglInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTglInput.Name = "lblTglInput";
            this.lblTglInput.Size = new System.Drawing.Size(91, 19);
            this.lblTglInput.TabIndex = 5;
            this.lblTglInput.Text = "TGL_INPUT :";
            // 
            // lblNoPlat
            // 
            this.lblNoPlat.AutoSize = true;
            this.lblNoPlat.Depth = 0;
            this.lblNoPlat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoPlat.Location = new System.Drawing.Point(81, 19);
            this.lblNoPlat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoPlat.Name = "lblNoPlat";
            this.lblNoPlat.Size = new System.Drawing.Size(62, 19);
            this.lblNoPlat.TabIndex = 4;
            this.lblNoPlat.Text = "NOPLAT";
            // 
            // btnFind
            // 
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFind.Depth = 0;
            this.btnFind.HighEmphasis = true;
            this.btnFind.Icon = null;
            this.btnFind.Location = new System.Drawing.Point(382, 19);
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
            this.TabSelector.Size = new System.Drawing.Size(1318, 48);
            this.TabSelector.TabIndex = 5;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // CollectSealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 504);
            this.Controls.Add(this.OuterMostPanel);
            this.Name = "CollectSealForm";
            this.Text = "CollectSealForm";
            this.Load += new System.EventHandler(this.CollectSealForm_Load);
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
            this.TPCollectSeal.ResumeLayout(false);
            this.TPCollectSeal.PerformLayout();
            this.CardCRUD.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.grpRegisLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectDetail)).EndInit();
            this.pnlTopRLive.ResumeLayout(false);
            this.pnlTopRLive.PerformLayout();
            this.UpPanel.ResumeLayout(false);
            this.grpSerialPort.ResumeLayout(false);
            this.grpSerialPort.PerformLayout();
            this.grpRegSelector.ResumeLayout(false);
            this.grpRegSelector.PerformLayout();
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
        private MaterialSkin.Controls.MaterialCard UpCard;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.DateTimePicker dtpRegTo;
        private System.Windows.Forms.DateTimePicker dtpRegFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox cbxRegSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegSearch;
        private MaterialSkin.Controls.MaterialButton btnCollect;
        private System.Windows.Forms.TabPage TPCollectSeal;
        private MaterialSkin.Controls.MaterialCard CardCRUD;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.GroupBox grpRegisLive;
        private System.Windows.Forms.DataGridView dgvCollectDetail;
        private System.Windows.Forms.RichTextBox txtSerialLog;
        private System.Windows.Forms.Panel pnlTopRLive;
        private MaterialSkin.Controls.MaterialButton btnClearLog;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialProgressBar ProListen;
        private MaterialSkin.Controls.MaterialButton btnStartListen;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.GroupBox grpSerialPort;
        private System.Windows.Forms.Label lblPortStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.GroupBox grpRegSelector;
        private MaterialSkin.Controls.MaterialLabel lblNoPlat;
        private MaterialSkin.Controls.MaterialButton btnFind;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblUserInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblTujuan;
        private MaterialSkin.Controls.MaterialLabel lblTglInput;
    }
}