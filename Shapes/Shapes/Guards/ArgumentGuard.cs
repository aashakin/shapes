using System;

namespace Shapes.Guards
{
    internal static class ArgumentGuard
    {
        /// <summary>
        /// Checks that <paramref name="number"/> is greater than zero.
        /// </summary>
        /// <param name="number">A number</param>
        /// <param name="argument">An argument name</param>
        /// <exception cref="ArgumentException"></exception>
        public static void GreaterThanZero(double number, string argument)
        {
            if (number <= 0) throw new ArgumentException("Value must be greater than zero.", argument);
        }
    }

}