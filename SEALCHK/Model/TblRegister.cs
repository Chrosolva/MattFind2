using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public class TblRegister
    {
        // composite key: NoPlat + Tgl_Input
        public string NoPlat { get; set; }
        public DateTime Tgl_Input { get; set; }

        public string Tujuan { get; set; }
        public string Status { get; set; }
        public string UserINPUT { get; set; }
        public string UserOUT { get; set; }

        // navigation references
        public virtual TblMobilTangki MobilTangki { get; set; }
        public virtual TblUser User { get; set; }

        public virtual ICollection<TblDetailRegister> DetailRegisters { get; set; }
    }
}
