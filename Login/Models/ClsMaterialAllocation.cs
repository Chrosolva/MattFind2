using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsMaterialAllocation
    {
        #region properties

        public string ManagementID { get; set; }
        public string MaterialNumber { get; set; }
        public string Reference { get; set; }
        public decimal Qty { get; set; }
        public string Sloc { get; set; }

        #endregion

        #region constructor

        public ClsMaterialAllocation()
        {

        }

        public ClsMaterialAllocation(string ManagementID, string Materialnumber, string reference ,decimal qty, string Sloc)
        {
            this.ManagementID = ManagementID;
            this.MaterialNumber = Materialnumber;
            this.Reference = reference;
            this.Qty = qty;
            this.Sloc = Sloc;
        }

        #endregion

    }
}
