using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib.Circles.Implementations;
using System;

namespace FiguresLibUnitTests
{
    [TestClass]
    public class RadiusTests
    {
        [TestMethod]
        public void GetSquareTests()
        {
            // Arrange
            double expected = 314;

            // Act
            double result = Math.Round(new Radius(10).GetSquare()); // округление, т.к. десят. дробь непредсказуемая
            

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
