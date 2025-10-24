namespace DEPTHCHK.Views
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
            this.cbxJenisLaporan = new MaterialSkin.Controls.MaterialComboBox();
            this.btnExportExcel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExportPDF = new MaterialSkin.Controls.MaterialButton();
            this.cbxNoPlat = new MaterialSkin.Controls.MaterialComboBox();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.TCReport = new System.Windows.Forms.TabControl();
            this.TPReportViewer = new System.Windows.Forms.TabPage();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.leftpanel.SuspendLayout();
            this.TCReport.SuspendLayout();
            this.TPReportViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.leftpanel.Controls.Add(this.cbxJenisLaporan);
            this.leftpanel.Controls.Add(this.btnExportExcel);
            this.leftpanel.Controls.Add(this.materialLabel10);
            this.leftpanel.Controls.Add(this.btnExportPDF);
            this.leftpanel.Controls.Add(this.cbxNoPlat);
            this.leftpanel.Controls.Add(this.btnPreview);
            this.leftpanel.Controls.Add(this.dtpFrom);
            this.leftpanel.Controls.Add(this.materialLabel1);
            this.leftpanel.Controls.Add(this.dtpTo);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(1133, 107);
            this.leftpanel.TabIndex = 1;
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
            this.cbxJenisLaporan.Hint = "REPROT TYPE";
            this.cbxJenisLaporan.IntegralHeight = false;
            this.cbxJenisLaporan.ItemHeight = 43;
            this.cbxJenisLaporan.Location = new System.Drawing.Point(16, 33);
            this.cbxJenisLaporan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxJenisLaporan.MaxDropDownItems = 4;
            this.cbxJenisLaporan.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxJenisLaporan.Name = "cbxJenisLaporan";
            this.cbxJenisLaporan.Size = new System.Drawing.Size(268, 49);
            this.cbxJenisLaporan.StartIndex = 0;
            this.cbxJenisLaporan.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportExcel.Depth = 0;
            this.btnExportExcel.HighEmphasis = true;
            this.btnExportExcel.Icon = null;
            this.btnExportExcel.Location = new System.Drawing.Point(959, 55);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnExportExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Size = new System.Drawing.Size(124, 36);
            this.btnExportExcel.TabIndex = 43;
            this.btnExportExcel.Text = "EXPORT EXCEL";
            this.btnExportExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportExcel.UseAccentColor = false;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Visible = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(581, 12);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(211, 19);
            this.materialLabel10.TabIndex = 35;
            this.materialLabel10.Text = "FILTER TGL_INPUT FROM TO";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportPDF.Depth = 0;
            this.btnExportPDF.HighEmphasis = true;
            this.btnExportPDF.Icon = null;
            this.btnExportPDF.Location = new System.Drawing.Point(959, 12);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnExportPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportPDF.Size = new System.Drawing.Size(108, 36);
            this.btnExportPDF.TabIndex = 42;
            this.btnExportPDF.Text = "EXPORT PDF";
            this.btnExportPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportPDF.UseAccentColor = false;
            this.btnExportPDF.UseVisualStyleBackColor = true;
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
            this.cbxNoPlat.Location = new System.Drawing.Point(302, 33);
            this.cbxNoPlat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNoPlat.MaxDropDownItems = 4;
            this.cbxNoPlat.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxNoPlat.Name = "cbxNoPlat";
            this.cbxNoPlat.Size = new System.Drawing.Size(261, 49);
            this.cbxNoPlat.StartIndex = 0;
            this.cbxNoPlat.TabIndex = 39;
            // 
            // btnPreview
            // 
            this.btnPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new System.Drawing.Point(866, 12);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreview.Size = new System.Drawing.Size(83, 36);
            this.btnPreview.TabIndex = 38;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPreview.UseAccentColor = false;
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(581, 37);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(265, 22);
            this.dtpFrom.TabIndex = 36;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(299, 10);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 44;
            this.materialLabel1.Text = "NOPLAT";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(581, 69);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(265, 22);
            this.dtpTo.TabIndex = 37;
            // 
            // TCReport
            // 
            this.TCReport.Controls.Add(this.TPReportViewer);
            this.TCReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCReport.Location = new System.Drawing.Point(0, 107);
            this.TCReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TCReport.Name = "TCReport";
            this.TCReport.SelectedIndex = 0;
            this.TCReport.Size = new System.Drawing.Size(1133, 686);
            this.TCReport.TabIndex = 2;
            // 
            // TPReportViewer
            // 
            this.TPReportViewer.Controls.Add(this.StatusStrip);
            this.TPReportViewer.Controls.Add(this.crViewer);
            this.TPReportViewer.Location = new System.Drawing.Point(4, 25);
            this.TPReportViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TPReportViewer.Name = "TPReportViewer";
            this.TPReportViewer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TPReportViewer.Size = new System.Drawing.Size(1125, 657);
            this.TPReportViewer.TabIndex = 0;
            this.TPReportViewer.Text = "REPORT VIEWER";
            this.TPReportViewer.UseVisualStyleBackColor = true;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Location = new System.Drawing.Point(4, 631);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1117, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.AutoSize = true;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer.Location = new System.Drawing.Point(4, 4);
            this.crViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(1117, 649);
            this.crViewer.TabIndex = 1;
            this.crViewer.ToolPanelWidth = 267;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 793);
            this.Controls.Add(this.TCReport);
            this.Controls.Add(this.leftpanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.TCReport.ResumeLayout(false);
            this.TPReportViewer.ResumeLayout(false);
            this.TPReportViewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private MaterialSkin.Controls.MaterialComboBox cbxJenisLaporan;
        private MaterialSkin.Controls.MaterialButton btnExportExcel;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btnExportPDF;
        private MaterialSkin.Controls.MaterialComboBox cbxNoPlat;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TabControl TCReport;
        private System.Windows.Forms.TabPage TPReportViewer;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}