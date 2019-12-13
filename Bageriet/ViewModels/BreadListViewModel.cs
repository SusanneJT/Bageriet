using Bageriet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.ViewModels
{
    public class BreadListViewModel
    {
        public IEnumerable<Bread> Bread { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}

