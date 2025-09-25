using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEALCHK.Model
{
    public sealed class RegionOption
    {
        public int Id { get; set; }        // 1,2,3,...
        public string Name { get; set; }   // "Wilayah Sumatra", ...
        public string Display { get { return Id + ". " + Name; } }
    }

    public sealed class OwnedOption
    {
        public int Id { get; set; }        // 1,3,4
        public string Name { get; set; }   // "COCO", ...
        public string Display { get { return Id + ". " + Name; } }
    }
}

