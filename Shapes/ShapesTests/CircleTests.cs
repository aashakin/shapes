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
        public void CalculateArea_RadiusIsGreaterThanZero_ReturnArea(double radius, double expectedValue)
        {
            var circle = new Circle(radius);

            Assert.That(circle.CalculateArea(), Is.EqualTo(expectedValue).Within(Numbers.Epsilon));
        }

        [TestCase(-1.0)]
        [TestCase(0.0)]
        public void CreateCircle_RadiusIsLessThanOrEqualToZero_ThrowException(double radius)
        {
            Assert.That(() => new Circle(radius), Throws.ArgumentException);
        }
    }
}