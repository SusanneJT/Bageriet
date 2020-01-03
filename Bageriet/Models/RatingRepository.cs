using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class RatingRepository : IRatingRepository
    {
        private readonly AppDbContext _appDbContext;

        public RatingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Rating> GetAllRatings(int breadId)
        {

            return _appDbContext.Rating.Where(r => r.BreadId == breadId);
        }

        public void CreateRating(Rating rating)
        {

            _appDbContext.Rating.Add(rating);

            _appDbContext.SaveChanges();
        }
    }
}
