using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;

namespace DEPTHCHK
{
    public static class MaterialTabHelper
    {
        // =======================
        // 🌿 THEME COLORS
        // =======================
        private static readonly Color TabSelectorBackColor = Color.FromArgb(19, 78, 74); // Teal900
        private static readonly Color TabSelectorForeColor = Color.White;
        private static readonly Color TabContentBackColor = Color.FromArgb(12, 24, 22);  // Surface
        private static readonly Color TabContentForeColor = Color.White;
        private static readonly Color AccentColor = Color.FromArgb(249, 115, 22);        // Orange500

        // Font
        private static readonly Font TabFont = new Font("Segoe UI Variable", 10f, FontStyle.Regular);

        // =======================
        // 🧭 APPLY STYLE TO SELECTOR
        // =======================
        public static void StyleTabSelector(MaterialSkin.Controls.MaterialTabSelector selector)
        {
            if (selector == null) return;

            selector.BackColor = TabSelectorBackColor;
            selector.ForeColor = TabSelectorForeColor;
            selector.Font = TabFont;

            if (selector.BaseTabControl != null)
            {
                StyleTabControl(selector.BaseTabControl);
            }

            // Optional: ensure MaterialSkin theme matches
            var skin = MaterialSkinManager.Instance;
            skin.Theme = MaterialSkinManager.Themes.DARK;
            // skin.ColorScheme can also be set globally once in FrmMainMenu if needed.

            selector.Invalidate();
        }

        // =======================
        // 🧭 APPLY STYLE TO TABCONTROL
        // =======================
        public static void StyleTabControl(TabControl tab)
        {
            if (tab == null) return;

            tab.BackColor = TabContentBackColor;
            tab.ForeColor = TabContentForeColor;
            tab.Font = TabFont;

            // Make tabs more spacious and consistent
            tab.DrawMode = TabDrawMode.Normal;
            tab.ItemSize = new Size(tab.ItemSize.Width, 40);
            tab.SizeMode = TabSizeMode.Fixed;

            tab.Invalidate();
        }

        // =======================
        // 🧭 APPLY STYLE TO BOTH (at once)
        // =======================
        public static void ApplyStyle(MaterialSkin.Controls.MaterialTabSelector selector, TabControl tab)
        {
            StyleTabSelector(selector);
            StyleTabControl(tab);
        }
    }
}
