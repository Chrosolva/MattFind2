using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEPTHCHK.Models
{
    [Table("TblUser")]
    public class TblUser
    {
        [Key, StringLength(30)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(355)]
        public string Password { get; set; }
        [StringLength(30)]
        public string TipeUser { get; set; }

        // Navigation
        public virtual ICollection<TblPengiriman> Pengiriman { get; set; } = new HashSet<TblPengiriman>();
    }
}
