namespace SEALCHK.View
{
    partial class AdminMenuForm
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
            this.btnDelete = new SEALCHK.CustomMaterialButton();
            this.CardCRUD = new MaterialSkin.Controls.MaterialCard();
            this.cbxUserType = new MaterialSkin.Controls.MaterialComboBox();
            this.lblUserTYPE = new MaterialSkin.Controls.MaterialLabel();
            this.lblConfirm = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirm = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.txtUserName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblUserID = new MaterialSkin.Controls.MaterialLabel();
            this.txtUserID = new MaterialSkin.Controls.MaterialTextBox2();
            this.TPAddEditUser = new System.Windows.Forms.TabPage();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.TCAdminMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.TPUserList = new System.Windows.Forms.TabPage();
            this.RightCard = new MaterialSkin.Controls.MaterialCard();
            this.dgvAccessRight = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LeftCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.CardCRUD.SuspendLayout();
            this.TPAddEditUser.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.TCAdminMenu.SuspendLayout();
            this.TPUserList.SuspendLayout();
            this.RightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessRight)).BeginInit();
            this.LeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(177, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CardCRUD
            // 
            this.CardCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardCRUD.Controls.Add(this.cbxUserType);
            this.CardCRUD.Controls.Add(this.lblUserTYPE);
            this.CardCRUD.Controls.Add(this.lblConfirm);
            this.CardCRUD.Controls.Add(this.txtConfirm);
            this.CardCRUD.Controls.Add(this.lblPassword);
            this.CardCRUD.Controls.Add(this.txtPassword);
            this.CardCRUD.Controls.Add(this.btnBack);
            this.CardCRUD.Controls.Add(this.btnClear);
            this.CardCRUD.Controls.Add(this.btnSave);
            this.CardCRUD.Controls.Add(this.lblUserName);
            this.CardCRUD.Controls.Add(this.txtUserName);
            this.CardCRUD.Controls.Add(this.lblUserID);
            this.CardCRUD.Controls.Add(this.txtUserID);
            this.CardCRUD.Depth = 0;
            this.CardCRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardCRUD.Location = new System.Drawing.Point(0, 0);
            this.CardCRUD.Margin = new System.Windows.Forms.Padding(14);
            this.CardCRUD.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardCRUD.Name = "CardCRUD";
            this.CardCRUD.Padding = new System.Windows.Forms.Padding(14);
            this.CardCRUD.Size = new System.Drawing.Size(1207, 411);
            this.CardCRUD.TabIndex = 0;
            // 
            // cbxUserType
            // 
            this.cbxUserType.AutoResize = false;
            this.cbxUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxUserType.Depth = 0;
            this.cbxUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxUserType.DropDownHeight = 174;
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.DropDownWidth = 121;
            this.cbxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.IntegralHeight = false;
            this.cbxUserType.ItemHeight = 43;
            this.cbxUserType.Items.AddRange(new object[] {
            "OPERATOR",
            "ADMIN",
            "SUPERADMIN"});
            this.cbxUserType.Location = new System.Drawing.Point(17, 236);
            this.cbxUserType.MaxDropDownItems = 4;
            this.cbxUserType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(250, 49);
            this.cbxUserType.StartIndex = 0;
            this.cbxUserType.TabIndex = 18;
            // 
            // lblUserTYPE
            // 
            this.lblUserTYPE.AutoSize = true;
            this.lblUserTYPE.Depth = 0;
            this.lblUserTYPE.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserTYPE.Location = new System.Drawing.Point(17, 214);
            this.lblUserTYPE.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserTYPE.Name = "lblUserTYPE";
            this.lblUserTYPE.Size = new System.Drawing.Size(83, 19);
            this.lblUserTYPE.TabIndex = 17;
            this.lblUserTYPE.Text = "USER TYPE";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Depth = 0;
            this.lblConfirm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConfirm.Location = new System.Drawing.Point(292, 114);
            this.lblConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(160, 19);
            this.lblConfirm.TabIndex = 16;
            this.lblConfirm.Text = "CONFIRM PASSWORD";
            // 
            // txtConfirm
            // 
            this.txtConfirm.AnimateReadOnly = false;
            this.txtConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirm.Depth = 0;
            this.txtConfirm.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirm.HideSelection = true;
            this.txtConfirm.LeadingIcon = null;
            this.txtConfirm.Location = new System.Drawing.Point(292, 145);
            this.txtConfirm.MaxLength = 32767;
            this.txtConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.PrefixSuffixText = null;
            this.txtConfirm.ReadOnly = false;
            this.txtConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirm.SelectedText = "";
            this.txtConfirm.SelectionLength = 0;
            this.txtConfirm.SelectionStart = 0;
            this.txtConfirm.ShortcutsEnabled = true;
            this.txtConfirm.Size = new System.Drawing.Size(250, 48);
            this.txtConfirm.TabIndex = 15;
            this.txtConfirm.TabStop = false;
            this.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirm.TrailingIcon = null;
            this.txtConfirm.UseSystemPasswordChar = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(17, 114);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 19);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = true;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(17, 145);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 48);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(203, 312);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(64, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(114, 312);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(17, 312);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save ";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = true;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserName.Location = new System.Drawing.Point(292, 25);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 19);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "USER NAME";
            // 
            // txtUserName
            // 
            this.txtUserName.AnimateReadOnly = false;
            this.txtUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserName.Depth = 0;
            this.txtUserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.HideSelection = true;
            this.txtUserName.LeadingIcon = null;
            this.txtUserName.Location = new System.Drawing.Point(292, 56);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PrefixSuffixText = null;
            this.txtUserName.ReadOnly = false;
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(250, 48);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TabStop = false;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.TrailingIcon = null;
            this.txtUserName.UseSystemPasswordChar = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Depth = 0;
            this.lblUserID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserID.Location = new System.Drawing.Point(17, 25);
            this.lblUserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(59, 19);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "USER ID";
            // 
            // txtUserID
            // 
            this.txtUserID.AnimateReadOnly = false;
            this.txtUserID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserID.Depth = 0;
            this.txtUserID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserID.HideSelection = true;
            this.txtUserID.LeadingIcon = null;
            this.txtUserID.Location = new System.Drawing.Point(17, 56);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PrefixSuffixText = null;
            this.txtUserID.ReadOnly = false;
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserID.SelectedText = "";
            this.txtUserID.SelectionLength = 0;
            this.txtUserID.SelectionStart = 0;
            this.txtUserID.ShortcutsEnabled = true;
            this.txtUserID.Size = new System.Drawing.Size(250, 48);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.TabStop = false;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserID.TrailingIcon = null;
            this.txtUserID.UseSystemPasswordChar = false;
            // 
            // TPAddEditUser
            // 
            this.TPAddEditUser.Controls.Add(this.CardCRUD);
            this.TPAddEditUser.Location = new System.Drawing.Point(4, 22);
            this.TPAddEditUser.Name = "TPAddEditUser";
            this.TPAddEditUser.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddEditUser.Size = new System.Drawing.Size(1207, 407);
            this.TPAddEditUser.TabIndex = 1;
            this.TPAddEditUser.Text = "Create User";
            this.TPAddEditUser.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = null;
            this.btnNew.Location = new System.Drawing.Point(9, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(64, 36);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "ADD";
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(93, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(64, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.btnRefresh);
            this.TopPanel.Controls.Add(this.btnNew);
            this.TopPanel.Controls.Add(this.btnDelete);
            this.TopPanel.Controls.Add(this.btnEdit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1201, 53);
            this.TopPanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(311, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(84, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = true;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TCAdminMenu
            // 
            this.TCAdminMenu.Controls.Add(this.TPUserList);
            this.TCAdminMenu.Controls.Add(this.TPAddEditUser);
            this.TCAdminMenu.Depth = 0;
            this.TCAdminMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCAdminMenu.Location = new System.Drawing.Point(0, 48);
            this.TCAdminMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCAdminMenu.Multiline = true;
            this.TCAdminMenu.Name = "TCAdminMenu";
            this.TCAdminMenu.SelectedIndex = 0;
            this.TCAdminMenu.Size = new System.Drawing.Size(1215, 433);
            this.TCAdminMenu.TabIndex = 2;
            // 
            // TPUserList
            // 
            this.TPUserList.Controls.Add(this.RightCard);
            this.TPUserList.Controls.Add(this.LeftCard);
            this.TPUserList.Controls.Add(this.TopPanel);
            this.TPUserList.Location = new System.Drawing.Point(4, 22);
            this.TPUserList.Name = "TPUserList";
            this.TPUserList.Padding = new System.Windows.Forms.Padding(3);
            this.TPUserList.Size = new System.Drawing.Size(1207, 407);
            this.TPUserList.TabIndex = 0;
            this.TPUserList.Text = "User List";
            this.TPUserList.UseVisualStyleBackColor = true;
            // 
            // RightCard
            // 
            this.RightCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightCard.Controls.Add(this.dgvAccessRight);
            this.RightCard.Controls.Add(this.materialLabel2);
            this.RightCard.Depth = 0;
            this.RightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RightCard.Location = new System.Drawing.Point(731, 56);
            this.RightCard.Margin = new System.Windows.Forms.Padding(14);
            this.RightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightCard.Name = "RightCard";
            this.RightCard.Padding = new System.Windows.Forms.Padding(3);
            this.RightCard.Size = new System.Drawing.Size(473, 348);
            this.RightCard.TabIndex = 9;
            // 
            // dgvAccessRight
            // 
            this.dgvAccessRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccessRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessRight.Location = new System.Drawing.Point(6, 29);
            this.dgvAccessRight.Name = "dgvAccessRight";
            this.dgvAccessRight.Size = new System.Drawing.Size(461, 313);
            this.dgvAccessRight.TabIndex = 3;
            this.dgvAccessRight.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "MT Detail ";
            this.materialLabel2.Visible = false;
            // 
            // LeftCard
            // 
            this.LeftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftCard.Controls.Add(this.materialLabel1);
            this.LeftCard.Controls.Add(this.dgvUserList);
            this.LeftCard.Depth = 0;
            this.LeftCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftCard.Location = new System.Drawing.Point(3, 56);
            this.LeftCard.Margin = new System.Windows.Forms.Padding(14);
            this.LeftCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftCard.Name = "LeftCard";
            this.LeftCard.Padding = new System.Windows.Forms.Padding(3);
            this.LeftCard.Size = new System.Drawing.Size(728, 348);
            this.LeftCard.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "List User";
            // 
            // dgvUserList
            // 
            this.dgvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(6, 29);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.Size = new System.Drawing.Size(716, 313);
            this.dgvUserList.TabIndex = 0;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TCAdminMenu;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1215, 48);
            this.TabSelector.TabIndex = 3;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 481);
            this.Controls.Add(this.TCAdminMenu);
            this.Controls.Add(this.TabSelector);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.CardCRUD.ResumeLayout(false);
            this.CardCRUD.PerformLayout();
            this.TPAddEditUser.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TCAdminMenu.ResumeLayout(false);
            this.TPUserList.ResumeLayout(false);
            this.RightCard.ResumeLayout(false);
            this.RightCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessRight)).EndInit();
            this.LeftCard.ResumeLayout(false);
            this.LeftCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomMaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialCard CardCRUD;
        private MaterialSkin.Controls.MaterialLabel lblConfirm;
        private MaterialSkin.Controls.MaterialTextBox2 txtConfirm;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialTextBox2 txtUserName;
        private MaterialSkin.Controls.MaterialLabel lblUserID;
        private MaterialSkin.Controls.MaterialTextBox2 txtUserID;
        private System.Windows.Forms.TabPage TPAddEditUser;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private System.Windows.Forms.Panel TopPanel;
        private MaterialSkin.Controls.MaterialTabControl TCAdminMenu;
        private System.Windows.Forms.TabPage TPUserList;
        private MaterialSkin.Controls.MaterialCard RightCard;
        private System.Windows.Forms.DataGridView dgvAccessRight;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard LeftCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvUserList;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialComboBox cbxUserType;
        private MaterialSkin.Controls.MaterialLabel lblUserTYPE;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
    }
}