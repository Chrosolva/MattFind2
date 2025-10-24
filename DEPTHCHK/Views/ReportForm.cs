using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DEPTHCHK.Data;
using DEPTHCHK.Models;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace DEPTHCHK.Views
{
    public partial class ReportForm : Form
    {
        private readonly depthchkDBContext _db = new depthchkDBContext();
        private ReportDocument _reportDoc;

        public ReportForm()
        {
            InitializeComponent();
            LoadJenisLaporan();
            LoadNoPlatList();

            btnPreview.Click += BtnPreview_Click;
            btnExportPDF.Click += BtnExportPDF_Click;
            btnExportExcel.Click += BtnExportExcel_Click;
        }

        private void LoadJenisLaporan()
        {
            cbxJenisLaporan.Items.Clear();
            cbxJenisLaporan.Items.Add("DAFTAR PENGIRIMAN");
            cbxJenisLaporan.SelectedIndex = 0;
        }

        private void LoadNoPlatList()
        {
            var noPlats = _db.Pengirimans
                             .AsNoTracking()
                             .Select(p => p.NoPlat)
                             .Distinct()
                             .OrderBy(p => p)
                             .ToList();

            cbxNoPlat.Items.Clear();
            cbxNoPlat.Items.Add("ALL");
            foreach (var np in noPlats)
                cbxNoPlat.Items.Add(np);

            cbxNoPlat.SelectedIndex = 0;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            string reportType = cbxJenisLaporan.SelectedItem?.ToString();
            if (reportType == "DAFTAR PENGIRIMAN")
            {
                GenerateSummaryReport();
            }
            else
            {
                MessageBox.Show("Report type not supported yet.");
            }
        }

        private void GenerateSummaryReport()
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime toEx = dtpTo.Value.Date.AddDays(1);
            string noPlatFilter = (cbxNoPlat.SelectedItem == null) ? "ALL" : cbxNoPlat.SelectedItem.ToString();

            var q = _db.Pengirimans.AsNoTracking()
                        .Where(p => p.Tgl_Input >= from && p.Tgl_Input < toEx);

            if (!string.IsNullOrEmpty(noPlatFilter) && noPlatFilter != "ALL")
                q = q.Where(p => p.NoPlat == noPlatFilter);

            var masters = q.OrderBy(p => p.Tgl_Input).ToList();

            // Build a single table with the requested columns
            DataTable dt = new DataTable("Summary");
            dt.Columns.Add("IDPengiriman");
            dt.Columns.Add("Tgl_Input", typeof(DateTime));
            dt.Columns.Add("NoPlat");
            dt.Columns.Add("DataBacaan");
            dt.Columns.Add("DataKalibrasi");
            dt.Columns.Add("Keterangan");

            foreach (var p in masters)
            {
                var details = _db.DetailPengirimans.AsNoTracking()
                                 .Where(d => d.IDPengiriman == p.IDPengiriman)
                                 .OrderBy(d => d.PartID)
                                 .ToList();

                string bacaan = BuildCompString(details, true);   // DataBacaan
                string kalibr = BuildCompString(details, false);  // DataKalibrasi

                // Keterangan: ACTIVE if any ACTIVE; else the first non-empty; else empty
                string ket = "";
                for (int i = 0; i < details.Count; i++)
                {
                    string k = details[i].Keterangan == null ? "" : details[i].Keterangan.Trim();
                    if (string.Compare(k, "ACTIVE", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        ket = "ACTIVE";
                        break;
                    }
                    if (ket.Length == 0 && k.Length > 0) ket = k;
                }

                dt.Rows.Add(
                    p.IDPengiriman,
                    p.Tgl_Input.HasValue ? (object)p.Tgl_Input.Value : DBNull.Value,
                    p.NoPlat,
                    bacaan,
                    kalibr,
                    ket
                );
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            _reportDoc = new DEPTHCHK.Reports.SummaryReport(); // design this .rpt with fields from dt "Summary"
            _reportDoc.SetDataSource(ds);
            SetParamEverywhere(_reportDoc, "DateFrom", from);
            SetParamEverywhere(_reportDoc, "DateTo", toEx);

            crViewer.ReportSource = _reportDoc;
            crViewer.Refresh();
        }

        // Set a parameter across main + any subreports that define it
        private static void SetParamEverywhere(ReportDocument rpt, string paramName, object value)
        {
            // Main
            SetParamIfExists(rpt, paramName, value);

            // Subreports
            foreach (ReportDocument sr in rpt.Subreports)
            {
                var fields = sr.DataDefinition?.ParameterFields;
                if (fields != null && fields.Cast<ParameterFieldDefinition>().Any(f => f.Name == paramName))
                {
                    // Overload with subreport name targets the param inside that subreport
                    rpt.SetParameterValue(paramName, value, sr.Name);
                }
            }
        }

        // Set a parameter in main report if present
        private static void SetParamIfExists(ReportDocument rpt, string paramName, object value)
        {
            var fields = rpt.DataDefinition?.ParameterFields;
            if (fields != null && fields.Cast<ParameterFieldDefinition>().Any(f => f.Name == paramName))
            {
                rpt.SetParameterValue(paramName, value);
            }
        }

        private static string BuildCompString(List<TblDetailPengiriman> details, bool useBacaan)
        {
            // Format: "C1: 5000 | C2: 3500 | ..."
            var parts = new List<string>();
            for (int i = 0; i < details.Count; i++)
            {
                var d = details[i];
                int v = useBacaan ? (d.DataBacaan.HasValue ? d.DataBacaan.Value : 0)
                                  : (d.DataKalibrasi.HasValue ? d.DataKalibrasi.Value : 0);
                parts.Add("C" + (i + 1).ToString() + ": " + v.ToString());
            }
            return string.Join(" | ", parts.ToArray());
        }

        private void BtnExportPDF_Click(object sender, EventArgs e)
        {
            if (_reportDoc == null)
            {
                MessageBox.Show("No report loaded. Please preview first.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF File|*.pdf";
                sfd.Title = "Export Report to PDF";
                sfd.FileName = "SummaryReport.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _reportDoc.ExportToDisk(ExportFormatType.PortableDocFormat, sfd.FileName);
                    MessageBox.Show("Report exported to PDF successfully.");
                }
            }
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            if (_reportDoc == null)
            {
                MessageBox.Show("No report loaded. Please preview first.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel File|*.xlsx";
                sfd.Title = "Export Report to Excel";
                sfd.FileName = "SummaryReport.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _reportDoc.ExportToDisk(ExportFormatType.Excel, sfd.FileName);
                    MessageBox.Show("Report exported to Excel successfully.");
                }
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpFrom.Value.AddDays(-7);
        }
    }
}
