namespace Login.View
{
    partial class FormChooseGUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChooseGUD));
            this.FLGUD = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.txtScanCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxJenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLGUD
            // 
            this.FLGUD.AutoScroll = true;
            this.FLGUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FLGUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLGUD.Location = new System.Drawing.Point(0, 54);
            this.FLGUD.Name = "FLGUD";
            this.FLGUD.Padding = new System.Windows.Forms.Padding(85, 15, 15, 15);
            this.FLGUD.Size = new System.Drawing.Size(845, 352);
            this.FLGUD.TabIndex = 0;
            this.FLGUD.Paint += new System.Windows.Forms.PaintEventHandler(this.FLGUD_Paint);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.White;
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panelUp.Size = new System.Drawing.Size(253, 54);
            this.panelUp.TabIndex = 1;
            // 
            // txtScanCode
            // 
            this.txtScanCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScanCode.DefaultText = "";
            this.txtScanCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtScanCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtScanCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtScanCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtScanCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtScanCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtScanCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtScanCode.Location = new System.Drawing.Point(375, 9);
            this.txtScanCode.Name = "txtScanCode";
            this.txtScanCode.PasswordChar = '\0';
            this.txtScanCode.PlaceholderText = "";
            this.txtScanCode.SelectedText = "";
            this.txtScanCode.Size = new System.Drawing.Size(235, 36);
            this.txtScanCode.TabIndex = 0;
            this.txtScanCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyUp);
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.BackColor = System.Drawing.Color.White;
            this.gunaLabel11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gunaLabel11.Location = new System.Drawing.Point(269, 14);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(100, 31);
            this.gunaLabel11.TabIndex = 72;
            this.gunaLabel11.Text = "Scan Code";
            this.gunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbxJenis);
            this.panel1.Controls.Add(this.txtScanCode);
            this.panel1.Controls.Add(this.gunaLabel11);
            this.panel1.Controls.Add(this.panelUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 54);
            this.panel1.TabIndex = 73;
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
            "Material",
            "SlocBin"});
            this.cbxJenis.Location = new System.Drawing.Point(635, 9);
            this.cbxJenis.Name = "cbxJenis";
            this.cbxJenis.Size = new System.Drawing.Size(140, 36);
            this.cbxJenis.TabIndex = 73;
            // 
            // FormChooseGUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 406);
            this.Controls.Add(this.FLGUD);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChooseGUD";
            this.Text = "FormChooseGUD";
            this.Load += new System.EventHandler(this.FormChooseGUD_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLGUD;
        private System.Windows.Forms.Panel panelUp;
        private Guna.UI2.WinForms.Guna2TextBox txtScanCode;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxJenis;
    }
}