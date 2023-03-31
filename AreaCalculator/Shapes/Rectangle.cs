namespace AreaCalculator.Shapes
{
    public class Rectangle : IShape
    {
        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("The value cannot be less than or equal to zero");
            }

            Width = width;
            Height = height;
        }

        public double Width { get; }
        public double Height { get; }

        public double CalculateAreaOf()
        {
            return Width * Height;
        }
    }
}