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
            this.UpPanel = new System.Windows.Forms.Panel();
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
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.chkAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPengiriman = new System.Windows.Forms.DataGridView();
            this.leftbottomPanel = new System.Windows.Forms.Panel();
            this.grpDetailPengiriman = new System.Windows.Forms.GroupBox();
            this.FLDetailPengiriman = new System.Windows.Forms.FlowLayoutPanel();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.txtSerialLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPengirimanLive = new System.Windows.Forms.DataGridView();
            this.LeftPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.UpCard.SuspendLayout();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).BeginInit();
            this.leftbottomPanel.SuspendLayout();
            this.grpDetailPengiriman.SuspendLayout();
            this.contentpanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengirimanLive)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.leftbottomPanel);
            this.LeftPanel.Controls.Add(this.LeftCard);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 100);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(811, 611);
            this.LeftPanel.TabIndex = 0;
            // 
            // UpPanel
            // 
            this.UpPanel.Controls.Add(this.UpCard);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1296, 100);
            this.UpPanel.TabIndex = 1;
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
            this.UpCard.Size = new System.Drawing.Size(1296, 100);
            this.UpCard.TabIndex = 1;
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
            this.dgvPengiriman.Size = new System.Drawing.Size(799, 208);
            this.dgvPengiriman.TabIndex = 0;
            // 
            // leftbottomPanel
            // 
            this.leftbottomPanel.Controls.Add(this.grpDetailPengiriman);
            this.leftbottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftbottomPanel.Location = new System.Drawing.Point(0, 257);
            this.leftbottomPanel.Name = "leftbottomPanel";
            this.leftbottomPanel.Size = new System.Drawing.Size(811, 354);
            this.leftbottomPanel.TabIndex = 10;
            // 
            // grpDetailPengiriman
            // 
            this.grpDetailPengiriman.Controls.Add(this.FLDetailPengiriman);
            this.grpDetailPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetailPengiriman.Location = new System.Drawing.Point(0, 0);
            this.grpDetailPengiriman.Name = "grpDetailPengiriman";
            this.grpDetailPengiriman.Size = new System.Drawing.Size(811, 354);
            this.grpDetailPengiriman.TabIndex = 0;
            this.grpDetailPengiriman.TabStop = false;
            this.grpDetailPengiriman.Text = "DETAIL PENGIRIMAN";
            // 
            // FLDetailPengiriman
            // 
            this.FLDetailPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLDetailPengiriman.Location = new System.Drawing.Point(3, 16);
            this.FLDetailPengiriman.Name = "FLDetailPengiriman";
            this.FLDetailPengiriman.Size = new System.Drawing.Size(805, 335);
            this.FLDetailPengiriman.TabIndex = 0;
            // 
            // contentpanel
            // 
            this.contentpanel.Controls.Add(this.groupBox1);
            this.contentpanel.Controls.Add(this.RightPanel);
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(811, 100);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(485, 611);
            this.contentpanel.TabIndex = 2;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.txtSerialLog);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(3);
            this.RightPanel.Size = new System.Drawing.Size(485, 257);
            this.RightPanel.TabIndex = 3;
            // 
            // txtSerialLog
            // 
            this.txtSerialLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSerialLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialLog.Location = new System.Drawing.Point(3, 3);
            this.txtSerialLog.Name = "txtSerialLog";
            this.txtSerialLog.Size = new System.Drawing.Size(479, 251);
            this.txtSerialLog.TabIndex = 15;
            this.txtSerialLog.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPengirimanLive);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 354);
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
            this.dgvPengirimanLive.Size = new System.Drawing.Size(479, 335);
            this.dgvPengirimanLive.TabIndex = 12;
            // 
            // PengirimanFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 711);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.UpPanel);
            this.Name = "PengirimanFormNew";
            this.Text = "PengirimanFormNew";
            this.LeftPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.UpCard.ResumeLayout(false);
            this.UpCard.PerformLayout();
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).EndInit();
            this.leftbottomPanel.ResumeLayout(false);
            this.grpDetailPengiriman.ResumeLayout(false);
            this.contentpanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengirimanLive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel UpPanel;
        private MaterialSkin.Controls.MaterialCard UpCard;
        private Custom.CustomMaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.DateTimePicker dtpPengTo;
        private System.Windows.Forms.DateTimePicker dtpPengFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox cbxPengSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchPeng;
        private MaterialSkin.Controls.MaterialButton btnNew;
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
    }
}