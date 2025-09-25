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
    public partial class ItemCard : UserControl
    {
        #region properties

        public string name;
        public int qty;
        public string ID;
        public Image img;
        public decimal price;
        public string KodeKategori;
        public string desc;

        #endregion

        public ItemCard()
        {
            InitializeComponent();
        }

        public ItemCard(string name, decimal price, Image image, string ID, int qty, string desc, string kodekategori)
        {
            this.name = name;
            this.desc = desc;
            this.price = price;
            this.img = image;
            this.ID = ID;
            this.qty = qty;
            this.KodeKategori = kodekategori;
            
            InitializeComponent();
        }

        public void Item_Card_Click(object sender, EventArgs e)
        {
            customNUD1.numericUpDown1.Focus();
            customNUD1.numericUpDown1.Select(0, customNUD1.numericUpDown1.Text.Length);
        }

        private void ItemCard_Load(object sender, EventArgs e)
        {
            this.lblItemName.Text = this.name;
            this.lblPrice.Text = string.Format("{0:C}", this.price);
            this.PBItemPict.Image = this.img;
            this.customNUD1.numericUpDown1.Value = this.qty;
            this.customNUD1.numericUpDown1.ValueChanged += Valuechanged;
        }

        public void Valuechanged (object sender, EventArgs e)
        {
            this.qty = Convert.ToInt32(customNUD1.numericUpDown1.Value);
        }
    }
}
