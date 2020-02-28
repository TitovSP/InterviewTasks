using AreaOfShapes.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class AreaOfShapesTests
    {
        [TestMethod]
        public void CircleAreaWithValueCountsFractionalPositiveNumber()
        {
            uint radius = 2;
            Circle circle = new Circle(radius);
            double correctCount = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

            double area = circle.Area;

            Assert.AreEqual(correctCount, area);
        }
        [TestMethod]
        public void CircleAreaWithoutValueCountsZero()
        {
            Circle circle = new Circle();

            double area = circle.Area;

            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void CircleRadiusChangingAreaValue()
        {
            uint radius = 2;
            Circle circle = new Circle(radius);

            double area1 = circle.Area;
            circle.Radius = radius + 1;
            double area2 = circle.Area;

            Assert.IsTrue(area2 > area1);
        }
        [TestMethod]
        public void TriangleAreaWithValueCountsFractionalPositiveNumber()
        {
            uint a = 1, b = 2, c = 3;
            Triangle triangle = new Triangle(a, b, c);

            double p = (a + b + c) / 2.0;
            double correctCount = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double area = triangle.Area;

            Assert.AreEqual(correctCount, area);
        }
        [TestMethod]
        public void TriangleAreaWithoutValueCountsZero()
        {
            Triangle triangle = new Triangle();

            double area = triangle.Area;

            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void TriangleAreaWithValueCountsZero()
        {
            Triangle triangle = new Triangle(1, 2, 3);

            double area = triangle.Area;

            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRight = triangle.IsRightTriangle();

            Assert.IsTrue(isRight);
        }
        [TestMethod]
        public void TriangleSideAChangingAreaValue()
        {
            uint a = 2, b = 2, c = 3;
            Triangle triangle = new Triangle(a, b, c);

            double area1 = triangle.Area;
            triangle.SideA = 4;
            double area2 = triangle.Area;

            Assert.IsTrue(area2 > area1);
        }
        [TestMethod]
        public void AreaOfUnknownShapeEqualsChildShape()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Shape shape = new Shape(triangle);

            var triangleArea = triangle.Area;
            var shapeArea = shape.Area;

            Assert.AreEqual(triangleArea, shapeArea);
        }
    }
}
