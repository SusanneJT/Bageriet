using System;
using Xunit;
using Bageriet.Controllers;
using Bageriet.Models;
using Bageriet.ViewModels;
using System.Collections.Generic;

namespace Bageriet.Test
{
    public class TestBreadView
    {
        private readonly AppDbContext _appDbContext;

        public TestBreadView(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Fact]
        public void TestsTheBreadView()
        {

            //Arrange
            IBreadRepository breadRepository = new MockBreadRepository();
            IProductRepository productRepository = new MockProductRepository();
            IRatingRepository ratingRepository = new RatingRepository(_appDbContext);
            var controller = new BreadController(breadRepository, productRepository, ratingRepository);

            // Act 
            var result = controller.BreadList();
 
            // Assert
            Assert.NotNull(result);
        }
    }
}
