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

        [Required, StringLength(30)]
        public string NoPlat { get; set; }

        [Column(TypeName = "char"), StringLength(4)]
        public string RfidData { get; set; } // NEW: 4‑char RFID (two bytes)

        [StringLength(300)]
        public string Tujuan { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(30)]
        public string UserID { get; set; }

        [StringLength(255)]
        public string Keterangan { get; set; }

        [ForeignKey(nameof(UserID))]
        public virtual TblUser User { get; set; }

        public virtual ICollection<TblDetailPengiriman> DetailPengiriman { get; set; }
            = new HashSet<TblDetailPengiriman>();
    }

}
