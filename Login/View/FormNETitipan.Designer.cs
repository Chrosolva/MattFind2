namespace Login.View
{
    partial class FormNETitipan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNETitipan));
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TSEmpty = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.cbxSloc = new System.Windows.Forms.ComboBox();
            this.txtSlocBin = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNote = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TSAvailable = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TSFull = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtNamaPenanggungJawab = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtReference = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dgvManagementDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NoUrut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sloc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dtpTgl = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtManagementID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchMR = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(1016, 156);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(41, 18);
            this.guna2HtmlLabel5.TabIndex = 70;
            this.guna2HtmlLabel5.Text = "Empty";
            // 
            // TSEmpty
            // 
            this.TSEmpty.BackColor = System.Drawing.Color.White;
            this.TSEmpty.Checked = true;
            this.TSEmpty.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSEmpty.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSEmpty.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSEmpty.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSEmpty.Location = new System.Drawing.Point(1016, 177);
            this.TSEmpty.Name = "TSEmpty";
            this.TSEmpty.Size = new System.Drawing.Size(45, 24);
            this.TSEmpty.TabIndex = 69;
            this.TSEmpty.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSEmpty.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSEmpty.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSEmpty.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSEmpty.CheckedChanged += new System.EventHandler(this.TSEmpty_CheckedChanged);
            // 
            // cbxSloc
            // 
            this.cbxSloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSloc.FormattingEnabled = true;
            this.cbxSloc.Items.AddRange(new object[] {
            "NONE"});
            this.cbxSloc.Location = new System.Drawing.Point(907, 108);
            this.cbxSloc.Name = "cbxSloc";
            this.cbxSloc.Size = new System.Drawing.Size(184, 21);
            this.cbxSloc.TabIndex = 68;
            // 
            // txtSlocBin
            // 
            this.txtSlocBin.BaseColor = System.Drawing.Color.White;
            this.txtSlocBin.BorderColor = System.Drawing.Color.Silver;
            this.txtSlocBin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlocBin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSlocBin.FocusedBorderColor = System.Drawing.Color.Firebrick;
            this.txtSlocBin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSlocBin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlocBin.Location = new System.Drawing.Point(907, 70);
            this.txtSlocBin.Name = "txtSlocBin";
            this.txtSlocBin.PasswordChar = '\0';
            this.txtSlocBin.Size = new System.Drawing.Size(184, 29);
            this.txtSlocBin.TabIndex = 67;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.BackColor = System.Drawing.Color.White;
            this.gunaLabel10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel10.Location = new System.Drawing.Point(860, 104);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(41, 45);
            this.gunaLabel10.TabIndex = 66;
            this.gunaLabel10.Text = "Sloc";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel2.Location = new System.Drawing.Point(837, 60);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 45);
            this.gunaLabel2.TabIndex = 65;
            this.gunaLabel2.Text = "SlocBin";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNote
            // 
            this.txtNote.BaseColor = System.Drawing.Color.White;
            this.txtNote.BorderColor = System.Drawing.Color.Silver;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNote.FocusedBorderColor = System.Drawing.Color.Firebrick;
            this.txtNote.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNote.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(186, 149);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.Size = new System.Drawing.Size(377, 29);
            this.txtNote.TabIndex = 64;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.BackColor = System.Drawing.Color.White;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gunaLabel9.Location = new System.Drawing.Point(12, 146);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(167, 31);
            this.gunaLabel9.TabIndex = 63;
            this.gunaLabel9.Text = "Note";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(931, 156);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(60, 18);
            this.guna2HtmlLabel4.TabIndex = 62;
            this.guna2HtmlLabel4.Text = "Available";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(855, 156);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(24, 18);
            this.guna2HtmlLabel3.TabIndex = 61;
            this.guna2HtmlLabel3.Text = "Full";
            // 
            // TSAvailable
            // 
            this.TSAvailable.BackColor = System.Drawing.Color.White;
            this.TSAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSAvailable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSAvailable.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSAvailable.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSAvailable.Location = new System.Drawing.Point(931, 177);
            this.TSAvailable.Name = "TSAvailable";
            this.TSAvailable.Size = new System.Drawing.Size(45, 24);
            this.TSAvailable.TabIndex = 60;
            this.TSAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSAvailable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSAvailable.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSAvailable.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSAvailable.CheckedChanged += new System.EventHandler(this.TSAvailable_CheckedChanged);
            // 
            // TSFull
            // 
            this.TSFull.BackColor = System.Drawing.Color.White;
            this.TSFull.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSFull.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSFull.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSFull.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSFull.Location = new System.Drawing.Point(855, 177);
            this.TSFull.Name = "TSFull";
            this.TSFull.Size = new System.Drawing.Size(45, 24);
            this.TSFull.TabIndex = 59;
            this.TSFull.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSFull.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSFull.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSFull.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSFull.CheckedChanged += new System.EventHandler(this.TSFull_CheckedChanged);
            // 
            // txtNamaPenanggungJawab
            // 
            this.txtNamaPenanggungJawab.BaseColor = System.Drawing.Color.White;
            this.txtNamaPenanggungJawab.BorderColor = System.Drawing.Color.Silver;
            this.txtNamaPenanggungJawab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaPenanggungJawab.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNamaPenanggungJawab.FocusedBorderColor = System.Drawing.Color.Firebrick;
            this.txtNamaPenanggungJawab.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNamaPenanggungJawab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPenanggungJawab.Location = new System.Drawing.Point(186, 105);
            this.txtNamaPenanggungJawab.Name = "txtNamaPenanggungJawab";
            this.txtNamaPenanggungJawab.PasswordChar = '\0';
            this.txtNamaPenanggungJawab.Size = new System.Drawing.Size(377, 29);
            this.txtNamaPenanggungJawab.TabIndex = 58;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.White;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gunaLabel8.Location = new System.Drawing.Point(12, 102);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(167, 31);
            this.gunaLabel8.TabIndex = 57;
            this.gunaLabel8.Text = "Person Responsible";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReference
            // 
            this.txtReference.BaseColor = System.Drawing.Color.White;
            this.txtReference.BorderColor = System.Drawing.Color.Silver;
            this.txtReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReference.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReference.FocusedBorderColor = System.Drawing.Color.Firebrick;
            this.txtReference.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReference.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(186, 64);
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.Size = new System.Drawing.Size(377, 29);
            this.txtReference.TabIndex = 52;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.White;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gunaLabel5.Location = new System.Drawing.Point(12, 61);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(167, 31);
            this.gunaLabel5.TabIndex = 51;
            this.gunaLabel5.Text = "Reference";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Select,
            this.MaterialDescription,
            this.Qty,
            this.BaseUnit,
            this.Note,
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
            this.dgvManagementDetail.Size = new System.Drawing.Size(1191, 272);
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
            this.NoUrut.FillWeight = 91.22318F;
            this.NoUrut.HeaderText = "No Urut";
            this.NoUrut.Name = "NoUrut";
            // 
            // MaterialNumber
            // 
            this.MaterialNumber.FillWeight = 122.9475F;
            this.MaterialNumber.HeaderText = "MaterialNumber";
            this.MaterialNumber.Name = "MaterialNumber";
            this.MaterialNumber.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.FillWeight = 36.10004F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // MaterialDescription
            // 
            this.MaterialDescription.FillWeight = 122.9475F;
            this.MaterialDescription.HeaderText = "Item Titipan";
            this.MaterialDescription.Name = "MaterialDescription";
            this.MaterialDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Qty
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qty.FillWeight = 122.9475F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // BaseUnit
            // 
            this.BaseUnit.FillWeight = 107.5025F;
            this.BaseUnit.HeaderText = "UOM";
            this.BaseUnit.Name = "BaseUnit";
            // 
            // Note
            // 
            this.Note.FillWeight = 107.5025F;
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // Sloc
            // 
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvManagementDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(1207, 288);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 55);
            this.panel2.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(1003, 10);
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
            this.btnAdd.Location = new System.Drawing.Point(863, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpTgl
            // 
            this.dtpTgl.Checked = true;
            this.dtpTgl.FillColor = System.Drawing.SystemColors.Window;
            this.dtpTgl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTgl.Location = new System.Drawing.Point(907, 19);
            this.dtpTgl.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTgl.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(184, 36);
            this.dtpTgl.TabIndex = 50;
            this.dtpTgl.Value = new System.DateTime(2022, 5, 28, 22, 18, 33, 0);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.White;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel4.Location = new System.Drawing.Point(853, 19);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(48, 45);
            this.gunaLabel4.TabIndex = 49;
            this.gunaLabel4.Text = "Date";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtManagementID.Location = new System.Drawing.Point(186, 19);
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
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(143, 45);
            this.gunaLabel1.TabIndex = 43;
            this.gunaLabel1.Text = "Titipan ID";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSearchMR);
            this.panel1.Controls.Add(this.guna2HtmlLabel5);
            this.panel1.Controls.Add(this.TSEmpty);
            this.panel1.Controls.Add(this.cbxSloc);
            this.panel1.Controls.Add(this.txtSlocBin);
            this.panel1.Controls.Add(this.gunaLabel10);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.gunaLabel9);
            this.panel1.Controls.Add(this.guna2HtmlLabel4);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.TSAvailable);
            this.panel1.Controls.Add(this.TSFull);
            this.panel1.Controls.Add(this.txtNamaPenanggungJawab);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.txtReference);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.dtpTgl);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.txtManagementID);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 221);
            this.panel1.TabIndex = 3;
            // 
            // btnSearchMR
            // 
            this.btnSearchMR.AccessibleDescription = "PdEdt";
            this.btnSearchMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearchMR.CausesValidation = false;
            this.btnSearchMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMR.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnSearchMR.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchMR.IconColor = System.Drawing.Color.PeachPuff;
            this.btnSearchMR.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearchMR.IconSize = 24;
            this.btnSearchMR.Location = new System.Drawing.Point(582, 54);
            this.btnSearchMR.Name = "btnSearchMR";
            this.btnSearchMR.Size = new System.Drawing.Size(120, 45);
            this.btnSearchMR.TabIndex = 71;
            this.btnSearchMR.Text = "From Material Request";
            this.btnSearchMR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchMR.UseVisualStyleBackColor = false;
            this.btnSearchMR.Click += new System.EventHandler(this.btnSearchMR_Click);
            // 
            // FormNETitipan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 564);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNETitipan";
            this.Text = "FormNETitipan";
            this.Load += new System.EventHandler(this.FormNETitipan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSEmpty;
        private System.Windows.Forms.ComboBox cbxSloc;
        private Guna.UI.WinForms.GunaTextBox txtSlocBin;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtNote;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSAvailable;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSFull;
        private Guna.UI.WinForms.GunaTextBox txtNamaPenanggungJawab;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtReference;
        public FontAwesome.Sharp.IconButton btnAdd;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvManagementDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton btnCancel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTgl;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtManagementID;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnSearchMR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoUrut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNumber;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sloc;
    }
}