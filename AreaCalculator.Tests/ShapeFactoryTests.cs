namespace AreaCalculator.Tests
{
    public class ShapeFactoryTests
    {
        [Fact]
        public void CreateShape_Circle_ReturnsCorrectShape()
        {
            // Arrange
            ShapeFactory factory = new ShapeFactory();
            double[] parameters = { 3 };

            // Act
            IShape shape = factory.CreateShape("Circle", parameters);

            // Assert
            Assert.IsType<Circle>(shape);
            Assert.Equal(3, ((Circle)shape).Radius);
        }

        [Fact]
        public void CreateShape_Triangle_ReturnsCorrectShape()
        {
            // Arrange
            ShapeFactory factory = new ShapeFactory();
            double[] parameters = { 3, 4, 5 };

            // Act
            IShape shape = factory.CreateShape("Triangle", parameters);

            // Assert
            Assert.IsType<Triangle>(shape);
            Assert.Equal(3, ((Triangle)shape).SideA);
            Assert.Equal(4, ((Triangle)shape).SideB);
            Assert.Equal(5, ((Triangle)shape).SideC);
        }

        [Fact]
        public void CreateShape_Rectangle_ReturnsCorrectShape()
        {
            // Arrange
            ShapeFactory factory = new ShapeFactory();
            double[] parameters = { 4, 5 };

            // Act
            IShape shape = factory.CreateShape("Rectangle", parameters);

            // Assert
            Assert.IsType<Rectangle>(shape);
            Assert.Equal(4, ((Rectangle)shape).Width);
            Assert.Equal(5, ((Rectangle)shape).Height);
        }

        [Fact]
        public void CreateShape_UnknownType_ThrowsException()
        {
            // Arrange
            ShapeFactory factory = new ShapeFactory();
            double[] parameters = { };

            // Act & Assert
            Assert.Throws<Exception>(() => factory.CreateShape("Unknown", parameters));
        }
    }

}
