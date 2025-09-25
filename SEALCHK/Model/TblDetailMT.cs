using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public class TblDetailMT
    {
        [Key]
        [StringLength(50)]
        public string PartID { get; set; }           // PK

        [StringLength(30)]
        public string NoPlat { get; set; }           // FK -> TblMobilTangki.NoPlat

        [StringLength(50)]
        public string SealCode { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public decimal? Capacity { get; set; }       // decimal(18,0) in your diagram
        public int? PartIndex { get; set; }

        // navigation
        public virtual TblMobilTangki MobilTangki { get; set; }

        // NEW: detail registers collection
        public virtual ICollection<TblDetailRegister> DetailRegisters { get; set; }
    }
}
