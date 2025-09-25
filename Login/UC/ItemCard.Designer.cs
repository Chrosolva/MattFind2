namespace WBPOS.UC
{
    partial class ItemCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelImage = new System.Windows.Forms.Panel();
            this.PBItemPict = new System.Windows.Forms.PictureBox();
            this.detailpanel = new System.Windows.Forms.Panel();
            this.customNUD1 = new WBPOS.UC.CustomNUD();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBItemPict)).BeginInit();
            this.detailpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.PBItemPict);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(225, 175);
            this.panelImage.TabIndex = 0;
            // 
            // PBItemPict
            // 
            this.PBItemPict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBItemPict.Location = new System.Drawing.Point(0, 0);
            this.PBItemPict.Name = "PBItemPict";
            this.PBItemPict.Size = new System.Drawing.Size(225, 175);
            this.PBItemPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBItemPict.TabIndex = 0;
            this.PBItemPict.TabStop = false;
            this.PBItemPict.Click += new System.EventHandler(this.Item_Card_Click);
            // 
            // detailpanel
            // 
            this.detailpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.detailpanel.Controls.Add(this.customNUD1);
            this.detailpanel.Controls.Add(this.lblPrice);
            this.detailpanel.Controls.Add(this.lblItemName);
            this.detailpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailpanel.Location = new System.Drawing.Point(0, 175);
            this.detailpanel.Name = "detailpanel";
            this.detailpanel.Size = new System.Drawing.Size(225, 71);
            this.detailpanel.TabIndex = 1;
            // 
            // customNUD1
            // 
            this.customNUD1.Location = new System.Drawing.Point(119, 31);
            this.customNUD1.Margin = new System.Windows.Forms.Padding(5);
            this.customNUD1.Name = "customNUD1";
            this.customNUD1.Size = new System.Drawing.Size(98, 30);
            this.customNUD1.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(7, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Item Price";
            this.lblPrice.Click += new System.EventHandler(this.Item_Card_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(7, 10);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(77, 18);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.Click += new System.EventHandler(this.Item_Card_Click);
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailpanel);
            this.Controls.Add(this.panelImage);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(225, 246);
            this.Load += new System.EventHandler(this.ItemCard_Load);
            this.Click += new System.EventHandler(this.Item_Card_Click);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBItemPict)).EndInit();
            this.detailpanel.ResumeLayout(false);
            this.detailpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelImage;
        public System.Windows.Forms.PictureBox PBItemPict;
        private System.Windows.Forms.Panel detailpanel;
        public CustomNUD customNUD1;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblItemName;
    }
}
