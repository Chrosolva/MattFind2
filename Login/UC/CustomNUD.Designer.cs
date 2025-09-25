namespace WBPOS.UC
{
    partial class CustomNUD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddVal = new FontAwesome.Sharp.IconButton();
            this.btnFalse = new FontAwesome.Sharp.IconButton();
            this.btnMinusVal = new FontAwesome.Sharp.IconButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddVal);
            this.panel2.Controls.Add(this.btnFalse);
            this.panel2.Controls.Add(this.btnMinusVal);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3, 6, 6, 3);
            this.panel2.Size = new System.Drawing.Size(138, 23);
            this.panel2.TabIndex = 0;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btnAddVal
            // 
            this.btnAddVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.btnAddVal.FlatAppearance.BorderSize = 0;
            this.btnAddVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVal.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddVal.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddVal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddVal.IconSize = 14;
            this.btnAddVal.Location = new System.Drawing.Point(117, -3);
            this.btnAddVal.Name = "btnAddVal";
            this.btnAddVal.Size = new System.Drawing.Size(28, 28);
            this.btnAddVal.TabIndex = 1;
            this.btnAddVal.UseVisualStyleBackColor = false;
            this.btnAddVal.Click += new System.EventHandler(this.btnAddVal_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.btnFalse.Enabled = false;
            this.btnFalse.FlatAppearance.BorderSize = 0;
            this.btnFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalse.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnFalse.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnFalse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFalse.IconSize = 14;
            this.btnFalse.Location = new System.Drawing.Point(117, -3);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(21, 28);
            this.btnFalse.TabIndex = 3;
            this.btnFalse.UseVisualStyleBackColor = false;
            // 
            // btnMinusVal
            // 
            this.btnMinusVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.btnMinusVal.FlatAppearance.BorderSize = 0;
            this.btnMinusVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusVal.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinusVal.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinusVal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinusVal.IconSize = 14;
            this.btnMinusVal.Location = new System.Drawing.Point(0, 0);
            this.btnMinusVal.Name = "btnMinusVal";
            this.btnMinusVal.Size = new System.Drawing.Size(21, 28);
            this.btnMinusVal.TabIndex = 2;
            this.btnMinusVal.UseVisualStyleBackColor = false;
            this.btnMinusVal.Click += new System.EventHandler(this.btnMinusVal_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(3, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 16);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.panel1.Size = new System.Drawing.Size(147, 29);
            this.panel1.TabIndex = 3;
            this.panel1.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // CustomNUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomNUD";
            this.Size = new System.Drawing.Size(147, 29);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFalse;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public FontAwesome.Sharp.IconButton btnAddVal;
        public FontAwesome.Sharp.IconButton btnMinusVal;
    }
}
