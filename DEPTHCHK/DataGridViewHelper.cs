using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DEPTHCHK
{
    public static class DataGridViewHelper
    {
        // ------------ THEME MODEL ------------
        public sealed class GridTheme
        {
            public Color Surface;            // grid background
            public Color SurfaceAlt;         // alternating rows
            public Color TextPrimary;
            public Color TextSecondary;
            public Color HeaderBack;
            public Color HeaderText;
            public Color GridLines;
            public Color SelectionBack;
            public Color SelectionText;
            public Color ReadonlyBack;       // read-only cell background
            public Color ReadonlyHeaderBack; // read-only header background
            public Color Accent;             // accent (focus border)
            public Font BodyFont;
            public Font HeaderFont;

            // Row-header (left strip)
            public Color RowHeaderBack;
            public Color RowHeaderText;
            public Color RowHeaderSelectBack;
        }

        // ------------ TEAL + ORANGE (DARK) ------------
        public static readonly GridTheme TealOrangeDark = new GridTheme
        {
            // Teal700 #0F766E, Teal900 #134E4A, Orange500 #F97316
            Surface = Color.FromArgb(12, 24, 22),       // deep teal charcoal
            SurfaceAlt = Color.FromArgb(16, 32, 30),
            TextPrimary = Color.FromArgb(230, 240, 238),
            TextSecondary = Color.FromArgb(170, 186, 182),
            HeaderBack = Color.FromArgb(19, 78, 74),        // Teal900
            HeaderText = Color.White,
            GridLines = Color.FromArgb(28, 54, 51),
            SelectionBack = Color.FromArgb(151, 249, 115, 22), // A=151 over Orange500
            SelectionText = Color.White,
            ReadonlyBack = Color.FromArgb(24, 48, 45),
            ReadonlyHeaderBack = Color.FromArgb(15, 118, 110),      // Teal700
            Accent = Color.FromArgb(249, 115, 22),      // Orange500
            BodyFont = new Font("Segoe UI", 10f, FontStyle.Regular),
            HeaderFont = new Font("Segoe UI", 10f, FontStyle.Bold),

            // Row header colors
            RowHeaderBack = Color.FromArgb(19, 78, 74),        // Teal900 (same as header)
            RowHeaderText = Color.White,
            RowHeaderSelectBack = Color.FromArgb(24, 48, 45)         // a hair darker than surface
        };

        // ------------ PUBLIC API (old-call compatible) ------------

        // Original simple signature
        public static void ApplyDefaultStyle(DataGridView dgv)
        {
            ApplyDefaultStyleInternal(dgv, TealOrangeDark, true, false);
        }

        // Original signature with flags
        public static void ApplyDefaultStyle(DataGridView dgv, bool readOnly = true, bool multiSelect = false)
        {
            ApplyDefaultStyleInternal(dgv, TealOrangeDark, readOnly, multiSelect);
        }

        // Themed version with a different name to avoid overload ambiguity
        public static void ApplyDefaultStyleThemed(DataGridView dgv, GridTheme theme, bool readOnly = true, bool multiSelect = false)
        {
            if (theme == null) theme = TealOrangeDark;
            ApplyDefaultStyleInternal(dgv, theme, readOnly, multiSelect);
        }

        public static void FitOnceThenUnlock(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.MinimumWidth = 60;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public static void StyleReadOnlyColumns(DataGridView dgv, params string[] columnNames)
        {
            StyleReadOnlyColumns(dgv, TealOrangeDark, columnNames);
        }

        public static void StyleReadOnlyColumns(DataGridView dgv, GridTheme theme, params string[] columnNames)
        {
            if (dgv == null || theme == null || dgv.Columns.Count == 0 || columnNames == null) return;

            foreach (string name in columnNames)
            {
                if (!dgv.Columns.Contains(name)) continue;

                DataGridViewColumn col = dgv.Columns[name];
                col.ReadOnly = true;
                col.DefaultCellStyle.BackColor = theme.ReadonlyBack;
                col.DefaultCellStyle.ForeColor = theme.TextSecondary;

                if (!string.IsNullOrEmpty(col.HeaderText) && col.HeaderText.IndexOf("🔒", StringComparison.Ordinal) < 0)
                {
                    col.HeaderText = "🔒 " + col.HeaderText;
                }

                Font baseFont = dgv.DefaultCellStyle.Font ?? new Font("Segoe UI", 10f, FontStyle.Regular);
                col.DefaultCellStyle.Font = new Font(baseFont, FontStyle.Italic);
            }
        }

        // ------------ INTERNAL CORE ------------

        private static void ApplyDefaultStyleInternal(DataGridView dgv, GridTheme theme, bool readOnly, bool multiSelect)
        {
            if (dgv == null) return;
            if (theme == null) theme = TealOrangeDark;

            dgv.SuspendLayout();

            // General Appearance
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = theme.BodyFont;
            dgv.BackgroundColor = theme.Surface;
            dgv.GridColor = theme.GridLines;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersWidth = 28;
            dgv.RowTemplate.Height = 28;
            dgv.ColumnHeadersHeight = 34;
            dgv.MultiSelect = multiSelect;
            dgv.ScrollBars = ScrollBars.Both;

            // Header Style
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.HeaderBack;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.HeaderText;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme.HeaderBack;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = theme.HeaderText;
            dgv.ColumnHeadersDefaultCellStyle.Font = theme.HeaderFont;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Row Style
            dgv.DefaultCellStyle.BackColor = theme.Surface;
            dgv.DefaultCellStyle.ForeColor = theme.TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = theme.SelectionBack;
            dgv.DefaultCellStyle.SelectionForeColor = theme.SelectionText;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = theme.SurfaceAlt;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = theme.TextPrimary;

            // Row header (left strip)
            dgv.RowHeadersVisible = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersDefaultCellStyle.BackColor = theme.RowHeaderBack;
            dgv.RowHeadersDefaultCellStyle.ForeColor = theme.RowHeaderText;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = theme.RowHeaderSelectBack;
            dgv.RowHeadersDefaultCellStyle.SelectionForeColor = theme.RowHeaderText;

            if (dgv.TopLeftHeaderCell != null)
            {
                dgv.TopLeftHeaderCell.Style.BackColor = theme.RowHeaderBack;
                dgv.TopLeftHeaderCell.Style.ForeColor = theme.RowHeaderText;
            }

            // Grid Lines
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = theme.GridLines;

            // Behavior
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ReadOnly = readOnly;
            dgv.EditMode = readOnly ? DataGridViewEditMode.EditProgrammatically
                                    : DataGridViewEditMode.EditOnEnter;

            // Focus cue (accent outline) — C# 5/6 friendly
            AttachFocusCueHandlers(dgv, theme);

            // Performance
            EnableDoubleBuffering(dgv);

            dgv.ResumeLayout(true);
        }

        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            try
            {
                typeof(DataGridView).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, dgv, new object[] { true });
            }
            catch
            {
                // ignore on runtimes that disallow it
            }
        }

        // Store handler references so we don't add duplicates if ApplyDefaultStyle is called again
        private class FocusHandlers
        {
            public PaintEventHandler PaintHandler;
            public EventHandler FocusHandler;
        }

        private static void AttachFocusCueHandlers(DataGridView dgv, GridTheme theme)
        {
            // Reuse Tag slot only if it's ours
            FocusHandlers fh = dgv.Tag as FocusHandlers;
            if (fh != null)
                return;

            fh = new FocusHandlers();

            fh.PaintHandler = delegate (object sender, PaintEventArgs e)
            {
                if (dgv.Focused || dgv.ContainsFocus)
                {
                    using (Pen pen = new Pen(theme.Accent, 2))
                    {
                        Rectangle r = dgv.ClientRectangle;
                        r.Width -= 1; r.Height -= 1;
                        e.Graphics.DrawRectangle(pen, r);
                    }
                }
            };

            fh.FocusHandler = delegate (object sender, EventArgs e)
            {
                dgv.Invalidate();
            };

            dgv.Paint += fh.PaintHandler;
            dgv.GotFocus += fh.FocusHandler;
            dgv.LostFocus += fh.FocusHandler;

            if (dgv.Tag == null || dgv.Tag is FocusHandlers)
                dgv.Tag = fh;

            dgv.Disposed += delegate
            {
                try { dgv.Paint -= fh.PaintHandler; } catch { }
                try { dgv.GotFocus -= fh.FocusHandler; } catch { }
                try { dgv.LostFocus -= fh.FocusHandler; } catch { }
            };
        }
    }
}
