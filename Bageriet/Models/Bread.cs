using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class Bread
    {
        public int BreadId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
