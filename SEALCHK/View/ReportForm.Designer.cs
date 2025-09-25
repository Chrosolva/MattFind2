namespace SEALCHK.View
{
    partial class ReportForm
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxJenisLaporan = new MaterialSkin.Controls.MaterialComboBox();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.TCReport = new System.Windows.Forms.TabControl();
            this.TPReportViewer = new System.Windows.Forms.TabPage();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbxNoPlat = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTujuan = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnExportPDF = new MaterialSkin.Controls.MaterialButton();
            this.leftpanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.TCReport.SuspendLayout();
            this.TPReportViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.btnExportPDF);
            this.leftpanel.Controls.Add(this.txtTujuan);
            this.leftpanel.Controls.Add(this.cbxStatus);
            this.leftpanel.Controls.Add(this.cbxNoPlat);
            this.leftpanel.Controls.Add(this.btnPreview);
            this.leftpanel.Controls.Add(this.dtpTo);
            this.leftpanel.Controls.Add(this.dtpFrom);
            this.leftpanel.Controls.Add(this.materialLabel10);
            this.leftpanel.Controls.Add(this.cbxJenisLaporan);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(313, 528);
            this.leftpanel.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new System.Drawing.Point(12, 201);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreview.Size = new System.Drawing.Size(83, 36);
            this.btnPreview.TabIndex = 38;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPreview.UseAccentColor = false;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(12, 153);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 37;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(12, 127);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 36;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(12, 107);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(211, 19);
            this.materialLabel10.TabIndex = 35;
            this.materialLabel10.Text = "FILTER TGL_INPUT FROM TO";
            // 
            // cbxJenisLaporan
            // 
            this.cbxJenisLaporan.AutoResize = false;
            this.cbxJenisLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxJenisLaporan.Depth = 0;
            this.cbxJenisLaporan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxJenisLaporan.DropDownHeight = 174;
            this.cbxJenisLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJenisLaporan.DropDownWidth = 121;
            this.cbxJenisLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxJenisLaporan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxJenisLaporan.FormattingEnabled = true;
            this.cbxJenisLaporan.IntegralHeight = false;
            this.cbxJenisLaporan.ItemHeight = 43;
            this.cbxJenisLaporan.Items.AddRange(new object[] {
            "REGISTER SUMMARY"});
            this.cbxJenisLaporan.Location = new System.Drawing.Point(12, 25);
            this.cbxJenisLaporan.MaxDropDownItems = 4;
            this.cbxJenisLaporan.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxJenisLaporan.Name = "cbxJenisLaporan";
            this.cbxJenisLaporan.Size = new System.Drawing.Size(262, 49);
            this.cbxJenisLaporan.StartIndex = 0;
            this.cbxJenisLaporan.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.TCReport);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(313, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(794, 528);
            this.ContentPanel.TabIndex = 1;
            // 
            // TCReport
            // 
            this.TCReport.Controls.Add(this.TPReportViewer);
            this.TCReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCReport.Location = new System.Drawing.Point(0, 0);
            this.TCReport.Name = "TCReport";
            this.TCReport.SelectedIndex = 0;
            this.TCReport.Size = new System.Drawing.Size(794, 528);
            this.TCReport.TabIndex = 0;
            // 
            // TPReportViewer
            // 
            this.TPReportViewer.Controls.Add(this.StatusStrip);
            this.TPReportViewer.Controls.Add(this.crViewer);
            this.TPReportViewer.Location = new System.Drawing.Point(4, 22);
            this.TPReportViewer.Name = "TPReportViewer";
            this.TPReportViewer.Padding = new System.Windows.Forms.Padding(3);
            this.TPReportViewer.Size = new System.Drawing.Size(786, 502);
            this.TPReportViewer.TabIndex = 0;
            this.TPReportViewer.Text = "REPORT VIEWER";
            this.TPReportViewer.UseVisualStyleBackColor = true;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(3, 477);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(780, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer.Location = new System.Drawing.Point(3, 3);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(780, 496);
            this.crViewer.TabIndex = 1;
            // 
            // cbxNoPlat
            // 
            this.cbxNoPlat.AutoResize = false;
            this.cbxNoPlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxNoPlat.Depth = 0;
            this.cbxNoPlat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxNoPlat.DropDownHeight = 174;
            this.cbxNoPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNoPlat.DropDownWidth = 121;
            this.cbxNoPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxNoPlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxNoPlat.FormattingEnabled = true;
            this.cbxNoPlat.IntegralHeight = false;
            this.cbxNoPlat.ItemHeight = 43;
            this.cbxNoPlat.Location = new System.Drawing.Point(15, 270);
            this.cbxNoPlat.MaxDropDownItems = 4;
            this.cbxNoPlat.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxNoPlat.Name = "cbxNoPlat";
            this.cbxNoPlat.Size = new System.Drawing.Size(135, 49);
            this.cbxNoPlat.StartIndex = 0;
            this.cbxNoPlat.TabIndex = 39;
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoResize = false;
            this.cbxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxStatus.Depth = 0;
            this.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxStatus.DropDownHeight = 174;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.DropDownWidth = 121;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.IntegralHeight = false;
            this.cbxStatus.ItemHeight = 43;
            this.cbxStatus.Location = new System.Drawing.Point(15, 339);
            this.cbxStatus.MaxDropDownItems = 4;
            this.cbxStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(135, 49);
            this.cbxStatus.StartIndex = 0;
            this.cbxStatus.TabIndex = 40;
            // 
            // txtTujuan
            // 
            this.txtTujuan.AnimateReadOnly = false;
            this.txtTujuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTujuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTujuan.Depth = 0;
            this.txtTujuan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTujuan.HideSelection = true;
            this.txtTujuan.LeadingIcon = null;
            this.txtTujuan.Location = new System.Drawing.Point(15, 407);
            this.txtTujuan.MaxLength = 32767;
            this.txtTujuan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTujuan.Name = "txtTujuan";
            this.txtTujuan.PasswordChar = '\0';
            this.txtTujuan.PrefixSuffixText = null;
            this.txtTujuan.ReadOnly = false;
            this.txtTujuan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTujuan.SelectedText = "";
            this.txtTujuan.SelectionLength = 0;
            this.txtTujuan.SelectionStart = 0;
            this.txtTujuan.ShortcutsEnabled = true;
            this.txtTujuan.Size = new System.Drawing.Size(250, 48);
            this.txtTujuan.TabIndex = 41;
            this.txtTujuan.TabStop = false;
            this.txtTujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTujuan.TrailingIcon = null;
            this.txtTujuan.UseSystemPasswordChar = false;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportPDF.Depth = 0;
            this.btnExportPDF.HighEmphasis = true;
            this.btnExportPDF.Icon = null;
            this.btnExportPDF.Location = new System.Drawing.Point(115, 201);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportPDF.Size = new System.Drawing.Size(108, 36);
            this.btnExportPDF.TabIndex = 42;
            this.btnExportPDF.Text = "EXPORT PDF";
            this.btnExportPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportPDF.UseAccentColor = false;
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 528);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.leftpanel);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.TCReport.ResumeLayout(false);
            this.TPReportViewer.ResumeLayout(false);
            this.TPReportViewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel ContentPanel;
        private MaterialSkin.Controls.MaterialComboBox cbxJenisLaporan;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private System.Windows.Forms.TabControl TCReport;
        private System.Windows.Forms.TabPage TPReportViewer;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
        private MaterialSkin.Controls.MaterialComboBox cbxStatus;
        private MaterialSkin.Controls.MaterialComboBox cbxNoPlat;
        private MaterialSkin.Controls.MaterialTextBox2 txtTujuan;
        private MaterialSkin.Controls.MaterialButton btnExportPDF;
    }
}