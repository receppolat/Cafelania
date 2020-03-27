using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CafeRestorantOtomasyonu.Entities;

namespace CafeRestorantOtomasyonu.DbContexts
{
    public class CafeContext:DbContext
    {
        public CafeContext(): base(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=CafeDB;Integrated Security=True"){ }
        public DbSet<Product>Products{get; set;}
        public DbSet<Category>Categories{get; set;}
        public DbSet<Order>Orders{get; set;}
        public DbSet<Receipt>Receipts{get; set;}
        public DbSet<Personal>Personals{get; set;}
        public DbSet<Cafe> Cafe { get; set; }
    }
}
