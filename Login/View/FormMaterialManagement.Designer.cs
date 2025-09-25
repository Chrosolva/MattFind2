namespace Login.View
{
    partial class FormMaterialManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterialManagement));
            this.main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.middlepanel = new System.Windows.Forms.Panel();
            this.dgvMaterialManagement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.downpanel = new System.Windows.Forms.Panel();
            this.dgvMMDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dtpSampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpMulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnChangeStatus = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.cbxJenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxJenisManagement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.btnSlocBinDetail = new FontAwesome.Sharp.IconButton();
            this.main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.middlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialManagement)).BeginInit();
            this.downpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMDetail)).BeginInit();
            this.UpPanel.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.AutoScroll = true;
            this.main.Controls.Add(this.panel2);
            this.main.Controls.Add(this.UpPanel);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1222, 641);
            this.main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.middlepanel);
            this.panel2.Controls.Add(this.downpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1222, 505);
            this.panel2.TabIndex = 7;
            // 
            // middlepanel
            // 
            this.middlepanel.Controls.Add(this.dgvMaterialManagement);
            this.middlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlepanel.Location = new System.Drawing.Point(10, 10);
            this.middlepanel.Name = "middlepanel";
            this.middlepanel.Size = new System.Drawing.Size(1202, 207);
            this.middlepanel.TabIndex = 1;
            // 
            // dgvMaterialManagement
            // 
            this.dgvMaterialManagement.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterialManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterialManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterialManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaterialManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(7)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterialManagement.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialManagement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaterialManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialManagement.EnableHeadersVisualStyles = false;
            this.dgvMaterialManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMaterialManagement.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterialManagement.Name = "dgvMaterialManagement";
            this.dgvMaterialManagement.ReadOnly = true;
            this.dgvMaterialManagement.RowHeadersVisible = false;
            this.dgvMaterialManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialManagement.Size = new System.Drawing.Size(1202, 207);
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
            // downpanel
            // 
            this.downpanel.Controls.Add(this.dgvMMDetail);
            this.downpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downpanel.Location = new System.Drawing.Point(10, 217);
            this.downpanel.Name = "downpanel";
            this.downpanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.downpanel.Size = new System.Drawing.Size(1202, 278);
            this.downpanel.TabIndex = 0;
            // 
            // dgvMMDetail
            // 
            this.dgvMMDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMMDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMMDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMMDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvMMDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMMDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMMDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(7)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMMDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMMDetail.ColumnHeadersHeight = 25;
            this.dgvMMDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMMDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMMDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMMDetail.EnableHeadersVisualStyles = false;
            this.dgvMMDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMMDetail.Location = new System.Drawing.Point(0, 10);
            this.dgvMMDetail.Name = "dgvMMDetail";
            this.dgvMMDetail.RowHeadersVisible = false;
            this.dgvMMDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMMDetail.Size = new System.Drawing.Size(1202, 258);
            this.dgvMMDetail.TabIndex = 3;
            this.dgvMMDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMMDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMMDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMMDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMMDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMMDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMMDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMMDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMMDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMMDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMMDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMMDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMMDetail.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvMMDetail.ThemeStyle.ReadOnly = false;
            this.dgvMMDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMMDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMMDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMMDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMMDetail.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMMDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMMDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMMDetail.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMMDetail_DefaultValuesNeeded);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
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
            this.UpPanel.Size = new System.Drawing.Size(1222, 136);
            this.UpPanel.TabIndex = 6;
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
            this.panelFilter.Location = new System.Drawing.Point(0, 85);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(4);
            this.panelFilter.Size = new System.Drawing.Size(1220, 49);
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
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.buttonPanel.Controls.Add(this.btnChangeStatus);
            this.buttonPanel.Controls.Add(this.panel1);
            this.buttonPanel.Controls.Add(this.btnFilter);
            this.buttonPanel.Controls.Add(this.btnExport);
            this.buttonPanel.Controls.Add(this.btnCancel);
            this.buttonPanel.Controls.Add(this.btnPrint);
            this.buttonPanel.Controls.Add(this.btnSlocBinDetail);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1220, 85);
            this.buttonPanel.TabIndex = 0;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.AccessibleDescription = "OrDlt";
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnChangeStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnChangeStatus.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnChangeStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnChangeStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeStatus.IconSize = 30;
            this.btnChangeStatus.Location = new System.Drawing.Point(996, 0);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(63, 85);
            this.btnChangeStatus.TabIndex = 13;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbxJenis);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.cbxJenisManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(252, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 85);
            this.panel1.TabIndex = 12;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(610, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(47, 15);
            this.guna2HtmlLabel3.TabIndex = 18;
            this.guna2HtmlLabel3.Text = "Status";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(431, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(79, 15);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "KeyWords";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(119, 19);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Management Type";
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxStatus.ItemHeight = 30;
            this.cbxStatus.Items.AddRange(new object[] {
            "ALL",
            "OnProcess",
            "Done"});
            this.cbxStatus.Location = new System.Drawing.Point(610, 24);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(122, 36);
            this.cbxStatus.TabIndex = 15;
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
            this.btnSearch.Location = new System.Drawing.Point(357, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 55);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            "Nama_PenanggungJawab",
            "Management_ID"});
            this.cbxJenis.Location = new System.Drawing.Point(431, 24);
            this.cbxJenis.Name = "cbxJenis";
            this.cbxJenis.Size = new System.Drawing.Size(175, 36);
            this.cbxJenis.TabIndex = 14;
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
            this.txtFind.Location = new System.Drawing.Point(171, 25);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(184, 36);
            this.txtFind.TabIndex = 12;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // cbxJenisManagement
            // 
            this.cbxJenisManagement.BackColor = System.Drawing.Color.Transparent;
            this.cbxJenisManagement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxJenisManagement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJenisManagement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxJenisManagement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxJenisManagement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxJenisManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxJenisManagement.ItemHeight = 30;
            this.cbxJenisManagement.Items.AddRange(new object[] {
            "ALL",
            "Entry",
            "Request"});
            this.cbxJenisManagement.Location = new System.Drawing.Point(6, 25);
            this.cbxJenisManagement.Name = "cbxJenisManagement";
            this.cbxJenisManagement.Size = new System.Drawing.Size(158, 36);
            this.cbxJenisManagement.TabIndex = 11;
            this.cbxJenisManagement.SelectedIndexChanged += new System.EventHandler(this.cbxJenisManagement_SelectedIndexChanged);
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
            this.btnFilter.Location = new System.Drawing.Point(189, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 85);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnExport
            // 
            this.btnExport.AccessibleDescription = "OrVw";
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 30;
            this.btnExport.Location = new System.Drawing.Point(126, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(63, 85);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "&Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "OrDlt";
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 30;
            this.btnCancel.Location = new System.Drawing.Point(1154, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 85);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleDescription = "OrAdd";
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 30;
            this.btnPrint.Location = new System.Drawing.Point(63, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 85);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSlocBinDetail
            // 
            this.btnSlocBinDetail.AccessibleDescription = "ADD";
            this.btnSlocBinDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btnSlocBinDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSlocBinDetail.FlatAppearance.BorderSize = 0;
            this.btnSlocBinDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlocBinDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlocBinDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSlocBinDetail.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnSlocBinDetail.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSlocBinDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSlocBinDetail.IconSize = 30;
            this.btnSlocBinDetail.Location = new System.Drawing.Point(0, 0);
            this.btnSlocBinDetail.Name = "btnSlocBinDetail";
            this.btnSlocBinDetail.Size = new System.Drawing.Size(63, 85);
            this.btnSlocBinDetail.TabIndex = 4;
            this.btnSlocBinDetail.Text = "&SlocBin Detail";
            this.btnSlocBinDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSlocBinDetail.UseVisualStyleBackColor = false;
            this.btnSlocBinDetail.Click += new System.EventHandler(this.btnSlocBinDetail_Click);
            // 
            // FormMaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1222, 641);
            this.Controls.Add(this.main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMaterialManagement";
            this.Text = "FormMaterialManagement";
            this.Load += new System.EventHandler(this.FormMaterialManagement_Load);
            this.main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.middlepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialManagement)).EndInit();
            this.downpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMDetail)).EndInit();
            this.UpPanel.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel middlepanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMaterialManagement;
        private System.Windows.Forms.Panel downpanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMMDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel panelFilter;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSampai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMulai;
        private System.Windows.Forms.Panel buttonPanel;
        public FontAwesome.Sharp.IconButton btnChangeStatus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatus;
        public FontAwesome.Sharp.IconButton btnSearch;
        public FontAwesome.Sharp.IconButton btnFilter;
        public FontAwesome.Sharp.IconButton btnExport;
        public FontAwesome.Sharp.IconButton btnCancel;
        public FontAwesome.Sharp.IconButton btnPrint;
        public FontAwesome.Sharp.IconButton btnSlocBinDetail;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2TextBox txtFind;
        public Guna.UI2.WinForms.Guna2ComboBox cbxJenisManagement;
        public Guna.UI2.WinForms.Guna2ComboBox cbxJenis;
    }
}