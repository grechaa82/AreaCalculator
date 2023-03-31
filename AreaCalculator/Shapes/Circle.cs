namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        /// <summary>
        /// Initializing the circle
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <exception cref="ArgumentOutOfRangeException">It is thrown out when the value is less than or equal to zero</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("The value cannot be less than or equal to zero");
            }

            Radius = radius;
        }

        /// <summary>
        /// Radius of the circle
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Calculate the area of the circle
        /// </summary>
        /// <returns>The result of the calculation area</returns>
        public double CalculateAreaOf()
        {
            return Math.PI * Radius * Radius;
        }
    }
}