using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public interface IBreadRepository
    {
        IEnumerable<Bread> AllBread { get; }
    }
}
