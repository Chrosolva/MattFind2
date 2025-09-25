namespace Login.View
{
    partial class FormChangeStatusMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeStatusMM));
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TSProblem = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TSBacklog = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TSGI = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(261, 29);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(54, 18);
            this.guna2HtmlLabel5.TabIndex = 76;
            this.guna2HtmlLabel5.Text = "Problem";
            // 
            // TSProblem
            // 
            this.TSProblem.BackColor = System.Drawing.Color.White;
            this.TSProblem.Checked = true;
            this.TSProblem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSProblem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSProblem.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSProblem.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSProblem.Location = new System.Drawing.Point(261, 50);
            this.TSProblem.Name = "TSProblem";
            this.TSProblem.Size = new System.Drawing.Size(45, 24);
            this.TSProblem.TabIndex = 75;
            this.TSProblem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSProblem.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSProblem.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSProblem.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSProblem.CheckedChanged += new System.EventHandler(this.TSEmpty_CheckedChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(133, 29);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(57, 18);
            this.guna2HtmlLabel4.TabIndex = 74;
            this.guna2HtmlLabel4.Text = "BackLog";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(20, 29);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(72, 18);
            this.guna2HtmlLabel3.TabIndex = 73;
            this.guna2HtmlLabel3.Text = "Good Issue";
            // 
            // TSBacklog
            // 
            this.TSBacklog.BackColor = System.Drawing.Color.White;
            this.TSBacklog.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSBacklog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSBacklog.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSBacklog.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSBacklog.Location = new System.Drawing.Point(133, 50);
            this.TSBacklog.Name = "TSBacklog";
            this.TSBacklog.Size = new System.Drawing.Size(45, 24);
            this.TSBacklog.TabIndex = 72;
            this.TSBacklog.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSBacklog.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSBacklog.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSBacklog.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSBacklog.CheckedChanged += new System.EventHandler(this.TSBacklog_CheckedChanged);
            // 
            // TSGI
            // 
            this.TSGI.BackColor = System.Drawing.Color.White;
            this.TSGI.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSGI.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSGI.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSGI.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSGI.Location = new System.Drawing.Point(20, 50);
            this.TSGI.Name = "TSGI";
            this.TSGI.Size = new System.Drawing.Size(45, 24);
            this.TSGI.TabIndex = 71;
            this.TSGI.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSGI.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.TSGI.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSGI.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSGI.CheckedChanged += new System.EventHandler(this.TSFull_CheckedChanged);
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
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnAdd.IconColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(226, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "Update";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormChangeStatusMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(352, 132);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.TSProblem);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.TSBacklog);
            this.Controls.Add(this.TSGI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangeStatusMM";
            this.Text = "FormChangeStatusMM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSProblem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSBacklog;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSGI;
        public FontAwesome.Sharp.IconButton btnAdd;
    }
}