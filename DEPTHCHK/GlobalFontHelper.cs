using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DEPTHCHK
{
    public static class GlobalFontHelper
    {
        public sealed class AppFonts
        {
            public Font Body;
            public Font Header;
        }

        // 1) Choose from built-ins (no install): Segoe UI Variable (Win11), Calibri, Tahoma, Segoe UI
        private static readonly string[] PreferredFamilies = new string[]
        {
            "Segoe UI Variable", "Calibri", "Tahoma", "Segoe UI"
        };

        /// Resolve the first available family and build Body/Header fonts
        public static AppFonts Resolve(float bodySize, float headerSize, FontStyle headerStyle)
        {
            string chosen = null;

            foreach (string fam in PreferredFamilies)
            {
                try
                {
                    using (Font probe = new Font(fam, bodySize, FontStyle.Regular))
                    {
                        if (string.Equals(probe.Name, fam, StringComparison.OrdinalIgnoreCase))
                        {
                            chosen = fam;
                            break;
                        }
                    }
                }
                catch { /* keep trying */ }
            }

            if (chosen == null) chosen = SystemFonts.MessageBoxFont.Name;

            AppFonts set_ = new AppFonts();
            set_.Body = new Font(chosen, bodySize, FontStyle.Regular);
            set_.Header = new Font(chosen, headerSize, headerStyle);
            return set_;
        }

        /// Apply fonts to a Form (or any container control) recursively
        public static void Apply(Control root, AppFonts fonts)
        {
            if (root == null || fonts == null) return;

            // Set the form's base font so late-created controls inherit it
            try { root.Font = fonts.Body; } catch { }

            // Walk the tree
            ApplyToControlTree(root, fonts);

            // Special: ContextMenuStrips not attached to the tree yet
            Form f = root as Form;
            if (f != null)
            {
                if (f.ContextMenuStrip != null)
                    ApplyToToolStrip(f.ContextMenuStrip, fonts);

                // ToolStrips in the form (MenuStrip/StatusStrip/ToolStrip)
                foreach (Control c in f.Controls)
                {
                    ToolStrip ts = c as ToolStrip;
                    if (ts != null) ApplyToToolStrip(ts, fonts);
                }
            }
        }

        private static void ApplyToControlTree(Control c, AppFonts fonts)
        {
            if (c == null) return;

            // Heuristic: headers (GroupBox, TabPage) use header font
            if (c is GroupBox || c is TabPage)
            {
                TrySetFont(c, fonts.Header);
            }
            else
            {
                TrySetFont(c, fonts.Body);
            }

            // DataGridView needs special handling for headers/cells
            DataGridView dgv = c as DataGridView;
            if (dgv != null)
            {
                TrySetFont(dgv, fonts.Body);
                if (dgv.ColumnHeadersDefaultCellStyle != null)
                {
                    dgv.ColumnHeadersDefaultCellStyle.Font = fonts.Header;
                }
                if (dgv.RowHeadersDefaultCellStyle != null)
                {
                    dgv.RowHeadersDefaultCellStyle.Font = fonts.Body;
                }
                if (dgv.DefaultCellStyle != null)
                {
                    dgv.DefaultCellStyle.Font = fonts.Body;
                }
            }

            // ToolStrip inside a panel/card/etc.
            ToolStrip ts = c as ToolStrip;
            if (ts != null)
            {
                ApplyToToolStrip(ts, fonts);
            }

            // Recurse
            foreach (Control child in c.Controls)
            {
                ApplyToControlTree(child, fonts);
            }
        }

        private static void ApplyToToolStrip(ToolStrip ts, AppFonts fonts)
        {
            if (ts == null || fonts == null) return;
            TrySetFont(ts, fonts.Body);

            foreach (ToolStripItem it in ts.Items)
            {
                // Heuristic: top-level menu headers look better as Header font
                if (it is ToolStripMenuItem && ((ToolStripMenuItem)it).OwnerItem == null)
                {
                    TrySetItemFont(it, fonts.Header);
                }
                else
                {
                    TrySetItemFont(it, fonts.Body);
                }

                // Submenus
                ToolStripMenuItem mi = it as ToolStripMenuItem;
                if (mi != null && mi.DropDown != null)
                {
                    TrySetFont(mi.DropDown, fonts.Body);
                    foreach (ToolStripItem sub in mi.DropDown.Items)
                    {
                        TrySetItemFont(sub, fonts.Body);
                    }
                }
            }
        }

        private static void TrySetFont(Control c, Font f)
        {
            try { c.Font = f; } catch { }
        }

        private static void TrySetItemFont(ToolStripItem i, Font f)
        {
            try { i.Font = f; } catch { }
        }
    }
}
