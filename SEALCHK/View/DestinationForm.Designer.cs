namespace SEALCHK.View
{
    partial class DestinationForm
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
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.Type = new MaterialSkin.Controls.MaterialLabel();
            this.txtNamaSPBU = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtKodeTujuan = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            this.btnImport = new MaterialSkin.Controls.MaterialButton();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.CardCRUD = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNamaKepemilikan = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNamaRegional = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxOwned = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxRegional = new MaterialSkin.Controls.MaterialComboBox();
            this.lblUserTYPE = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAlamatSPBU = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNoPlat = new MaterialSkin.Controls.MaterialLabel();
            this.TPAddEditTujuan = new System.Windows.Forms.TabPage();
            this.btnDelete = new SEALCHK.CustomMaterialButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvTujuan = new System.Windows.Forms.DataGridView();
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.TPTujuan = new System.Windows.Forms.TabPage();
            this.TCTujuan = new MaterialSkin.Controls.MaterialTabControl();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.CardCRUD.SuspendLayout();
            this.TPAddEditTujuan.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTujuan)).BeginInit();
            this.LeftCard.SuspendLayout();
            this.TPTujuan.SuspendLayout();
            this.TCTujuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(268, 379);
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
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(146, 379);
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
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(19, 379);
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
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Depth = 0;
            this.Type.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Type.Location = new System.Drawing.Point(17, 119);
            this.Type.MouseState = MaterialSkin.MouseState.HOVER;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(90, 19);
            this.Type.TabIndex = 4;
            this.Type.Text = "NAMA SPBU";
            // 
            // txtNamaSPBU
            // 
            this.txtNamaSPBU.AnimateReadOnly = false;
            this.txtNamaSPBU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNamaSPBU.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamaSPBU.Depth = 0;
            this.txtNamaSPBU.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNamaSPBU.HideSelection = true;
            this.txtNamaSPBU.LeadingIcon = null;
            this.txtNamaSPBU.Location = new System.Drawing.Point(17, 150);
            this.txtNamaSPBU.MaxLength = 32767;
            this.txtNamaSPBU.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNamaSPBU.Name = "txtNamaSPBU";
            this.txtNamaSPBU.PasswordChar = '\0';
            this.txtNamaSPBU.PrefixSuffixText = null;
            this.txtNamaSPBU.ReadOnly = false;
            this.txtNamaSPBU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNamaSPBU.SelectedText = "";
            this.txtNamaSPBU.SelectionLength = 0;
            this.txtNamaSPBU.SelectionStart = 0;
            this.txtNamaSPBU.ShortcutsEnabled = true;
            this.txtNamaSPBU.Size = new System.Drawing.Size(250, 48);
            this.txtNamaSPBU.TabIndex = 3;
            this.txtNamaSPBU.TabStop = false;
            this.txtNamaSPBU.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamaSPBU.TrailingIcon = null;
            this.txtNamaSPBU.UseSystemPasswordChar = false;
            // 
            // txtKodeTujuan
            // 
            this.txtKodeTujuan.AnimateReadOnly = false;
            this.txtKodeTujuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKodeTujuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKodeTujuan.Depth = 0;
            this.txtKodeTujuan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKodeTujuan.HideSelection = true;
            this.txtKodeTujuan.LeadingIcon = null;
            this.txtKodeTujuan.Location = new System.Drawing.Point(17, 56);
            this.txtKodeTujuan.MaxLength = 32767;
            this.txtKodeTujuan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKodeTujuan.Name = "txtKodeTujuan";
            this.txtKodeTujuan.PasswordChar = '\0';
            this.txtKodeTujuan.PrefixSuffixText = null;
            this.txtKodeTujuan.ReadOnly = false;
            this.txtKodeTujuan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKodeTujuan.SelectedText = "";
            this.txtKodeTujuan.SelectionLength = 0;
            this.txtKodeTujuan.SelectionStart = 0;
            this.txtKodeTujuan.ShortcutsEnabled = true;
            this.txtKodeTujuan.Size = new System.Drawing.Size(250, 48);
            this.txtKodeTujuan.TabIndex = 1;
            this.txtKodeTujuan.TabStop = false;
            this.txtKodeTujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKodeTujuan.TrailingIcon = null;
            this.txtKodeTujuan.UseSystemPasswordChar = false;
            // 
            // btnExport
            // 
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExport.Depth = 0;
            this.btnExport.HighEmphasis = true;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(737, 6);
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
            this.btnImport.Location = new System.Drawing.Point(600, 6);
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
            // CardCRUD
            // 
            this.CardCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardCRUD.Controls.Add(this.materialLabel5);
            this.CardCRUD.Controls.Add(this.txtNamaKepemilikan);
            this.CardCRUD.Controls.Add(this.materialLabel4);
            this.CardCRUD.Controls.Add(this.txtNamaRegional);
            this.CardCRUD.Controls.Add(this.cbxOwned);
            this.CardCRUD.Controls.Add(this.materialLabel3);
            this.CardCRUD.Controls.Add(this.cbxRegional);
            this.CardCRUD.Controls.Add(this.lblUserTYPE);
            this.CardCRUD.Controls.Add(this.materialLabel2);
            this.CardCRUD.Controls.Add(this.txtAlamatSPBU);
            this.CardCRUD.Controls.Add(this.btnBack);
            this.CardCRUD.Controls.Add(this.btnClear);
            this.CardCRUD.Controls.Add(this.btnSave);
            this.CardCRUD.Controls.Add(this.Type);
            this.CardCRUD.Controls.Add(this.txtNamaSPBU);
            this.CardCRUD.Controls.Add(this.lblNoPlat);
            this.CardCRUD.Controls.Add(this.txtKodeTujuan);
            this.CardCRUD.Depth = 0;
            this.CardCRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardCRUD.Location = new System.Drawing.Point(0, 0);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(14);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(14);
            this.CardCRUD.Size = new System.Drawing.Size(1308, 435);
            this.CardCRUD.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(588, 214);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(150, 19);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "NAMA KEPEMILIKAN";
            // 
            // txtNamaKepemilikan
            // 
            this.txtNamaKepemilikan.AnimateReadOnly = false;
            this.txtNamaKepemilikan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNamaKepemilikan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamaKepemilikan.Depth = 0;
            this.txtNamaKepemilikan.Enabled = false;
            this.txtNamaKepemilikan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNamaKepemilikan.HideSelection = true;
            this.txtNamaKepemilikan.LeadingIcon = null;
            this.txtNamaKepemilikan.Location = new System.Drawing.Point(588, 245);
            this.txtNamaKepemilikan.MaxLength = 32767;
            this.txtNamaKepemilikan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNamaKepemilikan.Name = "txtNamaKepemilikan";
            this.txtNamaKepemilikan.PasswordChar = '\0';
            this.txtNamaKepemilikan.PrefixSuffixText = null;
            this.txtNamaKepemilikan.ReadOnly = false;
            this.txtNamaKepemilikan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNamaKepemilikan.SelectedText = "";
            this.txtNamaKepemilikan.SelectionLength = 0;
            this.txtNamaKepemilikan.SelectionStart = 0;
            this.txtNamaKepemilikan.ShortcutsEnabled = true;
            this.txtNamaKepemilikan.Size = new System.Drawing.Size(250, 48);
            this.txtNamaKepemilikan.TabIndex = 25;
            this.txtNamaKepemilikan.TabStop = false;
            this.txtNamaKepemilikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamaKepemilikan.TrailingIcon = null;
            this.txtNamaKepemilikan.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(315, 214);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(125, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "NAMA REGIONAL";
            // 
            // txtNamaRegional
            // 
            this.txtNamaRegional.AnimateReadOnly = false;
            this.txtNamaRegional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNamaRegional.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamaRegional.Depth = 0;
            this.txtNamaRegional.Enabled = false;
            this.txtNamaRegional.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNamaRegional.HideSelection = true;
            this.txtNamaRegional.LeadingIcon = null;
            this.txtNamaRegional.Location = new System.Drawing.Point(315, 245);
            this.txtNamaRegional.MaxLength = 32767;
            this.txtNamaRegional.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNamaRegional.Name = "txtNamaRegional";
            this.txtNamaRegional.PasswordChar = '\0';
            this.txtNamaRegional.PrefixSuffixText = null;
            this.txtNamaRegional.ReadOnly = false;
            this.txtNamaRegional.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNamaRegional.SelectedText = "";
            this.txtNamaRegional.SelectionLength = 0;
            this.txtNamaRegional.SelectionStart = 0;
            this.txtNamaRegional.ShortcutsEnabled = true;
            this.txtNamaRegional.Size = new System.Drawing.Size(250, 48);
            this.txtNamaRegional.TabIndex = 23;
            this.txtNamaRegional.TabStop = false;
            this.txtNamaRegional.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamaRegional.TrailingIcon = null;
            this.txtNamaRegional.UseSystemPasswordChar = false;
            // 
            // cbxOwned
            // 
            this.cbxOwned.AutoResize = false;
            this.cbxOwned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxOwned.Depth = 0;
            this.cbxOwned.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxOwned.DropDownHeight = 174;
            this.cbxOwned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOwned.DropDownWidth = 121;
            this.cbxOwned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxOwned.FormattingEnabled = true;
            this.cbxOwned.IntegralHeight = false;
            this.cbxOwned.ItemHeight = 43;
            this.cbxOwned.Location = new System.Drawing.Point(588, 149);
            this.cbxOwned.MaxDropDownItems = 4;
            this.cbxOwned.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxOwned.Name = "cbxOwned";
            this.cbxOwned.Size = new System.Drawing.Size(250, 49);
            this.cbxOwned.StartIndex = 0;
            this.cbxOwned.TabIndex = 22;
            this.cbxOwned.SelectedIndexChanged += new System.EventHandler(this.cbxOwned_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(595, 119);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "KODE KEPEMILIKAN";
            // 
            // cbxRegional
            // 
            this.cbxRegional.AutoResize = false;
            this.cbxRegional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxRegional.Depth = 0;
            this.cbxRegional.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxRegional.DropDownHeight = 174;
            this.cbxRegional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegional.DropDownWidth = 121;
            this.cbxRegional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxRegional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxRegional.FormattingEnabled = true;
            this.cbxRegional.IntegralHeight = false;
            this.cbxRegional.ItemHeight = 43;
            this.cbxRegional.Location = new System.Drawing.Point(315, 149);
            this.cbxRegional.MaxDropDownItems = 4;
            this.cbxRegional.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxRegional.Name = "cbxRegional";
            this.cbxRegional.Size = new System.Drawing.Size(250, 49);
            this.cbxRegional.StartIndex = 0;
            this.cbxRegional.TabIndex = 20;
            this.cbxRegional.SelectedIndexChanged += new System.EventHandler(this.cbxRegional_SelectedIndexChanged);
            // 
            // lblUserTYPE
            // 
            this.lblUserTYPE.AutoSize = true;
            this.lblUserTYPE.Depth = 0;
            this.lblUserTYPE.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserTYPE.Location = new System.Drawing.Point(322, 119);
            this.lblUserTYPE.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserTYPE.Name = "lblUserTYPE";
            this.lblUserTYPE.Size = new System.Drawing.Size(121, 19);
            this.lblUserTYPE.TabIndex = 19;
            this.lblUserTYPE.Text = "KODE REGIONAL";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(20, 214);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "ALAMAT SPBU";
            // 
            // txtAlamatSPBU
            // 
            this.txtAlamatSPBU.AnimateReadOnly = false;
            this.txtAlamatSPBU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAlamatSPBU.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAlamatSPBU.Depth = 0;
            this.txtAlamatSPBU.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlamatSPBU.HideSelection = true;
            this.txtAlamatSPBU.LeadingIcon = null;
            this.txtAlamatSPBU.Location = new System.Drawing.Point(20, 245);
            this.txtAlamatSPBU.MaxLength = 32767;
            this.txtAlamatSPBU.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlamatSPBU.Name = "txtAlamatSPBU";
            this.txtAlamatSPBU.PasswordChar = '\0';
            this.txtAlamatSPBU.PrefixSuffixText = null;
            this.txtAlamatSPBU.ReadOnly = false;
            this.txtAlamatSPBU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlamatSPBU.SelectedText = "";
            this.txtAlamatSPBU.SelectionLength = 0;
            this.txtAlamatSPBU.SelectionStart = 0;
            this.txtAlamatSPBU.ShortcutsEnabled = true;
            this.txtAlamatSPBU.Size = new System.Drawing.Size(250, 48);
            this.txtAlamatSPBU.TabIndex = 13;
            this.txtAlamatSPBU.TabStop = false;
            this.txtAlamatSPBU.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAlamatSPBU.TrailingIcon = null;
            this.txtAlamatSPBU.UseSystemPasswordChar = false;
            // 
            // lblNoPlat
            // 
            this.lblNoPlat.AutoSize = true;
            this.lblNoPlat.Depth = 0;
            this.lblNoPlat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoPlat.Location = new System.Drawing.Point(17, 25);
            this.lblNoPlat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoPlat.Name = "lblNoPlat";
            this.lblNoPlat.Size = new System.Drawing.Size(106, 19);
            this.lblNoPlat.TabIndex = 2;
            this.lblNoPlat.Text = "KODE TUJUAN";
            // 
            // TPAddEditTujuan
            // 
            this.TPAddEditTujuan.Controls.Add(this.CardCRUD);
            this.TPAddEditTujuan.Location = new System.Drawing.Point(4, 22);
            this.TPAddEditTujuan.Name = "TPAddEditTujuan";
            this.TPAddEditTujuan.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddEditTujuan.Size = new System.Drawing.Size(1308, 431);
            this.TPAddEditTujuan.TabIndex = 1;
            this.TPAddEditTujuan.Text = "ADD / EDIT TUJUAN";
            this.TPAddEditTujuan.UseVisualStyleBackColor = true;
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
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.btnExport);
            this.TopPanel.Controls.Add(this.btnImport);
            this.TopPanel.Controls.Add(this.btnNew);
            this.TopPanel.Controls.Add(this.btnDelete);
            this.TopPanel.Controls.Add(this.btnEdit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1302, 53);
            this.TopPanel.TabIndex = 0;
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "List Tujuan";
            // 
            // dgvTujuan
            // 
            this.dgvTujuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTujuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTujuan.Location = new System.Drawing.Point(6, 29);
            this.dgvTujuan.Name = "dgvTujuan";
            this.dgvTujuan.Size = new System.Drawing.Size(1290, 337);
            this.dgvTujuan.TabIndex = 0;
            // 
            // LeftCard
            // 
            this.LeftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftCard.Controls.Add(this.materialLabel1);
            this.LeftCard.Controls.Add(this.dgvTujuan);
            this.LeftCard.Depth = 0;
            this.LeftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftCard.Location = new System.Drawing.Point(3, 56);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(14);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(3);
            this.LeftCard.Size = new System.Drawing.Size(1302, 372);
            this.LeftCard.TabIndex = 8;
            // 
            // TPTujuan
            // 
            this.TPTujuan.Controls.Add(this.LeftCard);
            this.TPTujuan.Controls.Add(this.TopPanel);
            this.TPTujuan.Location = new System.Drawing.Point(4, 22);
            this.TPTujuan.Name = "TPTujuan";
            this.TPTujuan.Padding = new System.Windows.Forms.Padding(3);
            this.TPTujuan.Size = new System.Drawing.Size(1308, 431);
            this.TPTujuan.TabIndex = 0;
            this.TPTujuan.Text = "TUJUAN";
            this.TPTujuan.UseVisualStyleBackColor = true;
            // 
            // TCTujuan
            // 
            this.TCTujuan.Controls.Add(this.TPTujuan);
            this.TCTujuan.Controls.Add(this.TPAddEditTujuan);
            this.TCTujuan.Depth = 0;
            this.TCTujuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCTujuan.Location = new System.Drawing.Point(0, 48);
            this.TCTujuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCTujuan.Multiline = true;
            this.TCTujuan.Name = "TCTujuan";
            this.TCTujuan.SelectedIndex = 0;
            this.TCTujuan.Size = new System.Drawing.Size(1316, 457);
            this.TCTujuan.TabIndex = 2;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TCTujuan;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1316, 48);
            this.TabSelector.TabIndex = 3;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 505);
            this.Controls.Add(this.TCTujuan);
            this.Controls.Add(this.TabSelector);
            this.Name = "DestinationForm";
            this.Text = "DestinationForm";
            this.Load += new System.EventHandler(this.DestinationForm_Load);
            this.CardCRUD.ResumeLayout(false);
            this.CardCRUD.PerformLayout();
            this.TPAddEditTujuan.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTujuan)).EndInit();
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            this.TPTujuan.ResumeLayout(false);
            this.TCTujuan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialLabel Type;
        private MaterialSkin.Controls.MaterialTextBox2 txtNamaSPBU;
        private MaterialSkin.Controls.MaterialTextBox2 txtKodeTujuan;
        private MaterialSkin.Controls.MaterialButton btnExport;
        private MaterialSkin.Controls.MaterialButton btnImport;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialCard CardCRUD;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtAlamatSPBU;
        private MaterialSkin.Controls.MaterialLabel lblNoPlat;
        private System.Windows.Forms.TabPage TPAddEditTujuan;
        private CustomMaterialButton btnDelete;
        private System.Windows.Forms.Panel TopPanel;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvTujuan;
        private MaterialSkin.Controls.MaterialCard LeftCard;
        private System.Windows.Forms.TabPage TPTujuan;
        private MaterialSkin.Controls.MaterialTabControl TCTujuan;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtNamaKepemilikan;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtNamaRegional;
        private MaterialSkin.Controls.MaterialComboBox cbxOwned;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbxRegional;
        private MaterialSkin.Controls.MaterialLabel lblUserTYPE;
    }
}