using System.Reflection;

namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CreateTriangle_WithValidSides_ShouldSucceed()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            // Act
            var triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.NotNull(triangle);
            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(3, -1, 5)]
        [InlineData(3, 4, 0)]
        [InlineData(-3, -4, -5)]
        public void CreateTriangle_WithInvalidSides_ShouldThrowException(
            double sideA, 
            double sideB, 
            double sideC)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 8)]
        [InlineData(3, 8, 4)]
        [InlineData(8, 3, 4)]
        public void CreateTriangle_WithImpossibleSides_ShouldThrowException(
            double sideA, double sideB, double sideC)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculateAreaOf_TriangleWithValidSides_ShouldReturnCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double expectedArea = 6;

            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var actualArea = triangle.CalculateAreaOf();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CheckIsRightTriangle_WithRightTriangle_ShouldReturnTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 5;
            double sideC = 4;

            var triangle = new Triangle(sideA, sideB, sideC);

            Type type = typeof(Triangle);
            MethodInfo checkIsRightTriangleMethod = type.GetMethod("CheckIsRightTriangle", BindingFlags.NonPublic | BindingFlags.Instance);

            // Act
            bool isRightTriangle = (bool)checkIsRightTriangleMethod.Invoke(triangle, null);

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void CheckIsRightTriangle_WithNonRightTriangle_ShouldReturnFalse()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;

            var triangle = new Triangle(sideA, sideB, sideC);

            Type type = typeof(Triangle);
            MethodInfo checkIsRightTriangleMethod = type.GetMethod("CheckIsRightTriangle", BindingFlags.NonPublic | BindingFlags.Instance);

            // Act
            bool isRightTriangle = (bool)checkIsRightTriangleMethod.Invoke(triangle, null);

            // Assert
            Assert.False(isRightTriangle);
        }
    }

}
