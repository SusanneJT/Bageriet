using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public interface IDbContext
    {
       DbSet<Product> Products { get; }
       DbSet<Bread> Bread { get; }
    }
}
