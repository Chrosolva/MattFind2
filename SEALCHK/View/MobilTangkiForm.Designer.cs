namespace SEALCHK.View
{
    partial class MobilTangkiForm
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
            this.TCMobilTangki = new MaterialSkin.Controls.MaterialTabControl();
            this.TPMobilTangki = new System.Windows.Forms.TabPage();
            this.RightCard = new MaterialSkin.Controls.MaterialCard();
            this.dgvDetailMT = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvMobilTangki = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            this.btnImport = new MaterialSkin.Controls.MaterialButton();
            this.btnAutoDetail = new MaterialSkin.Controls.MaterialButton();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new SEALCHK.CustomMaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.TPAddEditMT = new System.Windows.Forms.TabPage();
            this.CardCRUD = new MaterialSkin.Controls.MaterialCard();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.NUDPanelCover = new System.Windows.Forms.NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.NUDJlhCompartment = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Type = new MaterialSkin.Controls.MaterialLabel();
            this.txtType = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNoPlat = new MaterialSkin.Controls.MaterialLabel();
            this.txtNoPlat = new MaterialSkin.Controls.MaterialTextBox2();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TCMobilTangki.SuspendLayout();
            this.TPMobilTangki.SuspendLayout();
            this.RightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailMT)).BeginInit();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobilTangki)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.TPAddEditMT.SuspendLayout();
            this.CardCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPanelCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDJlhCompartment)).BeginInit();
            this.SuspendLayout();
            // 
            // TCMobilTangki
            // 
            this.TCMobilTangki.Controls.Add(this.TPMobilTangki);
            this.TCMobilTangki.Controls.Add(this.TPAddEditMT);
            this.TCMobilTangki.Depth = 0;
            this.TCMobilTangki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMobilTangki.Location = new System.Drawing.Point(0, 48);
            this.TCMobilTangki.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCMobilTangki.Multiline = true;
            this.TCMobilTangki.Name = "TCMobilTangki";
            this.TCMobilTangki.SelectedIndex = 0;
            this.TCMobilTangki.Size = new System.Drawing.Size(1102, 423);
            this.TCMobilTangki.TabIndex = 0;
            // 
            // TPMobilTangki
            // 
            this.TPMobilTangki.Controls.Add(this.RightCard);
            this.TPMobilTangki.Controls.Add(this.LeftCard);
            this.TPMobilTangki.Controls.Add(this.TopPanel);
            this.TPMobilTangki.Location = new System.Drawing.Point(4, 22);
            this.TPMobilTangki.Name = "TPMobilTangki";
            this.TPMobilTangki.Padding = new System.Windows.Forms.Padding(3);
            this.TPMobilTangki.Size = new System.Drawing.Size(1094, 397);
            this.TPMobilTangki.TabIndex = 0;
            this.TPMobilTangki.Text = "MOBIL TANGKI";
            this.TPMobilTangki.UseVisualStyleBackColor = true;
            // 
            // RightCard
            // 
            this.RightCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightCard.Controls.Add(this.dgvDetailMT);
            this.RightCard.Controls.Add(this.materialLabel2);
            this.RightCard.Depth = 0;
            this.RightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RightCard.Location = new System.Drawing.Point(731, 56);
            this.RightCard.Margin = new System.Windows.Forms.Padding(14);
            this.RightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightCard.Name = "RightCard";
            this.RightCard.Padding = new System.Windows.Forms.Padding(3);
            this.RightCard.Size = new System.Drawing.Size(360, 338);
            this.RightCard.TabIndex = 9;
            // 
            // dgvDetailMT
            // 
            this.dgvDetailMT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailMT.Location = new System.Drawing.Point(6, 29);
            this.dgvDetailMT.Name = "dgvDetailMT";
            this.dgvDetailMT.Size = new System.Drawing.Size(348, 303);
            this.dgvDetailMT.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "MT Detail ";
            // 
            // LeftCard
            // 
            this.LeftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftCard.Controls.Add(this.materialLabel1);
            this.LeftCard.Controls.Add(this.dgvMobilTangki);
            this.LeftCard.Depth = 0;
            this.LeftCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftCard.Location = new System.Drawing.Point(3, 56);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(14);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(3);
            this.LeftCard.Size = new System.Drawing.Size(728, 338);
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
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "List MT";
            // 
            // dgvMobilTangki
            // 
            this.dgvMobilTangki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMobilTangki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobilTangki.Location = new System.Drawing.Point(6, 29);
            this.dgvMobilTangki.Name = "dgvMobilTangki";
            this.dgvMobilTangki.Size = new System.Drawing.Size(716, 303);
            this.dgvMobilTangki.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.btnExport);
            this.TopPanel.Controls.Add(this.btnImport);
            this.TopPanel.Controls.Add(this.btnAutoDetail);
            this.TopPanel.Controls.Add(this.btnNew);
            this.TopPanel.Controls.Add(this.btnDelete);
            this.TopPanel.Controls.Add(this.btnEdit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1088, 53);
            this.TopPanel.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExport.Depth = 0;
            this.btnExport.HighEmphasis = true;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(558, 6);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExport.Size = new System.Drawing.Size(124, 36);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "EXPORT EXCEL";
            this.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExport.UseAccentColor = true;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImport.Depth = 0;
            this.btnImport.HighEmphasis = true;
            this.btnImport.Icon = null;
            this.btnImport.Location = new System.Drawing.Point(421, 6);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImport.Size = new System.Drawing.Size(123, 36);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "IMPORT EXCEL";
            this.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImport.UseAccentColor = true;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAutoDetail
            // 
            this.btnAutoDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAutoDetail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAutoDetail.Depth = 0;
            this.btnAutoDetail.HighEmphasis = true;
            this.btnAutoDetail.Icon = null;
            this.btnAutoDetail.Location = new System.Drawing.Point(321, 6);
            this.btnAutoDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAutoDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutoDetail.Name = "btnAutoDetail";
            this.btnAutoDetail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAutoDetail.Size = new System.Drawing.Size(92, 36);
            this.btnAutoDetail.TabIndex = 4;
            this.btnAutoDetail.Text = "AUTO GEN";
            this.btnAutoDetail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAutoDetail.UseAccentColor = false;
            this.btnAutoDetail.UseVisualStyleBackColor = true;
            this.btnAutoDetail.Click += new System.EventHandler(this.btnAutoDetail_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = null;
            this.btnNew.Location = new System.Drawing.Point(9, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(64, 36);
            this.btnNew.TabIndex = 3;
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
            this.btnDelete.Location = new System.Drawing.Point(177, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(93, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(64, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TPAddEditMT
            // 
            this.TPAddEditMT.Controls.Add(this.CardCRUD);
            this.TPAddEditMT.Location = new System.Drawing.Point(4, 22);
            this.TPAddEditMT.Name = "TPAddEditMT";
            this.TPAddEditMT.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddEditMT.Size = new System.Drawing.Size(1094, 397);
            this.TPAddEditMT.TabIndex = 1;
            this.TPAddEditMT.Text = "ADD / EDIT MT";
            this.TPAddEditMT.UseVisualStyleBackColor = true;
            // 
            // CardCRUD
            // 
            this.CardCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardCRUD.Controls.Add(this.materialLabel3);
            this.CardCRUD.Controls.Add(this.btnBack);
            this.CardCRUD.Controls.Add(this.btnClear);
            this.CardCRUD.Controls.Add(this.btnSave);
            this.CardCRUD.Controls.Add(this.NUDPanelCover);
            this.CardCRUD.Controls.Add(this.materialLabel5);
            this.CardCRUD.Controls.Add(this.NUDJlhCompartment);
            this.CardCRUD.Controls.Add(this.materialLabel4);
            this.CardCRUD.Controls.Add(this.Type);
            this.CardCRUD.Controls.Add(this.txtType);
            this.CardCRUD.Controls.Add(this.lblNoPlat);
            this.CardCRUD.Controls.Add(this.txtNoPlat);
            this.CardCRUD.Depth = 0;
            this.CardCRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardCRUD.Location = new System.Drawing.Point(0, 0);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(14);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(14);
            this.CardCRUD.Size = new System.Drawing.Size(1094, 401);
            this.CardCRUD.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(266, 252);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(64, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(144, 252);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(17, 252);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save ";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = true;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NUDPanelCover
            // 
            this.NUDPanelCover.Location = new System.Drawing.Point(320, 165);
            this.NUDPanelCover.Name = "NUDPanelCover";
            this.NUDPanelCover.Size = new System.Drawing.Size(44, 20);
            this.NUDPanelCover.TabIndex = 9;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(311, 119);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(85, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Panel Cover";
            // 
            // NUDJlhCompartment
            // 
            this.NUDJlhCompartment.Location = new System.Drawing.Point(320, 71);
            this.NUDJlhCompartment.Name = "NUDJlhCompartment";
            this.NUDJlhCompartment.Size = new System.Drawing.Size(44, 20);
            this.NUDJlhCompartment.TabIndex = 7;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(311, 25);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Compartment";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Depth = 0;
            this.Type.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Type.Location = new System.Drawing.Point(17, 119);
            this.Type.MouseState = MaterialSkin.MouseState.HOVER;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(36, 19);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.AnimateReadOnly = false;
            this.txtType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtType.Depth = 0;
            this.txtType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtType.HideSelection = true;
            this.txtType.LeadingIcon = null;
            this.txtType.Location = new System.Drawing.Point(17, 150);
            this.txtType.MaxLength = 32767;
            this.txtType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PrefixSuffixText = null;
            this.txtType.ReadOnly = false;
            this.txtType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.ShortcutsEnabled = true;
            this.txtType.Size = new System.Drawing.Size(250, 48);
            this.txtType.TabIndex = 3;
            this.txtType.TabStop = false;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtType.TrailingIcon = null;
            this.txtType.UseSystemPasswordChar = false;
            // 
            // lblNoPlat
            // 
            this.lblNoPlat.AutoSize = true;
            this.lblNoPlat.Depth = 0;
            this.lblNoPlat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoPlat.Location = new System.Drawing.Point(17, 25);
            this.lblNoPlat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoPlat.Name = "lblNoPlat";
            this.lblNoPlat.Size = new System.Drawing.Size(53, 19);
            this.lblNoPlat.TabIndex = 2;
            this.lblNoPlat.Text = "No Plat";
            // 
            // txtNoPlat
            // 
            this.txtNoPlat.AnimateReadOnly = false;
            this.txtNoPlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNoPlat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNoPlat.Depth = 0;
            this.txtNoPlat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoPlat.HideSelection = true;
            this.txtNoPlat.LeadingIcon = null;
            this.txtNoPlat.Location = new System.Drawing.Point(17, 56);
            this.txtNoPlat.MaxLength = 32767;
            this.txtNoPlat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoPlat.Name = "txtNoPlat";
            this.txtNoPlat.PasswordChar = '\0';
            this.txtNoPlat.PrefixSuffixText = null;
            this.txtNoPlat.ReadOnly = false;
            this.txtNoPlat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoPlat.SelectedText = "";
            this.txtNoPlat.SelectionLength = 0;
            this.txtNoPlat.SelectionStart = 0;
            this.txtNoPlat.ShortcutsEnabled = true;
            this.txtNoPlat.Size = new System.Drawing.Size(250, 48);
            this.txtNoPlat.TabIndex = 1;
            this.txtNoPlat.TabStop = false;
            this.txtNoPlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoPlat.TrailingIcon = null;
            this.txtNoPlat.UseSystemPasswordChar = false;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TCMobilTangki;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1102, 48);
            this.TabSelector.TabIndex = 1;
            this.TabSelector.Text = "materialTabSelector1";
            this.TabSelector.Click += new System.EventHandler(this.TabSelector_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(797, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Note: Untuk Import Excel diharapkan mengisi detail Status MT sebagai - untuk defa" +
    "ul value nya agar tombol AUTO GEN dapat mengenerate Part ID dari MT.";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(475, 119);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(224, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "DetailStatus DEFAULT VALUE  -";
            // 
            // MobilTangkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 471);
            this.Controls.Add(this.TCMobilTangki);
            this.Controls.Add(this.TabSelector);
            this.Name = "MobilTangkiForm";
            this.Text = "MobilTangkiForm";
            this.Load += new System.EventHandler(this.MobilTangkiForm_Load);
            this.TCMobilTangki.ResumeLayout(false);
            this.TPMobilTangki.ResumeLayout(false);
            this.RightCard.ResumeLayout(false);
            this.RightCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailMT)).EndInit();
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobilTangki)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TPAddEditMT.ResumeLayout(false);
            this.CardCRUD.ResumeLayout(false);
            this.CardCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPanelCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDJlhCompartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCMobilTangki;
        private System.Windows.Forms.TabPage TPMobilTangki;
        private System.Windows.Forms.TabPage TPAddEditMT;
        private MaterialSkin.Controls.MaterialCard LeftCard;
        private MaterialSkin.Controls.MaterialCard RightCard;
        private System.Windows.Forms.Panel TopPanel;
        private CustomMaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private System.Windows.Forms.DataGridView dgvMobilTangki;
        private System.Windows.Forms.DataGridView dgvDetailMT;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard CardCRUD;
        private MaterialSkin.Controls.MaterialTextBox2 txtNoPlat;
        private System.Windows.Forms.NumericUpDown NUDJlhCompartment;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel Type;
        private MaterialSkin.Controls.MaterialTextBox2 txtType;
        private MaterialSkin.Controls.MaterialLabel lblNoPlat;
        private System.Windows.Forms.NumericUpDown NUDPanelCover;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialButton btnAutoDetail;
        private MaterialSkin.Controls.MaterialButton btnExport;
        private MaterialSkin.Controls.MaterialButton btnImport;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}