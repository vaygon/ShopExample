using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication_Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sku { get; set; }

        public virtual List<Price> Prices { get; set; } 

    }

    public class Price
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }
    }
}
