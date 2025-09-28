using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblMobilTangki")]
    public class TblMobilTangki
    {
        [Key, StringLength(30)]
        public string NoPlat { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        public int? JlhCompartment { get; set; }
        public decimal? Capacity { get; set; }

        public virtual ICollection<TblDetailMT> DetailMTs { get; set; } = new HashSet<TblDetailMT>();
        public virtual ICollection<TblPengiriman> Pengiriman { get; set; } = new HashSet<TblPengiriman>();
    }
}
