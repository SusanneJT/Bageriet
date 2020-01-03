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
        [Fact]
        public void TestsTheBreadView()
        {
            //Arrange
            IBreadRepository breadRepository = new MockBreadRepository();
            IProductRepository productRepository = new MockProductRepository();
            var controller = new BreadController(breadRepository, productRepository);

            // Act 
            var result = controller.BreadList();
 
            // Assert
            Assert.NotNull(result);
        }
    }
}
