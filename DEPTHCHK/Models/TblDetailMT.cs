using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblDetailMT")]
    public class TblDetailMT
    {
        [Key, StringLength(30)]
        public string PartID { get; set; }

        [Required, StringLength(30)]
        public string NoPlat { get; set; }  // FK → TblMobilTangki

        public int? Kalibrasi { get; set; }
        public bool? Positive { get; set; }

        [ForeignKey("NoPlat")]
        public virtual TblMobilTangki MobilTangki { get; set; }

        public virtual ICollection<TblDetailPengiriman> DetailPengiriman { get; set; } = new HashSet<TblDetailPengiriman>();
    }
}
