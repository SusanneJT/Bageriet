using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class MockRatingRepository : IRatingRepository
    {
        public IEnumerable<Rating> Ratings =>
            new List<Rating>
            {
                new Rating {RatingId = 1, BreadId = 1, Email = "Test@mail.com", Grade = 4, Comment = "Comment", AuthorName = "Testperson"},
                new Rating {RatingId = 2, BreadId = 1, Email = "Test2@mail.com", Grade = 3, Comment = "Comment2", AuthorName = "Testperson2"},
                new Rating {RatingId = 3, BreadId = 2, Email = "Test3@mail.com", Grade = 5, Comment = "Comment3", AuthorName = "Testperson3"}

            };

        public void CreateRating(Rating rating)
        {
            
        }
        public IEnumerable<Rating> GetAllRatings(int breadId)
        {
            return Ratings.Where(r => r.BreadId == breadId);
        }
    }
}
