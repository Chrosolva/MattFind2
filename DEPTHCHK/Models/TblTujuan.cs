using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblTujuan")]
    public class TblTujuan
    {
        [Key, StringLength(12)]
        public string KodeTujuan { get; set; }

        [StringLength(255)]
        public string NamaSPBU { get; set; }
        [StringLength(500)]
        public string AlamatSPBU { get; set; }
        [StringLength(2)]
        public string KodeRegional { get; set; }
        [StringLength(1)]
        public string KodeKepemilikan { get; set; }
        [StringLength(100)]
        public string NamaRegional { get; set; }
        [StringLength(255)]
        public string NamaKepemilikan { get; set; }
    }
}
