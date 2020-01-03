using Bageriet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.ViewModels
{
    public class BreadDetailsView
    { 
        public Bread Bread { get; set;}
        public IEnumerable<Rating> Ratings { get; set; }
        public Double AvarageGrade { get; set; }
    }
}
