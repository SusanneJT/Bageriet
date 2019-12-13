using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class MockBreadRepository : IBreadRepository
    {
        private readonly IProductRepository _productRepository = new MockProductRepository();

        public IEnumerable<Bread> AllBread =>
            new List<Bread>
            {
                new Bread {BreadId = 1, Name="Rågbröd", Price=15.95M, ShortDescription="Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.", ImageUrl="/Images/bread1.jpg"},
                new Bread {BreadId = 2, Name="Höstbröd", Price=12.50M, ShortDescription="Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.", ImageUrl="/Images/bread2.jpg"},
                new Bread {BreadId = 3, Name="Fröbröd", Price=12.50M, ShortDescription="Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.", ImageUrl="/Images/bread3.jpg"},
                new Bread {BreadId = 4, Name="Baguette", Price=9.50M, ShortDescription="Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.", ImageUrl="/Images/bread4.jpg"}
            };

    }
}
