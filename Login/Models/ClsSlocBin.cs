using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsSlocBin
    {
        #region properties

        public string SlocBin { get; set; }
        public string Sloc { get; set; }
        public bool Is_Full { get; set; }

        public bool still_available { get; set;} 
        public bool Is_Empty { get; set; }

        public List<ClsSlocBinDetail> listSlocBInDetail = new List<ClsSlocBinDetail>();

        #endregion

        #region constructor

        public ClsSlocBin()
        {

        }

        public ClsSlocBin(string SlocBInID, string SlocID, bool isfull, bool stillavailable , bool isempty)
        {
            this.SlocBin = SlocBInID;
            this.Sloc = SlocID;
            this.Is_Full = isfull;
            this.still_available = stillavailable;
            this.Is_Empty = isempty;
        }

        public ClsSlocBin(string SlocBInID, string SlocID, bool isfull, bool stillavailable, bool isempty, List<ClsSlocBinDetail> listSlocBinDetail)
        {
            this.SlocBin = SlocBInID;
            this.Sloc = SlocID;
            this.Is_Full = isfull;
            this.still_available = stillavailable;
            this.Is_Empty = isempty;
            this.listSlocBInDetail = listSlocBinDetail;
        }

        #endregion
    }
}
