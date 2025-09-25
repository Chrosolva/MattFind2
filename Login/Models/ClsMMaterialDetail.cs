using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsMMaterialDetail
    {
        #region properties

        public string ManagementID { get; set; }
        public int NoUrut { get; set; }
        public string MaterialNumber { get; set; }
        public decimal Qty { get; set; }
        public string BaseUnit { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; }
        public string Sloc { get; set; }
        public string Reference { get; set; }

        #endregion

        #region constructor

        public ClsMMaterialDetail()
        {
            
        }

        public ClsMMaterialDetail(string ManagementID, int NoUrut, string MaterialNUmber, decimal Qty, string BaseUnit)
        {
            this.ManagementID = ManagementID;
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNUmber;
            this.Qty = Qty;
            this.BaseUnit = BaseUnit;
        }

        public ClsMMaterialDetail(string ManagementID, int NoUrut, string MaterialNUmber, decimal Qty, string BaseUnit, decimal Value, string Sloc)
        {
            this.ManagementID = ManagementID;
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNUmber;
            this.Qty = Qty;
            this.BaseUnit = BaseUnit;
            this.Value = Value;
            this.Sloc = Sloc;
        }

        public ClsMMaterialDetail(string ManagementID, int NoUrut, string MaterialNUmber, decimal Qty, string BaseUnit, decimal Value, string Status, string Sloc)
        {
            this.ManagementID = ManagementID;
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNUmber;
            this.Qty = Qty;
            this.BaseUnit = BaseUnit;
            this.Value = Value;
            this.Status = Status;
            this.Sloc = Sloc;
        }

        public ClsMMaterialDetail(string ManagementID, int NoUrut, string MaterialNUmber, decimal Qty, string BaseUnit, decimal Value, string Status, string Sloc, string Reference)
        {
            this.ManagementID = ManagementID;
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNUmber;
            this.Qty = Qty;
            this.BaseUnit = BaseUnit;
            this.Value = Value;
            this.Status = Status;
            this.Sloc = Sloc;
            this.Reference = Reference;
        }

        #endregion


    }
}
