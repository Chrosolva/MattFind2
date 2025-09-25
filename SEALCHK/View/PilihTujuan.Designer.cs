namespace SEALCHK.View
{
    partial class PilihTujuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihTujuan));
            this.grpCompart = new System.Windows.Forms.GroupBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblRowCount = new MaterialSkin.Controls.MaterialLabel();
            this.cbxSearchBy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.cbxOwned = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxRegional = new MaterialSkin.Controls.MaterialComboBox();
            this.lblUserTYPE = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.cardTujuan = new MaterialSkin.Controls.MaterialCard();
            this.btnClearAll = new MaterialSkin.Controls.MaterialButton();
            this.btnClearSlot = new MaterialSkin.Controls.MaterialButton();
            this.btnAssignToActive = new MaterialSkin.Controls.MaterialButton();
            this.lblActiveSlot = new MaterialSkin.Controls.MaterialLabel();
            this.btnFinSet = new MaterialSkin.Controls.MaterialButton();
            this.dgvTujuan = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.cardTujuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTujuan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCompart
            // 
            this.grpCompart.Location = new System.Drawing.Point(7, 6);
            this.grpCompart.Name = "grpCompart";
            this.grpCompart.Size = new System.Drawing.Size(313, 349);
            this.grpCompart.TabIndex = 0;
            this.grpCompart.TabStop = false;
            this.grpCompart.Text = "COMPARTMENT";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lblRowCount);
            this.TopPanel.Controls.Add(this.cbxSearchBy);
            this.TopPanel.Controls.Add(this.materialLabel2);
            this.TopPanel.Controls.Add(this.btnFilter);
            this.TopPanel.Controls.Add(this.cbxOwned);
            this.TopPanel.Controls.Add(this.materialLabel1);
            this.TopPanel.Controls.Add(this.cbxRegional);
            this.TopPanel.Controls.Add(this.lblUserTYPE);
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(408, 64);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(852, 101);
            this.TopPanel.TabIndex = 1;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Depth = 0;
            this.lblRowCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRowCount.Location = new System.Drawing.Point(745, 78);
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
            this.cbxSearchBy.Location = new System.Drawing.Point(701, 26);
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
            this.materialLabel2.Location = new System.Drawing.Point(698, 6);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "SEARCH BY:";
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(557, 31);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(68, 36);
            this.btnFilter.TabIndex = 23;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
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
            this.cbxOwned.Location = new System.Drawing.Point(414, 26);
            this.cbxOwned.MaxDropDownItems = 4;
            this.cbxOwned.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxOwned.Name = "cbxOwned";
            this.cbxOwned.Size = new System.Drawing.Size(136, 49);
            this.cbxOwned.StartIndex = 0;
            this.cbxOwned.TabIndex = 22;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(411, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "KODE KEPEMILIKAN";
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
            this.cbxRegional.Location = new System.Drawing.Point(272, 26);
            this.cbxRegional.MaxDropDownItems = 4;
            this.cbxRegional.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxRegional.Name = "cbxRegional";
            this.cbxRegional.Size = new System.Drawing.Size(136, 49);
            this.cbxRegional.StartIndex = 0;
            this.cbxRegional.TabIndex = 20;
            // 
            // lblUserTYPE
            // 
            this.lblUserTYPE.AutoSize = true;
            this.lblUserTYPE.Depth = 0;
            this.lblUserTYPE.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserTYPE.Location = new System.Drawing.Point(269, 6);
            this.lblUserTYPE.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserTYPE.Name = "lblUserTYPE";
            this.lblUserTYPE.Size = new System.Drawing.Size(121, 19);
            this.lblUserTYPE.TabIndex = 19;
            this.lblUserTYPE.Text = "KODE REGIONAL";
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.HideSelection = true;
            this.txtSearch.Hint = "SEARCH TUJUAN";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(6, 27);
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
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cardTujuan);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(3, 64);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(405, 486);
            this.leftPanel.TabIndex = 2;
            // 
            // cardTujuan
            // 
            this.cardTujuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardTujuan.Controls.Add(this.btnClearAll);
            this.cardTujuan.Controls.Add(this.btnClearSlot);
            this.cardTujuan.Controls.Add(this.btnAssignToActive);
            this.cardTujuan.Controls.Add(this.lblActiveSlot);
            this.cardTujuan.Controls.Add(this.btnFinSet);
            this.cardTujuan.Controls.Add(this.grpCompart);
            this.cardTujuan.Depth = 0;
            this.cardTujuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTujuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardTujuan.Location = new System.Drawing.Point(0, 0);
            this.cardTujuan.Margin = new System.Windows.Forms.Padding(14);
            this.cardTujuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardTujuan.Name = "cardTujuan";
            this.cardTujuan.Padding = new System.Windows.Forms.Padding(14);
            this.cardTujuan.Size = new System.Drawing.Size(405, 486);
            this.cardTujuan.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearAll.Depth = 0;
            this.btnClearAll.HighEmphasis = true;
            this.btnClearAll.Icon = null;
            this.btnClearAll.Location = new System.Drawing.Point(134, 383);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearAll.Size = new System.Drawing.Size(96, 36);
            this.btnClearAll.TabIndex = 29;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearAll.UseAccentColor = false;
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnClearSlot
            // 
            this.btnClearSlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearSlot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearSlot.Depth = 0;
            this.btnClearSlot.HighEmphasis = true;
            this.btnClearSlot.Icon = null;
            this.btnClearSlot.Location = new System.Drawing.Point(20, 383);
            this.btnClearSlot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearSlot.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearSlot.Name = "btnClearSlot";
            this.btnClearSlot.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearSlot.Size = new System.Drawing.Size(106, 36);
            this.btnClearSlot.TabIndex = 28;
            this.btnClearSlot.Text = "CLEAR SLOT";
            this.btnClearSlot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearSlot.UseAccentColor = false;
            this.btnClearSlot.UseVisualStyleBackColor = true;
            // 
            // btnAssignToActive
            // 
            this.btnAssignToActive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssignToActive.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAssignToActive.Depth = 0;
            this.btnAssignToActive.HighEmphasis = true;
            this.btnAssignToActive.Icon = null;
            this.btnAssignToActive.Location = new System.Drawing.Point(327, 20);
            this.btnAssignToActive.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssignToActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssignToActive.Name = "btnAssignToActive";
            this.btnAssignToActive.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAssignToActive.Size = new System.Drawing.Size(73, 36);
            this.btnAssignToActive.TabIndex = 27;
            this.btnAssignToActive.Text = "ASSIGN";
            this.btnAssignToActive.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAssignToActive.UseAccentColor = false;
            this.btnAssignToActive.UseVisualStyleBackColor = true;
            // 
            // lblActiveSlot
            // 
            this.lblActiveSlot.AutoSize = true;
            this.lblActiveSlot.Depth = 0;
            this.lblActiveSlot.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblActiveSlot.Location = new System.Drawing.Point(17, 358);
            this.lblActiveSlot.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblActiveSlot.Name = "lblActiveSlot";
            this.lblActiveSlot.Size = new System.Drawing.Size(98, 19);
            this.lblActiveSlot.TabIndex = 26;
            this.lblActiveSlot.Text = "ACTIVE SLOT";
            // 
            // btnFinSet
            // 
            this.btnFinSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinSet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinSet.Depth = 0;
            this.btnFinSet.HighEmphasis = true;
            this.btnFinSet.Icon = null;
            this.btnFinSet.Location = new System.Drawing.Point(267, 444);
            this.btnFinSet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinSet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinSet.Name = "btnFinSet";
            this.btnFinSet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinSet.Size = new System.Drawing.Size(131, 36);
            this.btnFinSet.TabIndex = 26;
            this.btnFinSet.Text = "FINISH SETTING";
            this.btnFinSet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinSet.UseAccentColor = true;
            this.btnFinSet.UseVisualStyleBackColor = true;
            // 
            // dgvTujuan
            // 
            this.dgvTujuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTujuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTujuan.Location = new System.Drawing.Point(408, 165);
            this.dgvTujuan.Name = "dgvTujuan";
            this.dgvTujuan.Size = new System.Drawing.Size(852, 385);
            this.dgvTujuan.TabIndex = 3;
            // 
            // PilihTujuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 553);
            this.Controls.Add(this.dgvTujuan);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.leftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PilihTujuan";
            this.Text = "SELECT TUJUAN";
            this.Load += new System.EventHandler(this.PilihTujuan_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.cardTujuan.ResumeLayout(false);
            this.cardTujuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTujuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompart;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel leftPanel;
        private MaterialSkin.Controls.MaterialCard cardTujuan;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private MaterialSkin.Controls.MaterialComboBox cbxOwned;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbxRegional;
        private MaterialSkin.Controls.MaterialLabel lblUserTYPE;
        private MaterialSkin.Controls.MaterialComboBox cbxSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private System.Windows.Forms.DataGridView dgvTujuan;
        private MaterialSkin.Controls.MaterialButton btnFinSet;
        private MaterialSkin.Controls.MaterialLabel lblActiveSlot;
        private MaterialSkin.Controls.MaterialLabel lblRowCount;
        private MaterialSkin.Controls.MaterialButton btnClearAll;
        private MaterialSkin.Controls.MaterialButton btnClearSlot;
        private MaterialSkin.Controls.MaterialButton btnAssignToActive;
    }
}