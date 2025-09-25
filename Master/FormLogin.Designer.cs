namespace Master
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbxPilihServer = new System.Windows.Forms.ComboBox();
            this.btnLogin = new XanderUI.XUISuperButton();
            this.btnCancel = new XanderUI.XUISuperButton();
            this.btnExit = new XanderUI.XUISuperButton();
            this.csttxtPassword = new Master.UC.CustomTextBox();
            this.csttxtuserid = new Master.UC.CustomTextBox();
            this.xuiGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Aquamarine;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.MediumBlue;
            this.xuiGradientPanel1.Controls.Add(this.pictureBox1);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(450, 301);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.Aquamarine;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.MediumBlue;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(484, 27);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 20);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "userid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "password";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(484, 169);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(55, 20);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server";
            // 
            // cbxPilihServer
            // 
            this.cbxPilihServer.FormattingEnabled = true;
            this.cbxPilihServer.Items.AddRange(new object[] {
            "localhost"});
            this.cbxPilihServer.Location = new System.Drawing.Point(482, 195);
            this.cbxPilihServer.Name = "cbxPilihServer";
            this.cbxPilihServer.Size = new System.Drawing.Size(233, 21);
            this.cbxPilihServer.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnLogin.ButtonImage = null;
            this.btnLogin.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLogin.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.CornerRadius = 5;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.PeachPuff;
            this.btnLogin.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLogin.Location = new System.Drawing.Point(482, 239);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLogin.SelectedTextColor = System.Drawing.Color.PeachPuff;
            this.btnLogin.Size = new System.Drawing.Size(100, 36);
            this.btnLogin.SuperSelected = false;
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TextColor = System.Drawing.Color.PeachPuff;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnCancel.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(615, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.SelectedBackColor = System.Drawing.Color.Crimson;
            this.btnCancel.SelectedTextColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.SuperSelected = false;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.TextColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ButtonImage")));
            this.btnExit.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnExit.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnExit.ButtonText = "";
            this.btnExit.CornerRadius = 5;
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.HoverTextColor = System.Drawing.Color.White;
            this.btnExit.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(729, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.SelectedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.SelectedTextColor = System.Drawing.Color.White;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SuperSelected = false;
            this.btnExit.TabIndex = 0;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // csttxtPassword
            // 
            this.csttxtPassword.Location = new System.Drawing.Point(482, 124);
            this.csttxtPassword.Name = "csttxtPassword";
            this.csttxtPassword.Size = new System.Drawing.Size(233, 38);
            this.csttxtPassword.TabIndex = 4;
            this.csttxtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.csttxtPassword_KeyUp);
            // 
            // csttxtuserid
            // 
            this.csttxtuserid.Location = new System.Drawing.Point(482, 52);
            this.csttxtuserid.Name = "csttxtuserid";
            this.csttxtuserid.Size = new System.Drawing.Size(233, 38);
            this.csttxtuserid.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxPilihServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.csttxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.csttxtuserid);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private UC.CustomTextBox csttxtuserid;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label1;
        private UC.CustomTextBox csttxtPassword;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cbxPilihServer;
        //private XanderUI.XUISuperButton btnLogin;
        //private XanderUI.XUISuperButton btnCancel;
        //private XanderUI.XUISuperButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}