using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public class TblTimeSettings
    {
        public int Id { get; set; }
        public string TimeZoneId { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }   // maps to BIT(1)
    }
}
