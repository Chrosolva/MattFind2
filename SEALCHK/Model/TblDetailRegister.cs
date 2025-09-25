using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public class TblDetailRegister
    {
        // composite key: PartID + NoPlat + Tgl_Input
        public string PartID { get; set; }
        public string NoPlat { get; set; }
        public DateTime Tgl_Input { get; set; }

        public string Seal { get; set; }
        public string Status { get; set; }
        public string KodeTujuan { get; set; }
        public string Tujuan { get; set; }
        public DateTime? Tgl_Kirim { get; set; }
        public DateTime? Tgl_Kembali { get; set; }
        public string Keterangan { get; set; }
        public DateTime? Tgl_Keluar { get; set; }

        // navigation references
        public virtual TblRegister Register { get; set; }
        public virtual TblDetailMT DetailMT { get; set; }
    }
}
