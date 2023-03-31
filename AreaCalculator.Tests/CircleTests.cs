namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateAreaOf_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 2;

            IShape circle = new Circle(radius);

            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateAreaOf();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_WithInvalidRadius_ThrowsArgumentOutOfRangeException(double radius)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }

}