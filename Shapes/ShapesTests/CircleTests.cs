using System;
using NUnit.Framework;
using Shapes;
using Shapes.Constants;

namespace ShapesTests
{
    public class CircleTests
    {
        [TestCase(1.0, Math.PI)]
        [TestCase(2.0, 4.0 * Math.PI)]
        public void ShouldCalculateAreaIfRadiusIsGreaterThanZero(double radius, double area)
        {
            var circle = new Circle(radius);

            Assert.That(circle.CalculateArea(), Is.EqualTo(area).Within(Numbers.Epsilon));
        }

        [TestCase(-1.0)]
        [TestCase(0.0)]
        public void ShouldThrowExceptionIfRadiusIsLessThanOrEqualToZero(double radius)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));

            Assert.IsNotNull(ex);
        }
    }
}