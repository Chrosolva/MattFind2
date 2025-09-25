using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEALCHK.Model
{
    public class TblTujuan
    {
        // composite key: NoPlat + Tgl_Input
        [Key]
        [StringLength(12)]
        public string KodeTujuan { get; set; } // KEY

        [StringLength(255)]
        public string NamaSPBU { get; set; }

        [StringLength(255)]
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
