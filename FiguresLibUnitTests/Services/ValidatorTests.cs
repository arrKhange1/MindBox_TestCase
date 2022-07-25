using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib.Services;
using System;
using System.Collections.Generic;

namespace FiguresLibUnitTests
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void TriangleExistsTrueTests()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = Validator.TriangleExist(8,4,10);


            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TriangleExistsFalseTests()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = Validator.TriangleExist(1, 2, 3);


            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TriangleRectangularTrueTests()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = Validator.TriangleRectangular(3,4,5);


            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TriangleRectangularFalseTests()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = Validator.TriangleRectangular(8, 4, 10);


            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
