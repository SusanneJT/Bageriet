using System;
using Xunit;
using Bageriet.Controllers;
using Bageriet.Models;
using Bageriet.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Bageriet.Test
{
    public class TestBreadView
    {

        [Fact]
        public void TestsTheBreadView()
        {

            //Arrange
            IBreadRepository breadRepository = new MockBreadRepository();
            IProductRepository productRepository = new MockProductRepository();
            IRatingRepository ratingRepository = new MockRatingRepository();
            var controller = new BreadController(breadRepository, productRepository, ratingRepository);

            // Act 
            var result = controller.BreadList();
 
            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
