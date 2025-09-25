namespace SEALCHK.View
{
    partial class FindMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindMT));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblRowCount = new MaterialSkin.Controls.MaterialLabel();
            this.cbxSearchBy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new SEALCHK.CustomMaterialButton();
            this.btnSelect = new MaterialSkin.Controls.MaterialButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lblRowCount);
            this.TopPanel.Controls.Add(this.cbxSearchBy);
            this.TopPanel.Controls.Add(this.materialLabel2);
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 64);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(962, 101);
            this.TopPanel.TabIndex = 2;
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
            this.cbxSearchBy.Location = new System.Drawing.Point(367, 26);
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
            this.materialLabel2.Location = new System.Drawing.Point(272, 41);
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
            this.txtSearch.Hint = "SEARCH MOBIL TANGKI";
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
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnCancel);
            this.bottomPanel.Controls.Add(this.btnSelect);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(3, 362);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(962, 58);
            this.bottomPanel.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(866, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelect.Depth = 0;
            this.btnSelect.HighEmphasis = true;
            this.btnSelect.Icon = null;
            this.btnSelect.Location = new System.Drawing.Point(748, 16);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelect.Size = new System.Drawing.Size(74, 36);
            this.btnSelect.TabIndex = 29;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelect.UseAccentColor = false;
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 165);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(962, 197);
            this.dgv.TabIndex = 4;
            // 
            // FindMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 423);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindMT";
            this.Text = "Find Mobil Tangki";
            this.Load += new System.EventHandler(this.FindMT_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private MaterialSkin.Controls.MaterialLabel lblRowCount;
        private MaterialSkin.Controls.MaterialComboBox cbxSearchBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialButton btnSelect;
        private CustomMaterialButton btnCancel;
    }
}