using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public class TblUser
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TipeUser { get; set; }

        // Navigation
        public ICollection<TblRegister> Registers { get; set; }
    }

}
