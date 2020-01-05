using System;
using Xunit;
using Bageriet.Controllers;
using Bageriet.Models;
using Bageriet.ViewModels;
using System.Collections.Generic;

namespace Bageriet.Test
{
    public class TestMockRatingRepository
    {
        [Fact]
        public void TestsTheMockRatingRepository()
        {
            //Arrange
            IRatingRepository ratingRepository = new MockRatingRepository();

            
            //Act
            IEnumerable<Rating> mockRatings = ratingRepository.GetAllRatings(1);
            //GetAllRatings fetches all the ratings for bread where breadId == 1
            int countRatings = 0;
            foreach (var rating in mockRatings)
            {
                countRatings++;
            }

            //Assert
            Assert.NotEqual(0, countRatings);

        }
    }
}
