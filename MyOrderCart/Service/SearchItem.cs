using MyOrderCart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyOrderCart.Service
{
    public class SearchItem : ISearchItem
    {
        private readonly Product product;
        public IEnumerable<Product> Execute(string filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
