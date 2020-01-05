using System;
using Xunit;
using Bageriet.Controllers;
using Bageriet.Models;
using Bageriet.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Bageriet.Test
{
    public class TestRateController
    {

        [Fact]
        public void TestRateBread()
        {

            //Arrange
            IBreadRepository breadRepository = new MockBreadRepository();
            IRatingRepository ratingRepository = new MockRatingRepository();
            var controller = new RatingController(ratingRepository, breadRepository);

            Rating testRating = new Rating();
            

            // Act 
            var result = controller.RateBread(testRating, 1);

 
            // Assert
            Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
