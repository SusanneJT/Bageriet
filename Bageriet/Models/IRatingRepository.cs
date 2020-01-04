using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public interface IRatingRepository
    {
        void CreateRating(Rating rating);
        IEnumerable<Rating> GetAllRatings(int breadId);


    }
}
