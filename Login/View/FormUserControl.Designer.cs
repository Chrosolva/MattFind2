namespace WBPOS.View
{
    partial class FormUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserControl));
            this.left = new System.Windows.Forms.Panel();
            this.xuiWidgetPanel2 = new XanderUI.XUIWidgetPanel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.xuiWidgetPanel1 = new XanderUI.XUIWidgetPanel();
            this.btnDelete = new XanderUI.XUIButton();
            this.btnEdit = new XanderUI.XUIButton();
            this.btnAdd = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CsttxtConfirm = new WBPOS.UC.CustomTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.CsttxtPassword = new WBPOS.UC.CustomTextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.csttxtUsername = new WBPOS.UC.CustomTextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.csttxtUserID = new WBPOS.UC.CustomTextBox();
            this.basepanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHakAkses = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateHakAkses = new XanderUI.XUIButton();
            this.left.SuspendLayout();
            this.xuiWidgetPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.xuiWidgetPanel1.SuspendLayout();
            this.basepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHakAkses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left.Controls.Add(this.xuiWidgetPanel2);
            this.left.Controls.Add(this.xuiWidgetPanel1);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(493, 520);
            this.left.TabIndex = 0;
            // 
            // xuiWidgetPanel2
            // 
            this.xuiWidgetPanel2.Controls.Add(this.dgvUser);
            this.xuiWidgetPanel2.ControlsAsWidgets = false;
            this.xuiWidgetPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiWidgetPanel2.Location = new System.Drawing.Point(0, 0);
            this.xuiWidgetPanel2.Name = "xuiWidgetPanel2";
            this.xuiWidgetPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.xuiWidgetPanel2.Size = new System.Drawing.Size(491, 311);
            this.xuiWidgetPanel2.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(5, 5);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(481, 301);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // xuiWidgetPanel1
            // 
            this.xuiWidgetPanel1.Controls.Add(this.btnDelete);
            this.xuiWidgetPanel1.Controls.Add(this.btnEdit);
            this.xuiWidgetPanel1.Controls.Add(this.btnAdd);
            this.xuiWidgetPanel1.Controls.Add(this.label1);
            this.xuiWidgetPanel1.Controls.Add(this.CsttxtConfirm);
            this.xuiWidgetPanel1.Controls.Add(this.lblPassword);
            this.xuiWidgetPanel1.Controls.Add(this.CsttxtPassword);
            this.xuiWidgetPanel1.Controls.Add(this.lblUserName);
            this.xuiWidgetPanel1.Controls.Add(this.csttxtUsername);
            this.xuiWidgetPanel1.Controls.Add(this.lblUserID);
            this.xuiWidgetPanel1.Controls.Add(this.csttxtUserID);
            this.xuiWidgetPanel1.ControlsAsWidgets = false;
            this.xuiWidgetPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiWidgetPanel1.Location = new System.Drawing.Point(0, 311);
            this.xuiWidgetPanel1.Name = "xuiWidgetPanel1";
            this.xuiWidgetPanel1.Size = new System.Drawing.Size(491, 207);
            this.xuiWidgetPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDelete.ButtonImage = null;
            this.btnDelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ClickBackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete.CornerRadius = 5;
            this.btnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDelete.Location = new System.Drawing.Point(402, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Tag = "UsDlt";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnEdit.ButtonImage = null;
            this.btnEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit.CornerRadius = 5;
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(92, 162);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 28);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Tag = "UsEdt";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnAdd.ButtonImage = null;
            this.btnAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAdd.ClickTextColor = System.Drawing.Color.White;
            this.btnAdd.CornerRadius = 5;
            this.btnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.HoverBackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdd.Location = new System.Drawing.Point(19, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Tag = "UsAdd";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirm Password";
            // 
            // CsttxtConfirm
            // 
            this.CsttxtConfirm.Location = new System.Drawing.Point(264, 94);
            this.CsttxtConfirm.Name = "CsttxtConfirm";
            this.CsttxtConfirm.Size = new System.Drawing.Size(195, 38);
            this.CsttxtConfirm.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(261, 15);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // CsttxtPassword
            // 
            this.CsttxtPassword.Location = new System.Drawing.Point(264, 31);
            this.CsttxtPassword.Name = "CsttxtPassword";
            this.CsttxtPassword.Size = new System.Drawing.Size(195, 38);
            this.CsttxtPassword.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(16, 78);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // csttxtUsername
            // 
            this.csttxtUsername.Location = new System.Drawing.Point(19, 94);
            this.csttxtUsername.Name = "csttxtUsername";
            this.csttxtUsername.Size = new System.Drawing.Size(197, 38);
            this.csttxtUsername.TabIndex = 2;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(16, 15);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID";
            // 
            // csttxtUserID
            // 
            this.csttxtUserID.Location = new System.Drawing.Point(19, 31);
            this.csttxtUserID.Name = "csttxtUserID";
            this.csttxtUserID.Size = new System.Drawing.Size(197, 38);
            this.csttxtUserID.TabIndex = 0;
            // 
            // basepanel
            // 
            this.basepanel.Controls.Add(this.panel2);
            this.basepanel.Controls.Add(this.panel1);
            this.basepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basepanel.Location = new System.Drawing.Point(493, 0);
            this.basepanel.Name = "basepanel";
            this.basepanel.Size = new System.Drawing.Size(264, 520);
            this.basepanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHakAkses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(264, 474);
            this.panel2.TabIndex = 1;
            // 
            // dgvHakAkses
            // 
            this.dgvHakAkses.AllowUserToAddRows = false;
            this.dgvHakAkses.AllowUserToDeleteRows = false;
            this.dgvHakAkses.AllowUserToOrderColumns = true;
            this.dgvHakAkses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHakAkses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHakAkses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvHakAkses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHakAkses.Location = new System.Drawing.Point(5, 5);
            this.dgvHakAkses.MultiSelect = false;
            this.dgvHakAkses.Name = "dgvHakAkses";
            this.dgvHakAkses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHakAkses.Size = new System.Drawing.Size(254, 464);
            this.dgvHakAkses.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 43;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateHakAkses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdateHakAkses
            // 
            this.btnUpdateHakAkses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnUpdateHakAkses.ButtonImage = null;
            this.btnUpdateHakAkses.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUpdateHakAkses.ButtonText = "Update HakAkses";
            this.btnUpdateHakAkses.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUpdateHakAkses.ClickTextColor = System.Drawing.Color.White;
            this.btnUpdateHakAkses.CornerRadius = 5;
            this.btnUpdateHakAkses.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateHakAkses.HoverBackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateHakAkses.HoverTextColor = System.Drawing.Color.White;
            this.btnUpdateHakAkses.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdateHakAkses.Location = new System.Drawing.Point(159, 6);
            this.btnUpdateHakAkses.Name = "btnUpdateHakAkses";
            this.btnUpdateHakAkses.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateHakAkses.TabIndex = 11;
            this.btnUpdateHakAkses.Tag = "UsEdt";
            this.btnUpdateHakAkses.TextColor = System.Drawing.Color.White;
            this.btnUpdateHakAkses.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateHakAkses.Click += new System.EventHandler(this.btnUpdateHakAkses_Click);
            // 
            // FormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 520);
            this.Controls.Add(this.basepanel);
            this.Controls.Add(this.left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserControl";
            this.Text = "FormUserControl";
            this.Load += new System.EventHandler(this.FormUserControl_Load);
            this.left.ResumeLayout(false);
            this.xuiWidgetPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.xuiWidgetPanel1.ResumeLayout(false);
            this.xuiWidgetPanel1.PerformLayout();
            this.basepanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHakAkses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel left;
        private XanderUI.XUIWidgetPanel xuiWidgetPanel2;
        private XanderUI.XUIWidgetPanel xuiWidgetPanel1;
        private System.Windows.Forms.Panel basepanel;
        private System.Windows.Forms.DataGridView dgvUser;
        private WBPOS.UC.CustomTextBox csttxtUserID;
        private System.Windows.Forms.Label label1;
        private WBPOS.UC.CustomTextBox CsttxtConfirm;
        private System.Windows.Forms.Label lblPassword;
        private WBPOS.UC.CustomTextBox CsttxtPassword;
        private System.Windows.Forms.Label lblUserName;
        private WBPOS.UC.CustomTextBox csttxtUsername;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHakAkses;
        private System.Windows.Forms.Panel panel1;
        private new System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private XanderUI.XUIButton btnAdd;
        private XanderUI.XUIButton btnDelete;
        private XanderUI.XUIButton btnEdit;
        private XanderUI.XUIButton btnUpdateHakAkses;
    }
}