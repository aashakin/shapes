namespace Shapes
{
    /// <summary>
    /// The base abstraction for all types of shapes.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Calculates the area of a shape.
        /// </summary>
        /// <returns></returns>
        double CalculateArea();
    }
}