namespace Login.View
{
    partial class FormNESlocSlocBin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNESlocSlocBin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNESlocBin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SlocBinID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sloc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Still_Available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsEmpty = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNESlocBin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNESlocBin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(730, 379);
            this.panel3.TabIndex = 2;
            // 
            // dgvNESlocBin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNESlocBin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNESlocBin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNESlocBin.BackgroundColor = System.Drawing.Color.White;
            this.dgvNESlocBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNESlocBin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNESlocBin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(7)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNESlocBin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNESlocBin.ColumnHeadersHeight = 25;
            this.dgvNESlocBin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlocBinID,
            this.Sloc,
            this.IsFull,
            this.Still_Available,
            this.IsEmpty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNESlocBin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNESlocBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNESlocBin.EnableHeadersVisualStyles = false;
            this.dgvNESlocBin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNESlocBin.Location = new System.Drawing.Point(8, 8);
            this.dgvNESlocBin.Name = "dgvNESlocBin";
            this.dgvNESlocBin.RowHeadersVisible = false;
            this.dgvNESlocBin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNESlocBin.Size = new System.Drawing.Size(714, 363);
            this.dgvNESlocBin.TabIndex = 1;
            this.dgvNESlocBin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNESlocBin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNESlocBin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNESlocBin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNESlocBin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNESlocBin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNESlocBin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNESlocBin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNESlocBin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNESlocBin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNESlocBin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNESlocBin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNESlocBin.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvNESlocBin.ThemeStyle.ReadOnly = false;
            this.dgvNESlocBin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNESlocBin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNESlocBin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNESlocBin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNESlocBin.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNESlocBin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNESlocBin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNESlocBin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNESlocBin_CellContentClick);
            this.dgvNESlocBin.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvNESlocBin_ColumnAdded);
            this.dgvNESlocBin.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvNESlocBin_DefaultValuesNeeded);
            this.dgvNESlocBin.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvNESlocBin_RowsAdded);
            // 
            // SlocBinID
            // 
            this.SlocBinID.HeaderText = "SlocBinID";
            this.SlocBinID.Name = "SlocBinID";
            // 
            // Sloc
            // 
            this.Sloc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sloc.HeaderText = "Sloc";
            this.Sloc.Items.AddRange(new object[] {
            "NONE",
            "0000",
            "INTR",
            "K5BP",
            "K5CM",
            "K5GM",
            "K5IN",
            "K5IS",
            "K5OH",
            "K5RC",
            "K5SP",
            "K5SU",
            "K5TA",
            "MGRT",
            "NG00",
            "NHRT"});
            this.Sloc.MaxDropDownItems = 15;
            this.Sloc.Name = "Sloc";
            // 
            // IsFull
            // 
            this.IsFull.FalseValue = "false";
            this.IsFull.HeaderText = "Is Full";
            this.IsFull.IndeterminateValue = "false";
            this.IsFull.Name = "IsFull";
            this.IsFull.TrueValue = "true";
            // 
            // Still_Available
            // 
            this.Still_Available.FalseValue = "false";
            this.Still_Available.HeaderText = "Still Availale";
            this.Still_Available.IndeterminateValue = "false";
            this.Still_Available.Name = "Still_Available";
            this.Still_Available.TrueValue = "true";
            // 
            // IsEmpty
            // 
            this.IsEmpty.FalseValue = "false";
            this.IsEmpty.HeaderText = "Is Empty";
            this.IsEmpty.IndeterminateValue = "true";
            this.IsEmpty.Name = "IsEmpty";
            this.IsEmpty.TrueValue = "true";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "PdEdt";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCancel.IconColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancel.IconSize = 24;
            this.btnCancel.Location = new System.Drawing.Point(652, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 33);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Batal";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "PdEdt";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(530, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormNESlocSlocBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNESlocSlocBin";
            this.Text = "FormNESlocSlocBin";
            this.Load += new System.EventHandler(this.FormNESlocSlocBin_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNESlocBin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNESlocBin;
        public FontAwesome.Sharp.IconButton btnCancel;
        public FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlocBinID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sloc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Still_Available;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEmpty;
    }
}