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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPengiriman = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.UpCard = new MaterialSkin.Controls.MaterialCard();
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
            this.RightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.UpPanel = new System.Windows.Forms.Panel();
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
            this.SuspendLayout();
            // 
            // TCPengiriman
            // 
            this.TCPengiriman.Controls.Add(this.TPPengiriman);
            this.TCPengiriman.Controls.Add(this.TPAddPengiriman);
            this.TCPengiriman.Depth = 0;
            this.TCPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCPengiriman.Location = new System.Drawing.Point(0, 59);
            this.TCPengiriman.Margin = new System.Windows.Forms.Padding(4);
            this.TCPengiriman.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCPengiriman.Multiline = true;
            this.TCPengiriman.Name = "TCPengiriman";
            this.TCPengiriman.SelectedIndex = 0;
            this.TCPengiriman.Size = new System.Drawing.Size(1172, 563);
            this.TCPengiriman.TabIndex = 6;
            // 
            // TPPengiriman
            // 
            this.TPPengiriman.Controls.Add(this.RightCard);
            this.TPPengiriman.Controls.Add(this.LeftCard);
            this.TPPengiriman.Controls.Add(this.TopPanel);
            this.TPPengiriman.Location = new System.Drawing.Point(4, 25);
            this.TPPengiriman.Margin = new System.Windows.Forms.Padding(4);
            this.TPPengiriman.Name = "TPPengiriman";
            this.TPPengiriman.Padding = new System.Windows.Forms.Padding(4);
            this.TPPengiriman.Size = new System.Drawing.Size(1164, 534);
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
            this.RightCard.Location = new System.Drawing.Point(4, 372);
            this.RightCard.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.RightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightCard.Name = "RightCard";
            this.RightCard.Padding = new System.Windows.Forms.Padding(4);
            this.RightCard.Size = new System.Drawing.Size(1156, 158);
            this.RightCard.TabIndex = 9;
            // 
            // dgvDetailPengiriman
            // 
            this.dgvDetailPengiriman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPengiriman.Location = new System.Drawing.Point(8, 36);
            this.dgvDetailPengiriman.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetailPengiriman.Name = "dgvDetailPengiriman";
            this.dgvDetailPengiriman.Size = new System.Drawing.Size(1140, 115);
            this.dgvDetailPengiriman.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(8, 9);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "DETAIL PENGIRIMAN";
            // 
            // LeftCard
            // 
            this.LeftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftCard.Controls.Add(this.materialLabel1);
            this.LeftCard.Controls.Add(this.dgvPengiriman);
            this.LeftCard.Depth = 0;
            this.LeftCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftCard.Location = new System.Drawing.Point(4, 102);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(4);
            this.LeftCard.Size = new System.Drawing.Size(1156, 270);
            this.LeftCard.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(8, 9);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.dgvPengiriman.Location = new System.Drawing.Point(8, 36);
            this.dgvPengiriman.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPengiriman.Name = "dgvPengiriman";
            this.dgvPengiriman.Size = new System.Drawing.Size(1140, 226);
            this.dgvPengiriman.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.UpCard);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(4, 4);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1156, 98);
            this.TopPanel.TabIndex = 0;
            // 
            // UpCard
            // 
            this.UpCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.UpCard.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.UpCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpCard.Name = "UpCard";
            this.UpCard.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.UpCard.Size = new System.Drawing.Size(1156, 98);
            this.UpCard.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(1183, 36);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            this.dtpPengTo.Location = new System.Drawing.Point(895, 68);
            this.dtpPengTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPengTo.Name = "dtpPengTo";
            this.dtpPengTo.Size = new System.Drawing.Size(265, 22);
            this.dtpPengTo.TabIndex = 30;
            // 
            // dtpPengFrom
            // 
            this.dtpPengFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpPengFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPengFrom.Location = new System.Drawing.Point(895, 36);
            this.dtpPengFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPengFrom.Name = "dtpPengFrom";
            this.dtpPengFrom.Size = new System.Drawing.Size(265, 22);
            this.dtpPengFrom.TabIndex = 29;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(895, 11);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.cbxPengSearchBy.Location = new System.Drawing.Point(720, 34);
            this.cbxPengSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPengSearchBy.MaxDropDownItems = 4;
            this.cbxPengSearchBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPengSearchBy.Name = "cbxPengSearchBy";
            this.cbxPengSearchBy.Size = new System.Drawing.Size(165, 49);
            this.cbxPengSearchBy.StartIndex = 0;
            this.cbxPengSearchBy.TabIndex = 27;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(733, 11);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.txtSearchPeng.Location = new System.Drawing.Point(365, 36);
            this.txtSearchPeng.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtSearchPeng.Size = new System.Drawing.Size(347, 48);
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
            this.btnNew.Location = new System.Drawing.Point(24, 36);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(64, 36);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "ADD";
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // TPAddPengiriman
            // 
            this.TPAddPengiriman.Controls.Add(this.CardCRUD);
            this.TPAddPengiriman.Location = new System.Drawing.Point(4, 25);
            this.TPAddPengiriman.Margin = new System.Windows.Forms.Padding(4);
            this.TPAddPengiriman.Name = "TPAddPengiriman";
            this.TPAddPengiriman.Padding = new System.Windows.Forms.Padding(4);
            this.TPAddPengiriman.Size = new System.Drawing.Size(1164, 534);
            this.TPAddPengiriman.TabIndex = 1;
            this.TPAddPengiriman.Text = "ADD PENGIRIMAN";
            this.TPAddPengiriman.UseVisualStyleBackColor = true;
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
            this.CardCRUD.Location = new System.Drawing.Point(4, 4);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.CardCRUD.Size = new System.Drawing.Size(1156, 526);
            this.CardCRUD.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(894, 197);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(243, 312);
            this.RightPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(19, 197);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(875, 312);
            this.leftPanel.TabIndex = 1;
            // 
            // UpPanel
            // 
            this.UpPanel.AutoScroll = true;
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(19, 17);
            this.UpPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1118, 180);
            this.UpPanel.TabIndex = 0;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TCPengiriman;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.Margin = new System.Windows.Forms.Padding(4);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1172, 59);
            this.TabSelector.TabIndex = 7;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // PengirimanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 622);
            this.Controls.Add(this.TCPengiriman);
            this.Controls.Add(this.TabSelector);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}