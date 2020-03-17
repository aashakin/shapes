using System;
using NUnit.Framework;
using Shapes;
using Shapes.Constants;

namespace ShapesTests
{
    public class TriangleTests
    {
        [TestCase(3.0, 4.0, 5.0, 6.0)]
        [TestCase(1.0, 1.0, 1.0, 0.433012701)]
        [TestCase(5.0, 7.0, 8.0, 17.320508075)]
        public void CalculateArea_TriangleIsValid_ReturnArea(double sideA, double sideB, double sideC, double expectedValue)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedValue).Within(Numbers.Epsilon));
        }

        [TestCase(-1.0, 1.0, 1.0)]
        [TestCase(1.0, -1.0, 1.0)]
        [TestCase(1.0, 1.0, -1.0)]
        [TestCase(0.0, 1.0, 1.0)]
        [TestCase(1.0, 0.0, 1.0)]
        [TestCase(1.0, 1.0, 0.0)]
        public void CreateTriangle_SideIsLessThanOrEqualToZero_ThrowException(double sideA, double sideB, double sideC)
        {
            Assert.That(() => new Triangle(sideA, sideB, sideC), Throws.ArgumentException);
        }
        
        [TestCase(1.0, 3.0, 1.0)]
        [TestCase(1.0, 3.0, 2.0)]
        public void CreateTriangle_TriangleIsNotValid_ThrowException(double sideA, double sideB, double sideC)
        {
            Assert.That(() => new Triangle(sideA, sideB, sideC), Throws.ArgumentException);
        }
        
        [TestCase(3.0, 4.0, 5.0)]
        [TestCase(3.0, 5.0, 4.0)]
        [TestCase(5.0, 4.0, 3.0)]
        public void IsRightTriangle_TriangleIsRightTriangle_ReturnTrue(double sideA, double sideB, double sideC)
        {
            var triangle =  new Triangle(sideA, sideB, sideC);

            Assert.IsTrue(triangle.IsRightTriangle());
        }
        
        [TestCase(3.0, 5.0, 5.0)]
        public void IsRightTriangle_TriangleIsNotRightTriangle_ReturnFalse(double sideA, double sideB, double sideC)
        {
            var triangle =  new Triangle(sideA, sideB, sideC);

            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}