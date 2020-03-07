using System;
using Shapes.Constants;
using Shapes.Guards;

namespace Shapes
{
    /// <summary>
    /// Represents a triangle with provided lengths of sides.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Length of side A.
        /// </summary>
        public double SideA { get; }
        /// <summary>
        /// Length of side B.
        /// </summary>
        public double SideB { get; }
        /// <summary>
        /// Length of side C.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Creates a triangle with provided sides.
        /// </summary>
        /// <param name="sideA">Length of side A.</param>
        /// <param name="sideB">Length of side B.</param>
        /// <param name="sideC">Length of side C.</param>
        /// <exception cref="ArgumentException">is thrown if sides do not form a triangle or one of sides is less than
        /// or equal to zero.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            TriangleGuard.Valid(sideA, sideB, sideC);
            
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        
        /// <summary>
        /// Checks if a triangle is rectangular.
        /// </summary>
        /// <returns>True if a triangle is rectangular, otherwise False</returns>
        public bool IsRightTriangle()
        {
            // Checks that A^2 + B^2 = C^2
            if (SideA * SideA + SideB * SideB - SideC * SideC < Numbers.Epsilon)
            {
                return true;
            }
            // Checks that A^2 + C^2 = B^2
            if (SideA * SideA + SideC * SideC - SideB * SideB < Numbers.Epsilon)
            {
                return true;
            }
            // Checks that C^2 + B^2 = A^2
            if (SideC * SideC + SideB * SideB - SideA * SideA < Numbers.Epsilon)
            {
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <returns>The calculated area of a triangle.</returns>
        public double CalculateArea()
        {
            var s = (SideA + SideB + SideC) / 2.0;
            
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }

}