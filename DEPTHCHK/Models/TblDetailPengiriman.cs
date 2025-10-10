using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblDetailPengiriman")]
    public class TblDetailPengiriman
    {
        // Composite PK configured in Fluent API
        [StringLength(30)]
        public string IDPengiriman { get; set; }   // FK → TblPengiriman

        public DateTime? Tgl_Input { get; set; }

        [StringLength(30)]
        public string NoPlat { get; set; }         // denormalized (optional)

        [StringLength(30)]
        public string PartID { get; set; }         // FK → TblDetailMT

        [StringLength(30)]
        public string CompartmentID { get; set; }

        public decimal? DataBacaan { get; set; }   // precision set in Fluent API
        public decimal? DataKalibrasi { get; set; }// precision set in Fluent API

        [StringLength(20)]
        public string Satuan { get; set; }

        [StringLength(255)]
        public string Keterangan { get; set; }

        [StringLength(12)]
        public string KodeTujuan { get; set; }     // FK → TblTujuan

        // Navigation
        [ForeignKey(nameof(IDPengiriman))]
        public virtual TblPengiriman Pengiriman { get; set; }


        [ForeignKey(nameof(PartID))]
        public virtual TblDetailMT DetailMT { get; set; }
    }
}
