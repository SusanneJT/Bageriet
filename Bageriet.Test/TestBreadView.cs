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
        public void TestsTheMockBreadRepository()
        {
            //Arrange
            IBreadRepository breadRepository = new MockBreadRepository();

            //Act
            int breadCount = (breadRepository.AllBread as List<Bread>).Count;

            //Assert
            Assert.NotEqual(0, breadCount);


        }
    }
}
