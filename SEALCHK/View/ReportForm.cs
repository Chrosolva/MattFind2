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
using System.Data.SqlClient;
using System.IO;

namespace SEALCHK.View
{
    public partial class ReportForm : Form
    {
        private readonly SealCheckContext _db = new SealCheckContext();

        public class BAPenghapusanSegelRow
        {
            public DateTime Tgl_Input { get; set; }
            public string NoPlat { get; set; }
            public string UserInput { get; set; }
            public string UserOut { get; set; }
            public string SPBU { get; set; }
            public string Segel { get; set; }
            public string StatusSegel { get; set; }
        }


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
            else if (cbxJenisLaporan.SelectedIndex == 1)
            {
                //BA Penghapusan Segel
                DateTime from = dtpFrom.Value.Date;
                DateTime toExcl = dtpTo.Value.Date.AddDays(1);

                string noPlat = (cbxNoPlat.Text ?? "").Trim();
                string status = (cbxStatus.Text ?? "").Trim();
                string tujuan = (txtTujuan.Text ?? "").Trim();

                var dt = BuildBAPenghapusanSegelTable(from, toExcl, noPlat, status, tujuan);
                        if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data for the selected filters / date range.", "Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    crViewer.ReportSource = null;
                    return;
                }

                // Use a Crystal report you’ll create named BAPenghapusanSegel.rpt
                ReportDocument rpt = new Reports.BAPenghapusanSegel(); // strongly-typed
                                                                       // OR:
                                                                       // var rpt = new ReportDocument();
                                                                       // rpt.Load(Path.Combine(Application.StartupPath, "Reports\\BAPenghapusanSegel.rpt"));

                var ds = new DataSet("SealReportData"); // name arbitrary
                ds.Tables.Add(dt);
                rpt.SetDataSource(ds);

                // header params (optional)
                SetParamEverywhere(rpt, "FromDate", from);
                SetParamEverywhere(rpt, "ToDate", toExcl.AddDays(-1));
                SetParamEverywhere(rpt, "NoPlat", string.IsNullOrWhiteSpace(noPlat) ? "" : noPlat);
                SetParamEverywhere(rpt, "Status", string.IsNullOrWhiteSpace(status) ? "" : status);
                SetParamEverywhere(rpt, "Tujuan", string.IsNullOrWhiteSpace(tujuan) ? "" : tujuan);

                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                crViewer.ReportSource = rpt;
                crViewer.Refresh();
            }

            else if (cbxJenisLaporan.SelectedIndex == 2)
            {
                // Summary: Seal counts per Status pivoted by NoPlat
                DateTime from = dtpFrom.Value.Date;
                DateTime toExcl = dtpTo.Value.Date.AddDays(1);

                string noPlat = (cbxNoPlat.Text ?? "").Trim();
                string status = (cbxStatus.Text ?? "").Trim();

                var dt = BuildSealPerStatusPivotTable(from, toExcl, noPlat, status);
                var dtKet = BuildKeteranganPivotTable(from, toExcl, noPlat, status);     // "KeteranganPivot"

                if (dt.Rows.Count == 0 && dtKet.Rows.Count == 0)
                {
                    MessageBox.Show("No data for the selected filters / date range.", "Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    crViewer.ReportSource = null;
                    return;
                }

                // wrap into a DataSet (Crystal likes a DataSet even if you don't have an XSD)
                var ds = new DataSet("SealReportDataSet");
                ds.Tables.Add(dt);
                ds.Tables.Add(dtKet);

                // Load your Crystal report designed for this table
                // Option A: strongly-typed class if you added the .rpt to project
                var rpt = new Reports.SealPerStatusPivot(); // create this .rpt once (see below)

                // Option B: load by path
                // var rpt = new ReportDocument();
                // rpt.Load(Path.Combine(Application.StartupPath, "Reports\\SealPerStatusPivot.rpt"));

                rpt.SetDataSource(ds);

                // Header parameters (optional)
                SetParamEverywhere(rpt, "FromDate", from);
                SetParamEverywhere(rpt, "ToDate", toExcl.AddDays(-1));
                SetParamEverywhere(rpt, "NoPlat", string.IsNullOrWhiteSpace(noPlat) ? "" : noPlat);
                SetParamEverywhere(rpt, "Status", string.IsNullOrWhiteSpace(status) ? "" : status);

                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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

        private DataTable BuildBAPenghapusanSegelTable(
    DateTime from, DateTime toExcl, string noPlat, string status, string tujuan)
        {
            var sql = @"
SET ARITHABORT ON;
SET NUMERIC_ROUNDABORT OFF;

DECLARE @From DATETIME = @pFrom;
DECLARE @ToExcl DATETIME = @pToExcl;
DECLARE @NoPlat VARCHAR(50) = @pNoPlat;
DECLARE @Status VARCHAR(50) = @pStatus;
DECLARE @Tujuan NVARCHAR(200) = @pTujuan;

SELECT
    r.Tgl_Input,
    r.NoPlat,
    r.UserINPUT  AS UserInput,
    r.UserOUT    AS UserOut,
    r.Tujuan     AS SPBU,
    ca.Segel,
    cb.StatusSegel 
FROM dbo.TblRegister AS r
OUTER APPLY (
    SELECT
        STUFF((
            SELECT ' | ' + CAST(d2.Seal AS varchar(50))
            FROM dbo.TblDetailRegister AS d2
            WHERE d2.NoPlat    = r.NoPlat
              AND d2.Tgl_Input = r.Tgl_Input
              AND NULLIF(LTRIM(RTRIM(d2.Seal)), '') IS NOT NULL
              AND (@Status is not null AND (ISNULL(d2.Status,'') LIKE '%' + @Status + '%'))
            ORDER BY d2.PartID
            FOR XML PATH(''), TYPE
        ).value('.', 'nvarchar(max)'), 1, 3, '') AS Segel
) AS ca
OUTER APPLY (
    SELECT
        STUFF((
            SELECT ' | ' + CAST(d2.[Keterangan] AS varchar(50))
            FROM dbo.TblDetailRegister AS d2
            WHERE d2.NoPlat    = r.NoPlat
              AND d2.Tgl_Input = r.Tgl_Input
              AND (@Status = '' OR ISNULL(d2.[Status],'') LIKE '%' + @Status + '%')
            ORDER BY d2.PartID
            FOR XML PATH(''), TYPE
        ).value('.', 'nvarchar(max)'), 1, 3, '') AS StatusSegel 
) AS cb
WHERE
    r.Tgl_Input >= @From AND r.Tgl_Input < @ToExcl
    AND (@NoPlat = '' OR r.NoPlat = @NoPlat)
    AND (@Tujuan = '' OR (ISNULL(r.Tujuan,'') LIKE '%' + @Tujuan + '%'))
    AND (
    @Status = '' OR EXISTS (                                   -- << key line
        SELECT 1
        FROM dbo.TblDetailRegister AS dx
        WHERE dx.NoPlat    = r.NoPlat
          AND dx.Tgl_Input = r.Tgl_Input
          AND ISNULL(dx.Status,'') LIKE '%' + @Status + '%'
    )
)
ORDER BY r.Tgl_Input, r.NoPlat;";

            var rows = _db.Database.SqlQuery<BAPenghapusanSegelRow>(
                sql,
                new SqlParameter("@pFrom", from),
                new SqlParameter("@pToExcl", toExcl),
                new SqlParameter("@pNoPlat", (noPlat ?? "").Trim()),
                new SqlParameter("@pStatus", (status ?? "").Trim()),
                new SqlParameter("@pTujuan", (tujuan ?? "").Trim())
            ).ToList();

            // make DataTable with stable column names for Crystal
            var dt = new DataTable("BAPenghapusanSegel");
            dt.Columns.Add("Tgl_Input", typeof(DateTime));
            dt.Columns.Add("NoPlat", typeof(string));
            dt.Columns.Add("UserInput", typeof(string));
            dt.Columns.Add("UserOut", typeof(string));
            dt.Columns.Add("SPBU", typeof(string));
            dt.Columns.Add("Segel", typeof(string));
            dt.Columns.Add("StatusSegel", typeof(string));

            foreach (var r in rows)
            {
                dt.Rows.Add(r.Tgl_Input, r.NoPlat ?? "", r.UserInput ?? "", r.UserOut ?? "",
                            r.SPBU ?? "", r.Segel ?? "", r.StatusSegel ?? "");
            }
            return dt;
        }

        public class SealPerStatusPivotRow
        {
            public string NoPlat { get; set; }
            public int N_DIKELUARKAN { get; set; }
            public int N_DIKEMBALIKAN { get; set; }
            public int N_HILANG { get; set; }
            public int N_DIKIRIM { get; set; }
            public int N_OTHER { get; set; }
            public int Total { get; set; }      
        }


        private DataTable BuildSealPerStatusPivotTable(
    DateTime from, DateTime toExcl, string noPlat, string status)
        {
            var sql = @"
SET ARITHABORT ON;
SET NUMERIC_ROUNDABORT OFF;

SELECT
  r.NoPlat,
  SUM(CASE WHEN d.Status='DIKELUARKAN'  THEN 1 ELSE 0 END) AS N_DIKELUARKAN,
  SUM(CASE WHEN d.Status='DIKEMBALIKAN' THEN 1 ELSE 0 END) AS N_DIKEMBALIKAN,
  SUM(CASE WHEN d.Status='HILANG'       THEN 1 ELSE 0 END) AS N_HILANG,
  SUM(CASE WHEN d.Status='DIKIRIM'      THEN 1 ELSE 0 END) AS N_DIKIRIM,
  SUM(CASE WHEN d.Status IS NULL OR d.Status NOT IN ('DIKELUARKAN','DIKEMBALIKAN','HILANG','DIKIRIM') THEN 1 ELSE 0 END) AS N_OTHER,
  COUNT(*) AS Total
FROM dbo.TblRegister r
JOIN dbo.TblDetailRegister d
  ON d.NoPlat=r.NoPlat AND d.Tgl_Input=r.Tgl_Input
WHERE r.Tgl_Input >= @pFrom AND r.Tgl_Input < @pToExcl
  AND (@pNoPlat='' OR r.NoPlat=@pNoPlat)
  AND (@pStatus='' OR ISNULL(d.Status,'') LIKE '%'+@pStatus+'%')
GROUP BY r.NoPlat
ORDER BY r.NoPlat;";

            var rows = _db.Database.SqlQuery<SealPerStatusPivotRow>(
                sql,
                new SqlParameter("@pFrom", from),
                new SqlParameter("@pToExcl", toExcl),
                new SqlParameter("@pNoPlat", (noPlat ?? "").Trim()),
                new SqlParameter("@pStatus", (status ?? "").Trim())
            ).ToList();

            // Build a DataTable that Crystal can bind to
            var dt = new DataTable("SealPerStatusPivot");
            dt.Columns.Add("NoPlat", typeof(string));
            dt.Columns.Add("N_DIKELUARKAN", typeof(int));
            dt.Columns.Add("N_DIKEMBALIKAN", typeof(int));
            dt.Columns.Add("N_HILANG", typeof(int));
            dt.Columns.Add("N_DIKIRIM", typeof(int));
            dt.Columns.Add("N_OTHER", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            foreach (var r in rows)
            {
                dt.Rows.Add(
                    r.NoPlat ?? "",
                    r.N_DIKELUARKAN,
                    r.N_DIKEMBALIKAN,
                    r.N_HILANG,
                    r.N_DIKIRIM,
                    r.N_OTHER,
                    r.Total
                );
            }

            return dt;
        }

        public class KeteranganPivotRow
        {
            public string NoPlat { get; set; }
            public int K_TEPAT_WAKTU { get; set; }
            public int K_TERLAMBAT { get; set; }
            public int K_TELAH_DIKELUARKAN { get; set; }
            public int K_TIDAK_PERNAH_KEMBALI { get; set; }
            public int K_DIKIRIM { get; set; }
            public int Total { get; set; }
        }

        private DataTable BuildKeteranganPivotTable(DateTime from, DateTime toExcl, string noPlat, string status)
        {
            var sql = @"
SET ARITHABORT ON;
SET NUMERIC_ROUNDABORT OFF;

SELECT
  r.NoPlat,
  SUM(CASE WHEN (d.Keterangan LIKE '%TEPAT WAKTU%' AND d.Keterangan not like '%TELAH DIKELUARKAN%')        THEN 1 ELSE 0 END) AS K_TEPAT_WAKTU,
  SUM(CASE WHEN (d.Keterangan LIKE '%TERLAMBAT%'  AND d.Keterangan not like '%TELAH DIKELUARKAN%')        THEN 1 ELSE 0 END) AS K_TERLAMBAT,
  SUM(CASE WHEN d.Keterangan LIKE '%TELAH DIKELUARKAN%'  THEN 1 ELSE 0 END) AS K_TELAH_DIKELUARKAN,
  SUM(CASE WHEN d.Keterangan LIKE '%TIDAK PERNAH KEMBALI%' THEN 1 ELSE 0 END) AS K_TIDAK_PERNAH_KEMBALI,
  SUM(CASE WHEN d.Keterangan is null THEN 1 ELSE 0 END) AS K_DIKIRIM,
  COUNT(*) AS Total
FROM dbo.TblRegister r
JOIN dbo.TblDetailRegister d
  ON d.NoPlat=r.NoPlat AND d.Tgl_Input=r.Tgl_Input
WHERE r.Tgl_Input >= @pFrom AND r.Tgl_Input < @pToExcl
  AND (@pNoPlat='' OR r.NoPlat=@pNoPlat)
  AND (@pStatus='' OR ISNULL(d.Status,'') LIKE '%'+@pStatus+'%')
GROUP BY r.NoPlat
ORDER BY r.NoPlat;";

            var rows = _db.Database.SqlQuery<KeteranganPivotRow>(
                sql,
                new SqlParameter("@pFrom", from),
                new SqlParameter("@pToExcl", toExcl),
                new SqlParameter("@pNoPlat", (noPlat ?? "").Trim()),
                new SqlParameter("@pStatus", (status ?? "").Trim())
            ).ToList();

            var dt = new DataTable("KeteranganPivot"); // <-- table name Crystal will use in the subreport
            dt.Columns.Add("NoPlat", typeof(string));
            dt.Columns.Add("K_TEPAT_WAKTU", typeof(int));
            dt.Columns.Add("K_TERLAMBAT", typeof(int));
            dt.Columns.Add("K_TELAH_DIKELUARKAN", typeof(int));
            dt.Columns.Add("K_TIDAK_PERNAH_KEMBALI", typeof(int));
            dt.Columns.Add("K_DIKIRIM", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            foreach (var r in rows)
                dt.Rows.Add(r.NoPlat ?? "", r.K_TEPAT_WAKTU, r.K_TERLAMBAT, r.K_TELAH_DIKELUARKAN, r.K_TIDAK_PERNAH_KEMBALI, r.K_DIKIRIM, r.Total);

            return dt;
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var rpt = crViewer.ReportSource as ReportDocument;
            if (rpt == null)
            {
                MessageBox.Show("No report to export. Click Preview first.");
                return;
            }

            using (var sfd = new SaveFileDialog
            {
                Title = "Export to Excel",
                Filter = "Excel 97-2003 (*.xls)|*.xls",
                FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.xls"
            })
            {
                if (sfd.ShowDialog(this) != DialogResult.OK) return;

                var di = new DiskFileDestinationOptions { DiskFileName = sfd.FileName };
                var exp = new ExportOptions
                {
                    ExportDestinationType = ExportDestinationType.DiskFile,
                    DestinationOptions = di
                };

                // If you want DATA-ONLY (clean columns) choose ExcelRecord; 
                // if you want layout, choose Excel/ExcelWorkbook depending on extension.
                // Ask the user: Data-only or Keep Layout?
                var choice = MessageBox.Show(
                    "Export to Excel:\n\nYes = Data-only (clean columns, for analysis)\nNo = Keep layout (looks like the report)\nCancel = Abort",
                    "Excel Export",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (choice == DialogResult.Cancel) return;

                bool dataOnly = (choice == DialogResult.Yes);



                if (dataOnly)
                {
                    // -------- Excel (Data Only) - most compatible -------------
                    exp.ExportFormatType = ExportFormatType.ExcelRecord;
                    // NOTE: Many properties differ per runtime; safest is to not set extras.
                    // If your runtime supports it, you can optionally set:
                    // exp.FormatOptions = new ExcelDataOnlyFormatOptions();
                }
                else
                {
                    // -------- Keep layout -------------
                    // Some runtimes don’t have ExcelWorkbook; fall back to Excel (.xls)
                    if (Path.GetExtension(sfd.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            exp.ExportFormatType = ExportFormatType.ExcelWorkbook; // .xlsx
                            var fmt = new ExcelFormatOptions
                            {
                                ExcelTabHasColumnHeadings = true,
                                ShowGridLines = true
                            };
                            exp.FormatOptions = fmt;
                        }
                        catch
                        {
                            exp.ExportFormatType = ExportFormatType.Excel;
                            var fmt = new ExcelFormatOptions
                            {
                                ExcelTabHasColumnHeadings = true,
                                ShowGridLines = true
                            };
                            exp.FormatOptions = fmt;
                        }
                    }
                    else
                    {
                        exp.ExportFormatType = ExportFormatType.Excel; // .xls
                        var fmt = new ExcelFormatOptions
                        {
                            ExcelTabHasColumnHeadings = true,
                            ShowGridLines = true
                        };
                        exp.FormatOptions = fmt;
                    }
                }

                rpt.Export(exp);
                MessageBox.Show("Saved: " + sfd.FileName, "Excel Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxJenisLaporan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
