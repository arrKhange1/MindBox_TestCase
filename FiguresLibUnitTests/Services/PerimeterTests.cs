using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib.Services;
using System;
using System.Collections.Generic;

namespace FiguresLibUnitTests
{
    [TestClass]
    public class PerimeterTests
    {
        [TestMethod]
        public void GetPerimeterManySidesTests()
        {
            // Arrange
            double expected = 12;

            // Act
            double result = Perimeter.GetPerimeter(new List<double>() { 3, 4, 5 });


            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void GetPerimeterZeroSidesTests()
        {
            // Arrange
            double expected = -1;

            // Act
            double result = Perimeter.GetPerimeter(new List<double>() { });


            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
