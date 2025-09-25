using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsSloc
    {
        #region properties

        public string Sloc { get; set; }
        public string Sloc_Type { get; set; }

        


        #endregion

        #region constructor

        public ClsSloc()
        {

        }

        public ClsSloc(string SlocID, string SlocType)
        {
            this.Sloc = SlocID;
            this.Sloc_Type = SlocType;
        }

        #endregion
    }
}
