using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestorantOtomasyonu.Entities
{
    public class Receipt
    {
        public Receipt()
        {
            Orders = new List<Order>();
        }
        public int ReceiptID { get; set; }
        public int Cover { get; set; }
        List<Order> Orders { get; set; }
        public string Date { get; set; }
        public float TotalPrice { get; set; }
        public int TableNumber { get; set; }

    }
}
