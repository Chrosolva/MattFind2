namespace Login.View
{
    partial class FormNEMaterialAllocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNEMaterialAllocation));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvManagementDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NoUrut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialSearch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sloc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnSearchME = new FontAwesome.Sharp.IconButton();
            this.txtManagementID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvManagementDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(1239, 331);
            this.panel3.TabIndex = 8;
            // 
            // dgvManagementDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvManagementDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagementDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManagementDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvManagementDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManagementDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManagementDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(7)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagementDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagementDetail.ColumnHeadersHeight = 25;
            this.dgvManagementDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoUrut,
            this.MaterialNumber,
            this.MaterialSearch,
            this.MaterialDescription,
            this.Reference,
            this.Qty,
            this.Sloc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManagementDetail.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManagementDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManagementDetail.EnableHeadersVisualStyles = false;
            this.dgvManagementDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvManagementDetail.Location = new System.Drawing.Point(8, 8);
            this.dgvManagementDetail.Name = "dgvManagementDetail";
            this.dgvManagementDetail.RowHeadersVisible = false;
            this.dgvManagementDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagementDetail.Size = new System.Drawing.Size(1223, 315);
            this.dgvManagementDetail.TabIndex = 3;
            this.dgvManagementDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvManagementDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvManagementDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvManagementDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvManagementDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvManagementDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvManagementDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvManagementDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvManagementDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvManagementDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvManagementDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManagementDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvManagementDetail.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvManagementDetail.ThemeStyle.ReadOnly = false;
            this.dgvManagementDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvManagementDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManagementDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvManagementDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvManagementDetail.ThemeStyle.RowsStyle.Height = 22;
            this.dgvManagementDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvManagementDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvManagementDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManagementDetail_CellContentClick);
            this.dgvManagementDetail.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvManagementDetail_DefaultValuesNeeded);
            this.dgvManagementDetail.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvManagementDetail_EditingControlShowing);
            // 
            // NoUrut
            // 
            this.NoUrut.FillWeight = 68.06949F;
            this.NoUrut.HeaderText = "No Urut";
            this.NoUrut.Name = "NoUrut";
            // 
            // MaterialNumber
            // 
            this.MaterialNumber.FillWeight = 114.3671F;
            this.MaterialNumber.HeaderText = "MaterialNumber";
            this.MaterialNumber.Name = "MaterialNumber";
            this.MaterialNumber.ReadOnly = true;
            // 
            // MaterialSearch
            // 
            this.MaterialSearch.HeaderText = "Select";
            this.MaterialSearch.Name = "MaterialSearch";
            // 
            // MaterialDescription
            // 
            this.MaterialDescription.HeaderText = "MaterialDescription";
            this.MaterialDescription.Name = "MaterialDescription";
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            // 
            // Qty
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qty.FillWeight = 114.3671F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Sloc
            // 
            this.Sloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sloc.HeaderText = "Sloc";
            this.Sloc.Items.AddRange(new object[] {
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
            this.Sloc.Name = "Sloc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 55);
            this.panel2.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "PdEdt";
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCancel.IconColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancel.IconSize = 24;
            this.btnCancel.Location = new System.Drawing.Point(1019, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 33);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Batal";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "PdEdt";
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(879, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearchME
            // 
            this.btnSearchME.AccessibleDescription = "PdEdt";
            this.btnSearchME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearchME.CausesValidation = false;
            this.btnSearchME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchME.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnSearchME.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchME.IconColor = System.Drawing.Color.PeachPuff;
            this.btnSearchME.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearchME.IconSize = 24;
            this.btnSearchME.Location = new System.Drawing.Point(586, 34);
            this.btnSearchME.Name = "btnSearchME";
            this.btnSearchME.Size = new System.Drawing.Size(120, 45);
            this.btnSearchME.TabIndex = 71;
            this.btnSearchME.Text = "From Material Entry";
            this.btnSearchME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchME.UseVisualStyleBackColor = false;
            this.btnSearchME.Click += new System.EventHandler(this.btnSearchME_Click);
            // 
            // txtManagementID
            // 
            this.txtManagementID.BaseColor = System.Drawing.Color.White;
            this.txtManagementID.BorderColor = System.Drawing.Color.Silver;
            this.txtManagementID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManagementID.Enabled = false;
            this.txtManagementID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtManagementID.FocusedBorderColor = System.Drawing.Color.Firebrick;
            this.txtManagementID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtManagementID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagementID.Location = new System.Drawing.Point(186, 44);
            this.txtManagementID.Name = "txtManagementID";
            this.txtManagementID.PasswordChar = '\0';
            this.txtManagementID.Size = new System.Drawing.Size(377, 29);
            this.txtManagementID.TabIndex = 45;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(143, 45);
            this.gunaLabel1.TabIndex = 43;
            this.gunaLabel1.Text = "Management ID";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSearchME);
            this.panel1.Controls.Add(this.txtManagementID);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 95);
            this.panel1.TabIndex = 6;
            // 
            // FormNEMaterialAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNEMaterialAllocation";
            this.Text = "FormNEMaterialAllocation";
            this.Load += new System.EventHandler(this.FormNEMaterialAllocation_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvManagementDetail;
        private System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton btnCancel;
        public FontAwesome.Sharp.IconButton btnAdd;
        public FontAwesome.Sharp.IconButton btnSearchME;
        private Guna.UI.WinForms.GunaTextBox txtManagementID;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoUrut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNumber;
        private System.Windows.Forms.DataGridViewButtonColumn MaterialSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sloc;
    }
}