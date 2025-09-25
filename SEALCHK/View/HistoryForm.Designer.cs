namespace SEALCHK.View
{
    partial class HistoryForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.btnDispose = new SEALCHK.CustomMaterialButton();
            this.chkAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnAppend = new MaterialSkin.Controls.MaterialButton();
            this.txtAppend = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRowCount = new MaterialSkin.Controls.MaterialLabel();
            this.cbxSearchBy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lblPortStatus);
            this.TopPanel.Controls.Add(this.btnDispose);
            this.TopPanel.Controls.Add(this.chkAll);
            this.TopPanel.Controls.Add(this.btnAppend);
            this.TopPanel.Controls.Add(this.txtAppend);
            this.TopPanel.Controls.Add(this.btnFilter);
            this.TopPanel.Controls.Add(this.dtpTo);
            this.TopPanel.Controls.Add(this.dtpFrom);
            this.TopPanel.Controls.Add(this.materialLabel10);
            this.TopPanel.Controls.Add(this.lblRowCount);
            this.TopPanel.Controls.Add(this.cbxSearchBy);
            this.TopPanel.Controls.Add(this.materialLabel2);
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1532, 115);
            this.TopPanel.TabIndex = 6;
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(848, 95);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(63, 13);
            this.lblPortStatus.TabIndex = 9;
            this.lblPortStatus.Text = "Port Status";
            // 
            // btnDispose
            // 
            this.btnDispose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDispose.CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDispose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDispose.Depth = 0;
            this.btnDispose.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispose.HighEmphasis = true;
            this.btnDispose.Icon = null;
            this.btnDispose.Location = new System.Drawing.Point(1184, 27);
            this.btnDispose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDispose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDispose.Size = new System.Drawing.Size(81, 36);
            this.btnDispose.TabIndex = 39;
            this.btnDispose.Text = "DISPOSE";
            this.btnDispose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDispose.UseAccentColor = false;
            this.btnDispose.UseVisualStyleBackColor = true;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Depth = 0;
            this.chkAll.Location = new System.Drawing.Point(15, 75);
            this.chkAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAll.Name = "chkAll";
            this.chkAll.ReadOnly = false;
            this.chkAll.Ripple = true;
            this.chkAll.Size = new System.Drawing.Size(124, 37);
            this.chkAll.TabIndex = 38;
            this.chkAll.Text = "SELECT ALL";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnAppend
            // 
            this.btnAppend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAppend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAppend.Depth = 0;
            this.btnAppend.HighEmphasis = true;
            this.btnAppend.Icon = null;
            this.btnAppend.Location = new System.Drawing.Point(1089, 29);
            this.btnAppend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAppend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAppend.Size = new System.Drawing.Size(78, 36);
            this.btnAppend.TabIndex = 37;
            this.btnAppend.Text = "APPEND";
            this.btnAppend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAppend.UseAccentColor = false;
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // txtAppend
            // 
            this.txtAppend.AnimateReadOnly = false;
            this.txtAppend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAppend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAppend.Depth = 0;
            this.txtAppend.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAppend.HideSelection = true;
            this.txtAppend.Hint = "JUSTIFIKASI";
            this.txtAppend.LeadingIcon = null;
            this.txtAppend.Location = new System.Drawing.Point(851, 27);
            this.txtAppend.MaxLength = 32767;
            this.txtAppend.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.PasswordChar = '\0';
            this.txtAppend.PrefixSuffixText = null;
            this.txtAppend.ReadOnly = false;
            this.txtAppend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAppend.SelectedText = "";
            this.txtAppend.SelectionLength = 0;
            this.txtAppend.SelectionStart = 0;
            this.txtAppend.ShortcutsEnabled = true;
            this.txtAppend.Size = new System.Drawing.Size(218, 48);
            this.txtAppend.TabIndex = 36;
            this.txtAppend.TabStop = false;
            this.txtAppend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAppend.TrailingIcon = null;
            this.txtAppend.UseSystemPasswordChar = false;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(750, 35);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(68, 36);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(534, 61);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 34;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(534, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 33;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(534, 15);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(211, 19);
            this.materialLabel10.TabIndex = 32;
            this.materialLabel10.Text = "FILTER TGL_INPUT FROM TO";
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Depth = 0;
            this.lblRowCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRowCount.Location = new System.Drawing.Point(1437, 93);
            this.lblRowCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(92, 19);
            this.lblRowCount.TabIndex = 26;
            this.lblRowCount.Text = "ROW COUNT";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.AutoResize = false;
            this.cbxSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxSearchBy.Depth = 0;
            this.cbxSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxSearchBy.DropDownHeight = 174;
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.DropDownWidth = 121;
            this.cbxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.IntegralHeight = false;
            this.cbxSearchBy.ItemHeight = 43;
            this.cbxSearchBy.Location = new System.Drawing.Point(376, 26);
            this.cbxSearchBy.MaxDropDownItems = 4;
            this.cbxSearchBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(136, 49);
            this.cbxSearchBy.StartIndex = 0;
            this.cbxSearchBy.TabIndex = 25;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(281, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "SEARCH BY:";
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.HideSelection = true;
            this.txtSearch.Hint = "SEARCH REGISTER";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(15, 27);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(260, 48);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 115);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1532, 531);
            this.dgv.TabIndex = 8;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 646);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.TopPanel);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel lblRowCount;
        private MaterialSkin.Controls.MaterialComboBox cbxSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialButton btnAppend;
        private MaterialSkin.Controls.MaterialTextBox2 txtAppend;
        private MaterialSkin.Controls.MaterialCheckbox chkAll;
        private CustomMaterialButton btnDispose;
        private System.Windows.Forms.Label lblPortStatus;
    }
}