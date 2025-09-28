using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblPengiriman")]
    public class TblPengiriman
    {
        [Key, StringLength(30)]
        public string IDPengiriman { get; set; }

        public DateTime? Tgl_Input { get; set; }

        [StringLength(30)]
        public string NoPlat { get; set; }      // FK → TblMobilTangki

        [StringLength(300)]
        public string Tujuan { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(30)]
        public string UserID { get; set; }      // FK → TblUser

        [StringLength(255)]
        public string Keterangan { get; set; }

        // Navigation
        [ForeignKey(nameof(NoPlat))]
        public virtual TblMobilTangki MobilTangki { get; set; }

        [ForeignKey(nameof(UserID))]
        public virtual TblUser User { get; set; }

        public virtual ICollection<TblDetailPengiriman> DetailPengiriman { get; set; } = new HashSet<TblDetailPengiriman>();
    }
}
