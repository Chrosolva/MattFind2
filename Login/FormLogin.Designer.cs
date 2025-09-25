namespace WBPOS.View
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPilihServer = new System.Windows.Forms.ComboBox();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.xuiSuperButton2 = new XanderUI.XUISuperButton();
            this.btnExit = new XanderUI.XUISuperButton();
            this.cstmTextbox2 = new Login.UC.CstmTextbox();
            this.cstmTextbox1 = new Login.UC.CstmTextbox();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.PaleTurquoise;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.DarkBlue;
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(265, 276);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.PaleTurquoise;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.MediumSlateBlue;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Awesome Sauce DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(296, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Awesome Sauce DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(296, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Awesome Sauce DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server";
            // 
            // cbxPilihServer
            // 
            this.cbxPilihServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPilihServer.FormattingEnabled = true;
            this.cbxPilihServer.Items.AddRange(new object[] {
            "localhost"});
            this.cbxPilihServer.Location = new System.Drawing.Point(299, 185);
            this.cbxPilihServer.Name = "cbxPilihServer";
            this.cbxPilihServer.Size = new System.Drawing.Size(183, 21);
            this.cbxPilihServer.TabIndex = 6;
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton1.ButtonImage = null;
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "Login";
            this.xuiSuperButton1.CornerRadius = 5;
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(299, 224);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(82, 28);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 7;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiSuperButton2
            // 
            this.xuiSuperButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(10)))), ((int)(((byte)(24)))));
            this.xuiSuperButton2.ButtonImage = null;
            this.xuiSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton2.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton2.ButtonText = "Cancel";
            this.xuiSuperButton2.CornerRadius = 5;
            this.xuiSuperButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.xuiSuperButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton2.Location = new System.Drawing.Point(400, 224);
            this.xuiSuperButton2.Name = "xuiSuperButton2";
            this.xuiSuperButton2.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton2.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Size = new System.Drawing.Size(82, 28);
            this.xuiSuperButton2.SuperSelected = false;
            this.xuiSuperButton2.TabIndex = 8;
            this.xuiSuperButton2.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnExit.Location = new System.Drawing.Point(493, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.SelectedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.SelectedTextColor = System.Drawing.Color.White;
            this.btnExit.Size = new System.Drawing.Size(18, 16);
            this.btnExit.SuperSelected = false;
            this.btnExit.TabIndex = 9;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.xuiSuperButton3_MouseHover);
            // 
            // cstmTextbox2
            // 
            this.cstmTextbox2.Location = new System.Drawing.Point(296, 118);
            this.cstmTextbox2.Name = "cstmTextbox2";
            this.cstmTextbox2.Size = new System.Drawing.Size(186, 38);
            this.cstmTextbox2.TabIndex = 4;
            // 
            // cstmTextbox1
            // 
            this.cstmTextbox1.Location = new System.Drawing.Point(296, 52);
            this.cstmTextbox1.Name = "cstmTextbox1";
            this.cstmTextbox1.Size = new System.Drawing.Size(186, 38);
            this.cstmTextbox1.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.xuiSuperButton2);
            this.Controls.Add(this.xuiSuperButton1);
            this.Controls.Add(this.cbxPilihServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cstmTextbox2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cstmTextbox1);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private Login.UC.CstmTextbox cstmTextbox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private Login.UC.CstmTextbox cstmTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPilihServer;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private XanderUI.XUISuperButton xuiSuperButton2;
        private XanderUI.XUISuperButton btnExit;
    }
}