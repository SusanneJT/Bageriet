using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public interface IRatingRepository
    {
        void CreateRating(Rating rating);

        //Get all ratings for the specified bread, the name on this method could be better
        IEnumerable<Rating> GetAllRatings(int breadId);


    }
}
