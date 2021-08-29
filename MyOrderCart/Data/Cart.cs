using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrderCart.Data
{
    
    public class Cart
      
    {
        public Cart(List<Product>productItems)
        {
            this.productItems = productItems;
        }
        public int Id { get; set; }
        public List<Product> productItems;

    }
}
