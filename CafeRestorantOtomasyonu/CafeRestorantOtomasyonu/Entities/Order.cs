using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestorantOtomasyonu.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductCount { get; set; }
        public  Product Product { get; set; }
        public string Information { get; set; }
        public bool isAlive{ get; set; }
        public int TableNumber { get; set; }
        public Receipt Receipt { get; set; }
    }
}
