using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEALCHK.UserControls
{
    public partial class UCTujuan : UserControl
    {
        public int Index { get; set; } // 0-based slot index

        public string KodeTujuan
        {
            get { return txtKodeTujuan.Text?.Trim(); }
            set { txtKodeTujuan.Text = value ?? string.Empty; }
        }

        public string NamaSPBU
        {
            get { return lblNamaSPBU.Text; } // if you used a Label, return lblNamaSPBU.Text
            set { lblNamaSPBU.Text = value; } // or lblNamaSPBU.Text = value;
        }

        public event EventHandler SelectRequested;

        public UCTujuan()
        {
            InitializeComponent();
            btnSel.Click += (s, e) => { if (SelectRequested != null) SelectRequested(this, EventArgs.Empty); };
        }

        public void Highlight(bool on)
        {
            this.BackColor = on ? System.Drawing.Color.FromArgb(235, 247, 255) : System.Drawing.Color.Transparent;
        }
    }

}
