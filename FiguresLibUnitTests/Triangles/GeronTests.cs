using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib.Triangles.Implementations;
using System;

namespace FiguresLibUnitTests
{
    [TestClass]
    public class GeronTests
    {
        [TestMethod]
        public void GetSquareExistTests()
        {
            // Arrange
            double expected = 6;

            // Act
            double result = new Geron(3, 4, 5).GetSquare();


            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void GetSquareDoesNotExistTests()
        {
            // Arrange
            double expected = -1;

            // Act
            double result = new Geron(1, 2, 3).GetSquare();


            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
