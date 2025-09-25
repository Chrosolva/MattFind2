using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public class TblMobilTangki
    {
        [Key]
        [StringLength(30)]
        public string NoPlat { get; set; }           // PK

        [StringLength(255)]
        public string Type { get; set; }

        public int? JlhCompartment { get; set; }
        public int? CoverBoxPanel { get; set; }

        [StringLength(20)]
        public string DetailStatus { get; set; }

        // navigation
        public virtual ICollection<TblDetailMT> Details { get; set; }

        // NEW: one MobilTangki → many TblRegister
        public virtual ICollection<TblRegister> Registers { get; set; } 
    }
}
