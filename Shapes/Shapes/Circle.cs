using System;
using Shapes.Guards;

namespace Shapes
{
    /// <summary>
    /// Represents a Circle with provided radius.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Length of circle's radius
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Creates a new Circle with provided radius.
        /// </summary>
        /// <param name="radius">The length of radius - must be greater than zero. </param>
        /// <exception cref="ArgumentException"> is thrown if <paramref name="radius"/> is less than or equal to zero.</exception>
        public Circle(double radius)
        {
            ArgumentGuard.GreaterThanZero(radius, nameof(radius));

            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <returns>The calculated value of the area of a circle</returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}