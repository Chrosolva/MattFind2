namespace Login.View
{
    partial class FormBackUpDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackUpDB));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDataBaseItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearchMR = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataBase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Location = new System.Drawing.Point(92, 54);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(180, 36);
            this.txtPath.TabIndex = 3;
            // 
            // cmbDataBaseItems
            // 
            this.cmbDataBaseItems.BackColor = System.Drawing.Color.Transparent;
            this.cmbDataBaseItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDataBaseItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBaseItems.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDataBaseItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDataBaseItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDataBaseItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDataBaseItems.ItemHeight = 30;
            this.cmbDataBaseItems.Items.AddRange(new object[] {
            "WareHouseMS"});
            this.cmbDataBaseItems.Location = new System.Drawing.Point(92, 11);
            this.cmbDataBaseItems.Name = "cmbDataBaseItems";
            this.cmbDataBaseItems.Size = new System.Drawing.Size(181, 36);
            this.cmbDataBaseItems.TabIndex = 12;
            // 
            // btnSearchMR
            // 
            this.btnSearchMR.AccessibleDescription = "PdEdt";
            this.btnSearchMR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearchMR.CausesValidation = false;
            this.btnSearchMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMR.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnSearchMR.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchMR.IconColor = System.Drawing.Color.PeachPuff;
            this.btnSearchMR.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearchMR.IconSize = 24;
            this.btnSearchMR.Location = new System.Drawing.Point(301, 45);
            this.btnSearchMR.Name = "btnSearchMR";
            this.btnSearchMR.Size = new System.Drawing.Size(85, 45);
            this.btnSearchMR.TabIndex = 72;
            this.btnSearchMR.Text = "Browse";
            this.btnSearchMR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchMR.UseVisualStyleBackColor = false;
            this.btnSearchMR.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AccessibleDescription = "PdEdt";
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.iconButton1.CausesValidation = false;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.PeachPuff;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton1.IconColor = System.Drawing.Color.PeachPuff;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(92, 104);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(76, 45);
            this.iconButton1.TabIndex = 73;
            this.iconButton1.Text = "Back Up";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.txtBackup_Click);
            // 
            // FormBackUpDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 159);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnSearchMR);
            this.Controls.Add(this.cmbDataBaseItems);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBackUpDB";
            this.Text = "FormBackUpDB";
            this.Load += new System.EventHandler(this.FormBackUpDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDataBaseItems;
        public FontAwesome.Sharp.IconButton btnSearchMR;
        public FontAwesome.Sharp.IconButton iconButton1;
    }
}