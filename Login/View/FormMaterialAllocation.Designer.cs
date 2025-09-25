namespace Login.View
{
    partial class FormMaterialAllocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterialAllocation));
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnQRCode = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dtpSampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpMulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxJenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.downpanel = new System.Windows.Forms.Panel();
            this.dgvMMAllocation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMaterialManagement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.middlepanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.panelFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.downpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialManagement)).BeginInit();
            this.middlepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.AccessibleDescription = "OrVw";
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFilter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 30;
            this.btnFilter.Location = new System.Drawing.Point(211, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(57, 66);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.AccessibleDescription = "OrVw";
            this.btnQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnQRCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQRCode.FlatAppearance.BorderSize = 0;
            this.btnQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnQRCode.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btnQRCode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnQRCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQRCode.IconSize = 30;
            this.btnQRCode.Location = new System.Drawing.Point(138, 0);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(73, 66);
            this.btnQRCode.TabIndex = 9;
            this.btnQRCode.Text = "&QRCode";
            this.btnQRCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQRCode.UseVisualStyleBackColor = false;
            this.btnQRCode.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "OrDlt";
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.Location = new System.Drawing.Point(1206, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 66);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = "OrVw";
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(198, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 55);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(6, 21);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(184, 36);
            this.txtFind.TabIndex = 12;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.panelFilter.Controls.Add(this.dtpStartTime);
            this.panelFilter.Controls.Add(this.dtpEndTime);
            this.panelFilter.Controls.Add(this.gunaLabel1);
            this.panelFilter.Controls.Add(this.gunaLabel4);
            this.panelFilter.Controls.Add(this.dtpSampai);
            this.panelFilter.Controls.Add(this.dtpMulai);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 66);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(4);
            this.panelFilter.Size = new System.Drawing.Size(1263, 49);
            this.panelFilter.TabIndex = 1;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpStartTime.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dtpStartTime.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(1133, 2);
            this.dtpStartTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(84, 20);
            this.dtpStartTime.TabIndex = 55;
            this.dtpStartTime.Value = new System.DateTime(2021, 2, 20, 0, 0, 0, 0);
            this.dtpStartTime.Visible = false;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpEndTime.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dtpEndTime.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(1133, 25);
            this.dtpEndTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(84, 20);
            this.dtpEndTime.TabIndex = 56;
            this.dtpEndTime.Value = new System.DateTime(2021, 2, 20, 23, 59, 0, 0);
            this.dtpEndTime.Visible = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.Location = new System.Drawing.Point(257, 2);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(24, 45);
            this.gunaLabel1.TabIndex = 54;
            this.gunaLabel1.Text = "to";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel4.Location = new System.Drawing.Point(9, 2);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(48, 45);
            this.gunaLabel4.TabIndex = 53;
            this.gunaLabel4.Text = "From";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpSampai
            // 
            this.dtpSampai.Checked = true;
            this.dtpSampai.FillColor = System.Drawing.SystemColors.Window;
            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSampai.Location = new System.Drawing.Point(284, 6);
            this.dtpSampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.Size = new System.Drawing.Size(189, 36);
            this.dtpSampai.TabIndex = 52;
            this.dtpSampai.Value = new System.DateTime(2022, 5, 28, 22, 18, 33, 0);
            // 
            // dtpMulai
            // 
            this.dtpMulai.Checked = true;
            this.dtpMulai.FillColor = System.Drawing.SystemColors.Window;
            this.dtpMulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMulai.Location = new System.Drawing.Point(57, 6);
            this.dtpMulai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMulai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMulai.Name = "dtpMulai";
            this.dtpMulai.Size = new System.Drawing.Size(200, 36);
            this.dtpMulai.TabIndex = 51;
            this.dtpMulai.Value = new System.DateTime(2022, 5, 28, 22, 18, 33, 0);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(261, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(74, 18);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "KeyWords";
            // 
            // cbxJenis
            // 
            this.cbxJenis.BackColor = System.Drawing.Color.Transparent;
            this.cbxJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJenis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxJenis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxJenis.ItemHeight = 30;
            this.cbxJenis.Items.AddRange(new object[] {
            "Reservation_Code",
            "PO_RO",
            "WorkOrder",
            "Nama_PenanggungJawab"});
            this.cbxJenis.Location = new System.Drawing.Point(261, 21);
            this.cbxJenis.Name = "cbxJenis";
            this.cbxJenis.Size = new System.Drawing.Size(175, 36);
            this.cbxJenis.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbxJenis);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(268, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 66);
            this.panel1.TabIndex = 12;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.buttonPanel.Controls.Add(this.panel1);
            this.buttonPanel.Controls.Add(this.btnFilter);
            this.buttonPanel.Controls.Add(this.btnQRCode);
            this.buttonPanel.Controls.Add(this.btnDelete);
            this.buttonPanel.Controls.Add(this.btnReport);
            this.buttonPanel.Controls.Add(this.btnEdit);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1263, 66);
            this.buttonPanel.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.AccessibleDescription = "OrAdd";
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 30;
            this.btnReport.Location = new System.Drawing.Point(81, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(57, 66);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "&Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = "EDIT";
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 66);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "&Edit Allocation";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.UpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpPanel.Controls.Add(this.panelFilter);
            this.UpPanel.Controls.Add(this.buttonPanel);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1265, 117);
            this.UpPanel.TabIndex = 6;
            // 
            // downpanel
            // 
            this.downpanel.Controls.Add(this.dgvMMAllocation);
            this.downpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downpanel.Location = new System.Drawing.Point(10, 180);
            this.downpanel.Name = "downpanel";
            this.downpanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.downpanel.Size = new System.Drawing.Size(1245, 278);
            this.downpanel.TabIndex = 0;
            // 
            // dgvMMAllocation
            // 
            this.dgvMMAllocation.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMMAllocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMMAllocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMMAllocation.BackgroundColor = System.Drawing.Color.White;
            this.dgvMMAllocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMMAllocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMMAllocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(7)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMMAllocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMMAllocation.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMMAllocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMMAllocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMMAllocation.EnableHeadersVisualStyles = false;
            this.dgvMMAllocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMMAllocation.Location = new System.Drawing.Point(0, 10);
            this.dgvMMAllocation.Name = "dgvMMAllocation";
            this.dgvMMAllocation.RowHeadersVisible = false;
            this.dgvMMAllocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMMAllocation.Size = new System.Drawing.Size(1245, 258);
            this.dgvMMAllocation.TabIndex = 3;
            this.dgvMMAllocation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMMAllocation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMMAllocation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMMAllocation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMMAllocation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMMAllocation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMMAllocation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMMAllocation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMMAllocation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMMAllocation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMMAllocation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMMAllocation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMMAllocation.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvMMAllocation.ThemeStyle.ReadOnly = false;
            this.dgvMMAllocation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMMAllocation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMMAllocation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMMAllocation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMMAllocation.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMMAllocation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMMAllocation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvMaterialManagement
            // 
            this.dgvMaterialManagement.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaterialManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterialManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaterialManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(7)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMaterialManagement.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialManagement.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMaterialManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialManagement.EnableHeadersVisualStyles = false;
            this.dgvMaterialManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMaterialManagement.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterialManagement.Name = "dgvMaterialManagement";
            this.dgvMaterialManagement.ReadOnly = true;
            this.dgvMaterialManagement.RowHeadersVisible = false;
            this.dgvMaterialManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialManagement.Size = new System.Drawing.Size(1245, 170);
            this.dgvMaterialManagement.TabIndex = 2;
            this.dgvMaterialManagement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMaterialManagement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMaterialManagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMaterialManagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMaterialManagement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMaterialManagement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMaterialManagement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaterialManagement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMaterialManagement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMaterialManagement.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvMaterialManagement.ThemeStyle.ReadOnly = true;
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMaterialManagement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMaterialManagement.SelectionChanged += new System.EventHandler(this.dgvMaterialManagement_SelectionChanged);
            // 
            // middlepanel
            // 
            this.middlepanel.Controls.Add(this.dgvMaterialManagement);
            this.middlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlepanel.Location = new System.Drawing.Point(10, 10);
            this.middlepanel.Name = "middlepanel";
            this.middlepanel.Size = new System.Drawing.Size(1245, 170);
            this.middlepanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.middlepanel);
            this.panel2.Controls.Add(this.downpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1265, 468);
            this.panel2.TabIndex = 7;
            // 
            // main
            // 
            this.main.AutoScroll = true;
            this.main.Controls.Add(this.panel2);
            this.main.Controls.Add(this.UpPanel);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1265, 585);
            this.main.TabIndex = 1;
            // 
            // FormMaterialAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 585);
            this.Controls.Add(this.main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMaterialAllocation";
            this.Text = "FormMaterialAllocation";
            this.Load += new System.EventHandler(this.FormMaterialAllocation_Load);
            this.panelFilter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.downpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialManagement)).EndInit();
            this.middlepanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btnFilter;
        public FontAwesome.Sharp.IconButton btnQRCode;
        public FontAwesome.Sharp.IconButton btnDelete;
        public FontAwesome.Sharp.IconButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSampai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMulai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxJenis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel buttonPanel;
        public FontAwesome.Sharp.IconButton btnReport;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel downpanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMMAllocation;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMaterialManagement;
        private System.Windows.Forms.Panel middlepanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel main;
        public FontAwesome.Sharp.IconButton btnEdit;
    }
}