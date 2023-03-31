namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("The value cannot be less than or equal to zero");
            }

            if (sideA + sideB <= sideC
                || sideB + sideC <= sideA
                || sideC + sideA <= sideB)
            {
                throw new ArgumentException("One side of a triangle is greater than the sum of the other two sides. " +
                    "Such a triangle cannot exist.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRightTriangle = CheckIsRightTriangle();
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRightTriangle { get; }

        public double CalculateAreaOf()
        {
            var semiperimeter = (SideA + SideB + SideC) / 2;
            var areaOf = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));

            return areaOf;
        }

        private bool CheckIsRightTriangle()
        {
            double[] sides = new double[] { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}