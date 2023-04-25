using System;
using Xunit;
using GeometryAreaCalculator.Shapes;

namespace GeometryAreaCalculator.Tests.Shapes
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            double actualArea = circle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Fact]
        public void RectangleAreaTest()
        {
            double baseLength = 10;
            double height = 5;
            double expectedArea = baseLength * height;
            Rectangle rectangle = new Rectangle(baseLength, height);

            double actualArea = rectangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CircleInvalidRadiusTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(-1, 5)]
        [InlineData(0, 5)]
        [InlineData(10, -1)]
        [InlineData(10, 0)]
        public void RectangleInvalidDimensionsTest(double baseLength, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(baseLength, height));
        }
    }
}
