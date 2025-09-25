using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBPOS.UC
{
    public partial class OrderBar : UserControl
    {

        #region properties

        public string name;
        public int qty;
        public string ID;
        public decimal price;
        public string KodeKategori;
        public string desc;

        #endregion

        public OrderBar()
        {
            InitializeComponent();
        }

        public OrderBar(string ID, string name, int qty, decimal price, string kodeKategori, string desc)
        {
            InitializeComponent();
            this.ID = ID;
            this.name = name;
            this.qty = qty;
            this.price = price;
            this.KodeKategori = kodeKategori;
            this.desc = desc;
        }
    }
}
