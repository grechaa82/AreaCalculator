namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("The value cannot be less than or equal to zero");
            }

            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateAreaOf()
        {
            return Math.PI * Radius * Radius;
        }
    }
}