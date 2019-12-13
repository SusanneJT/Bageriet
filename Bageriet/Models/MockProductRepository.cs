using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class MockProductRepository: IProductRepository
    {
        public IEnumerable<Product> AllProducts =>


        new List<Product>
        {
            new Product{ProductId=1, ProductName="Bröd", Description="Nybakat bröd som passar lika bra till frukost som till lunch"},
        };
    }
}
