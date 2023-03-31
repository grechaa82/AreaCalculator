namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        /// <summary>
        /// Initializing the triangle
        /// </summary>
        /// <param name="sideA">Side A</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side C</param>
        /// <exception cref="ArgumentOutOfRangeException">It is thrown out when the side is less than or equal to zero</exception>
        /// <exception cref="ArgumentException">It is thrown out when the sum of the lengths of any two sides of the triangle is less than the length of the remaining side</exception>
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

        /// <summary>
        /// Side A of the triangle
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Side B of the triangle
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Side C of the triangle
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// The result of checking the triangle for squareness
        /// </summary>
        public bool IsRightTriangle { get; }

        /// <summary>
        /// Calculate the area of the triangle
        /// </summary>
        /// <returns>The result of the calculation according to the Heron formula</returns>
        public double CalculateAreaOf()
        {
            var semiperimeter = (SideA + SideB + SideC) / 2;
            var areaOf = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));

            return areaOf;
        }

        /// <summary>
        /// Checking the triangle for squareness
        /// </summary>
        /// <returns>Boolean value after calculation by Pythagorean theorem</returns>
        private bool CheckIsRightTriangle()
        {
            double[] sides = new double[] { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}