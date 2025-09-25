namespace SEALCHK.UserControls
{
    partial class UCTujuan
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
            this.txtKodeTujuan = new System.Windows.Forms.TextBox();
            this.btnSel = new MaterialSkin.Controls.MaterialButton();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.lblNamaSPBU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKodeTujuan
            // 
            this.txtKodeTujuan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeTujuan.Location = new System.Drawing.Point(7, 27);
            this.txtKodeTujuan.Name = "txtKodeTujuan";
            this.txtKodeTujuan.Size = new System.Drawing.Size(215, 25);
            this.txtKodeTujuan.TabIndex = 0;
            // 
            // btnSel
            // 
            this.btnSel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSel.Depth = 0;
            this.btnSel.HighEmphasis = true;
            this.btnSel.Icon = null;
            this.btnSel.Location = new System.Drawing.Point(229, 21);
            this.btnSel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSel.Name = "btnSel";
            this.btnSel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSel.Size = new System.Drawing.Size(64, 36);
            this.btnSel.TabIndex = 2;
            this.btnSel.Text = "SET";
            this.btnSel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSel.UseAccentColor = false;
            this.btnSel.UseVisualStyleBackColor = true;
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(13, 11);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(40, 13);
            this.lblPortStatus.TabIndex = 10;
            this.lblPortStatus.Text = "SPBU :";
            // 
            // lblNamaSPBU
            // 
            this.lblNamaSPBU.AutoSize = true;
            this.lblNamaSPBU.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaSPBU.Location = new System.Drawing.Point(59, 11);
            this.lblNamaSPBU.Name = "lblNamaSPBU";
            this.lblNamaSPBU.Size = new System.Drawing.Size(11, 13);
            this.lblNamaSPBU.TabIndex = 11;
            this.lblNamaSPBU.Text = "-";
            // 
            // UCTujuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNamaSPBU);
            this.Controls.Add(this.lblPortStatus);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.txtKodeTujuan);
            this.Name = "UCTujuan";
            this.Size = new System.Drawing.Size(303, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKodeTujuan;
        private MaterialSkin.Controls.MaterialButton btnSel;
        private System.Windows.Forms.Label lblPortStatus;
        private System.Windows.Forms.Label lblNamaSPBU;
    }
}
