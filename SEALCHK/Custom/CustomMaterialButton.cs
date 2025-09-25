using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SEALCHK.Custom
{
    public class CustomMaterialButton : MaterialButton
    {
        private Color customColor = Color.Green; // default green

        [Category("Appearance")]
        [Description("Sets the background color of the button.")]
        public Color CustomColor
        {
            get { return customColor; }
            set
            {
                customColor = value;
                this.Invalidate(); // refresh when changed
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Fill background with custom color
            using (var brush = new SolidBrush(CustomColor))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Draw text centered
            TextRenderer.DrawText(
                e.Graphics,
                this.Text,
                this.Font,
                this.ClientRectangle,
                Color.White, // text color
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
