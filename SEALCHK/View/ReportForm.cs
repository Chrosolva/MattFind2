using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SEALCHK.Data;
using SEALCHK.Model;
using SEALCHK.Reports;

namespace SEALCHK.View
{
    public partial class ReportForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();

        public ReportForm()
        {
            InitializeComponent();
            // sensible defaults for date pickers
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;

        }

        private void PopulateFilters()
        {
            try
            {
                // NoPlat list
                var plats = _db.Registers.AsNoTracking()
                    .Select(r => r.NoPlat)
                    .Distinct()
                    .OrderBy(s => s)
                    .ToList();
                cbxNoPlat.Items.Clear();
                cbxNoPlat.Items.Add(""); // empty = all
                cbxNoPlat.Items.AddRange(plats.Cast<object>().ToArray());

                // Status list (from RegStatus + DetailStatus)
                var statuses = _db.Registers.AsNoTracking().Select(r => r.Status)
                    .Concat(_db.DetailRegisters.AsNoTracking().Select(d => d.Status))
                    .Where(s => s != null && s != "")
                    .Distinct()
                    .OrderBy(s => s)
                    .ToList();
                cbxStatus.Items.Clear();
                cbxStatus.Items.Add("");
                cbxStatus.Items.AddRange(statuses.Cast<object>().ToArray());
            }
            catch { /* swallow for now */ }
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(cbxJenisLaporan.SelectedIndex == 0)
            {
                // REPORT SUMMARY 
                // compute date range HERE (or store as fields if you prefer)
                DateTime from = dtpFrom.Value.Date;
                DateTime toExcl = dtpTo.Value.Date.AddDays(1);

                // read optional filters (empty => ignored)
                string noPlat = (cbxNoPlat.Text ?? "").Trim();
                string status = (cbxStatus.Text ?? "").Trim();
                string tujuan = (txtTujuan.Text ?? "").Trim();

                // 1) Fill dataset
                var ds = BuildRegisterDataSet(from, toExcl, noPlat, status, tujuan);

                if (ds.RegisterDetail.Rows.Count == 0)
                {
                    MessageBox.Show("No data for the selected filters / date range.", "Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    crViewer.ReportSource = null;
                    return;
                }

                // 2) Load rpt
                // OPTION A: Strongly-typed Crystal class (when you added RegisterSummary.rpt to the project)
                var rpt = new Reports.RegisterSummary();

                // OPTION B: Load from file path instead:
                // var rpt = new ReportDocument();
                // rpt.Load(System.IO.Path.Combine(Application.StartupPath, "Reports\\RegisterSummary.rpt"));

                rpt.SetDataSource(ds);

                // 3) Set parameters for display (report header)
                SetParamEverywhere(rpt, "FromDate", from);
                SetParamEverywhere(rpt, "ToDate", toExcl.AddDays(-1));
                SetParamEverywhere(rpt, "NoPlat", string.IsNullOrWhiteSpace(noPlat) ? "" : noPlat);
                SetParamEverywhere(rpt, "Status", string.IsNullOrWhiteSpace(status) ? "" : status);
                SetParamEverywhere(rpt, "Tujuan", string.IsNullOrWhiteSpace(tujuan) ? "" : tujuan);

                // 4) Bind to viewer
                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None; // optional
                crViewer.ReportSource = rpt;
                crViewer.Refresh();
            }
        }

        private SealReportDataSet BuildRegisterDataSet(DateTime tglfrom, DateTime toExcl, string noPlat, string status, string tujuan)
        {
            // Prepare typed dataset
            var ds = new SealReportDataSet();
            var t = ds.RegisterDetail;

            // Base query: Register + DetailRegister + (left) DetailMT for PartIndex
            var q =
                from r in _db.Registers.AsNoTracking()
                join d in _db.DetailRegisters.AsNoTracking()
                  on new { r.NoPlat, r.Tgl_Input } equals new { d.NoPlat, d.Tgl_Input }
                join mJoin in _db.DetailMT.AsNoTracking()
                  on new { d.NoPlat, d.PartID } equals new { mJoin.NoPlat, mJoin.PartID } into mG
                from m in mG.DefaultIfEmpty()
                where r.Tgl_Input >= tglfrom && r.Tgl_Input < toExcl
                select new
                {
                    r.Tgl_Input,
                    r.NoPlat,
                    Tujuan = r.Tujuan,
                    RegStatus = r.Status,
                    r.UserINPUT,

                    d.PartID,
                    d.Seal,
                    DetailStatus = d.Status,
                    d.Tgl_Kirim,
                    d.Tgl_Kembali,
                    d.Keterangan,

                    PartIndex = (int?)m.PartIndex
                };

            // Optional filters
            if (!string.IsNullOrWhiteSpace(noPlat))
                q = q.Where(x => x.NoPlat == noPlat);

            if (!string.IsNullOrWhiteSpace(status))
                q = q.Where(x => (x.RegStatus ?? "").Contains(status) || (x.DetailStatus ?? "").Contains(status));

            if (!string.IsNullOrWhiteSpace(tujuan))
                q = q.Where(x => (x.Tujuan ?? "").Contains(tujuan));

            // Materialize in the correct order for printing
            var list = q
                .OrderByDescending(x => x.Tgl_Input)
                .ThenBy(x => x.PartIndex ?? int.MaxValue)
                .ThenBy(x => x.PartID)
                .ToList();

            // Fill typed table (names must match XSD columns)
            foreach (var x in list)
            {
                var row = t.NewRegisterDetailRow();

                row.Tgl_Input = x.Tgl_Input;
                row.NoPlat = x.NoPlat ?? string.Empty;
                row.Tujuan = x.Tujuan ?? string.Empty;
                row.RegStatus = x.RegStatus ?? string.Empty;
                row.UserINPUT = x.UserINPUT ?? string.Empty;

                row.PartID = x.PartID ?? string.Empty;
                row.Seal = x.Seal ?? string.Empty;
                row.DetailStatus = x.DetailStatus ?? string.Empty;

                if (x.Tgl_Kirim.HasValue) row.Tgl_Kirim = x.Tgl_Kirim.Value; else row.SetTgl_KirimNull();
                if (x.Tgl_Kembali.HasValue) row.Tgl_Kembali = x.Tgl_Kembali.Value; else row.SetTgl_KembaliNull();

                row.Keterangan = x.Keterangan ?? string.Empty;

                if (x.PartIndex.HasValue) row.PartIndex = x.PartIndex.Value; else row.SetPartIndexNull();

                t.AddRegisterDetailRow(row);
            }

            return ds;
        }

        // Log available parameters (for quick diagnosis)
        private static string ListParams(ReportDocument rpt)
        {
            var main = string.Join(", ",
                rpt.DataDefinition?.ParameterFields.Cast<ParameterFieldDefinition>()
                    .Select(p => p.Name) ?? Enumerable.Empty<string>());

            var subs = string.Join("\r\n", rpt.Subreports.Cast<ReportDocument>().Select(sr =>
            {
                var names = string.Join(", ",
                    sr.DataDefinition?.ParameterFields.Cast<ParameterFieldDefinition>()
                        .Select(p => p.Name) ?? Enumerable.Empty<string>());
                return $"  [{sr.Name}] -> {names}";
            }));

            return $"Main: {main}\r\nSubreports:\r\n{subs}";
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

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cbxJenisLaporan.SelectedIndex = 0;
            PopulateFilters();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var rpt = crViewer.ReportSource as ReportDocument;
            if (rpt == null)
            {
                MessageBox.Show("No report to export. Click Preview first.");
                return;
            }

            using (var sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"RegisterSummary_{DateTime.Now:yyyyMMdd_HHmmss}.pdf" })
            {
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    var di = new DiskFileDestinationOptions { DiskFileName = sfd.FileName };
                    var exp = new ExportOptions
                    {
                        ExportDestinationType = ExportDestinationType.DiskFile,
                        ExportFormatType = ExportFormatType.PortableDocFormat,
                        DestinationOptions = di,
                        FormatOptions = new PdfRtfWordFormatOptions()
                    };
                    rpt.Export(exp);
                    MessageBox.Show("Saved: " + sfd.FileName);
                }
            }
        }
    }
}
