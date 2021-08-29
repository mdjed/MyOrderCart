using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrderCart.Data
{
    public class Order
    {
        public string Title { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
