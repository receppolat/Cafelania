using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestorantOtomasyonu.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Category Category { get; set; } //HERE IS FOR CATEGORY TABLE
        public float Amount { get; set; }
    }
}
