using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class BreadRepository : IBreadRepository
    {
        private readonly AppDbContext _appDbContext;

        public BreadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Bread> AllBread
        {
            get
            {
                return _appDbContext.Bread.Include(p => p.Product);
            }
        }


        public Bread GetBreadById(int breadId)
        {
            return _appDbContext.Bread.FirstOrDefault(b => b.BreadId == breadId);
        }
    }
}
