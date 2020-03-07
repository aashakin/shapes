using System;

namespace Shapes.Guards
{
    internal static class TriangleGuard
    {
        /// <summary>
        /// Checks that provided sides form a valid triangle.
        /// </summary>
        /// <param name="sideA">The length of Side A</param>
        /// <param name="sideB">The length of Side B</param>
        /// <param name="sideC">The length of Side C</param>
        /// <exception cref="ArgumentException">is thrown if any side is less than or equal to zero
        /// or provided sides do not form a valid triangle.</exception>
        public static void Valid(double sideA, double sideB, double sideC)
        {
            ArgumentGuard.GreaterThanZero(sideA, nameof(sideA));
            ArgumentGuard.GreaterThanZero(sideB, nameof(sideB));
            ArgumentGuard.GreaterThanZero(sideC, nameof(sideC));
            
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Provided sides do not form a triangle.");
            }
        }
    }

}