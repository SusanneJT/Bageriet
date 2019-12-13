using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class Product
    {
        //Automatic properties for the Product class

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public List<Bread> Bread { get; set; }
    }
}
