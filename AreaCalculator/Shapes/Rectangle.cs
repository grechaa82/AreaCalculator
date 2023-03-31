namespace AreaCalculator.Shapes
{
    public class Rectangle : IShape
    {
        /// <summary>
        /// Initializing the rectangle
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        /// <exception cref="ArgumentOutOfRangeException">It is thrown out when the value is less than or equal to zero</exception>
        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("The value cannot be less than or equal to zero");
            }

            Width = width;
            Height = height;
        }

        /// <summary>
        /// Width of the rectangle
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Height of the rectangle
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Calculate the area of the rectangle
        /// </summary>
        /// <returns>The result of the calculation area</returns>
        public double CalculateAreaOf()
        {
            return Width * Height;
        }
    }
}