using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsSlocBinDetail
    {
        #region properties

        public string SlocBin { get; set; }
        public string ManagementID { get; set; }
        public string ManagementType { get; set; }
        public DateTime tgl { get; set; }
        public string MaterialNumber { get; set; }
        public decimal Qty { get; set; }
        public string BaseUnit { get; set; }
        public string Area { get; set; }
        public string Equipment { get; set; }
        public string Sloc { get; set; }

        #endregion

        #region constructor 

        public ClsSlocBinDetail()
        {

        }

        public ClsSlocBinDetail(string SlocBiNID, string ManagementiD, string ManagementType, DateTime tgl,  string MaterialNUmber, decimal Qty , string BaseUnit, string Area, string Equipment, string Sloc)
        {
            this.SlocBin = SlocBiNID;
            this.ManagementID = ManagementiD;
            this.ManagementType = ManagementType;
            this.tgl = tgl;
            this.MaterialNumber = MaterialNUmber;
            this.Qty = Qty;
            this.BaseUnit = BaseUnit;
            this.Area = Area;
            this.Equipment = Equipment;
            this.Sloc = Sloc;
        }

        #endregion
    }
}
