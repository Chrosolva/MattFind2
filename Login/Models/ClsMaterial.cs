using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsMaterial
    {
        public string MaterialNumber { get; set; }
        public string MaterialDescription { get; set; }
        public decimal Qty { get; set; }
        public string BaseUnit { get; set; }
        public bool Status { get; set; }
        public decimal Value { get; set; }
        public string DocumentHeaderText { get; set; }
        public string FilePath { get; set; }

        #region constructor

        public ClsMaterial()
        {

        }

        public ClsMaterial(string MaterialNumber, string MaterialDesc, decimal qty, string Baseunit, bool Status, decimal value, string DocumentHeaderText)
        {
            this.MaterialNumber = MaterialNumber;
            this.MaterialDescription = MaterialDesc;
            this.Qty = qty;
            this.BaseUnit = Baseunit;
            this.Status = Status;
            this.Value = value;
            this.DocumentHeaderText = DocumentHeaderText;
        }

        public ClsMaterial(string MaterialNumber, string MaterialDesc, decimal qty, string Baseunit, bool Status, decimal value, string DocumentHeaderText, string ImagePath)
        {
            this.MaterialNumber = MaterialNumber;
            this.MaterialDescription = MaterialDesc;
            this.Qty = qty;
            this.BaseUnit = Baseunit;
            this.Status = Status;
            this.Value = value;
            this.DocumentHeaderText = DocumentHeaderText;
            this.FilePath = ImagePath;
        }

        #endregion
    }
}
