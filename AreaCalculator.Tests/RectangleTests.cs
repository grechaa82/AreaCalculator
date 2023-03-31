namespace AreaCalculator.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void Rectangle_WithPositiveWidthAndHeight_ReturnsArea()
        {
            // Arrange
            double width = 4;
            double height = 6;

            IShape rectangle = new Rectangle(width, height);

            double expectedArea = 24;

            // Act
            double actualArea = rectangle.CalculateAreaOf();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(4, 0)]
        [InlineData(-1, 5)]
        [InlineData(4, -1)]
        public void Rectangle_WithNonPositiveValues_ThrowsArgumentOutOfRangeException(double width, double height)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(width, height));
        }
    }

}
