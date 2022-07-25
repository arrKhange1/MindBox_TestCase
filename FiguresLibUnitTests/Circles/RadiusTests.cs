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
            double result = Math.Round(new Radius(10).GetSquare()); // ����������, �.�. �����. ����� ���������������
            

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
