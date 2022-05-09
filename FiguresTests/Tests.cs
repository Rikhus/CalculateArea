using CalculateArea.Figures.Primitives;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_CreateWithNegativeRadius_ThrowedError()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        [Test]
        public void Triangle_CreateWithNegativeSides_ThrowedError()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -10, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
        }

        [Test]
        public void Triangle_CreateNonExistentTriangle_Error()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 2, 1));
        }

        [Test]
        public void Circle_GetArea_ReturedArea()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleArea = circle.Area;

            //Assert
            Assert.AreEqual(314.15926535897931, circleArea);
        }

        [Test]
        public void Triangle_GetArea_ReturnedArea()
        {
            //Arrange
            var triangle = new Triangle(12, 15, 9);

            //Act
            var triangleArea = triangle.Area;

            //Assert
            Assert.AreEqual(54, triangleArea);
        }

        [Test]
        public void Triangle_CheckIsRectangular_ReturnedTrue()
        {
            //Arrange
            var triangle = new Triangle(12, 15, 9);

            //Act
            var isTriangleIsRectangular = triangle.IsRectangular;

            //Assert
            Assert.AreEqual(true, isTriangleIsRectangular);
        }

        [Test]
        public void Triangle_CheckIsRectangular_ReturnedFalse()
        {
            //Arrange
            var triangle = new Triangle(12, 15, 10);

            //Act
            var isTriangleIsRectangular = triangle.IsRectangular;

            //Assert
            Assert.AreEqual(false, isTriangleIsRectangular);
        }
    }
}