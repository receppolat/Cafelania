using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestorantOtomasyonu.Entities
{
    public class Cafe
    {
        public int CafeID{ get; set; }
        public int TableCount { get; set; }
        public string CafeEntry { get; set; }
        public string CafeLoginKey { get; set; }

    }
}
