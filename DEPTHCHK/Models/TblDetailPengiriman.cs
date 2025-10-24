using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblDetailPengiriman")]
    public class TblDetailPengiriman
    {
        // Composite key is configured in Fluent API (IDPengiriman + PartID)
        [StringLength(30)]
        public string IDPengiriman { get; set; }

        public DateTime? Tgl_Input { get; set; }

        [Required, StringLength(30)]
        public string NoPlat { get; set; }

        [StringLength(30)]
        public string PartID { get; set; } // FK → TblDetailMT

        public int? DataBacaan { get; set; }
        public int? DataKalibrasi { get; set; }

        [StringLength(20)]
        public string Satuan { get; set; }

        [StringLength(255)]
        public string Keterangan { get; set; }
        public decimal? Suhu { get; set; }

        [ForeignKey(nameof(IDPengiriman))]
        public virtual TblPengiriman Pengiriman { get; set; }

        [ForeignKey(nameof(PartID))]
        public virtual TblDetailMT DetailMT { get; set; }
    }

}
