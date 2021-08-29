using MyOrderCart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrderCart.Service
{
    public interface ISearchItem
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
