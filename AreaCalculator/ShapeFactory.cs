using AreaCalculator.Shapes;

namespace AreaCalculator
{
    public class ShapeFactory
    {
        public IShape CreateShape(string shapeType, double[] parameters)
        {
            switch (shapeType)
            {
                case "Circle":
                    return new Circle(parameters[0]);
                case "Triangle":
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                case "Rectangle":
                    return new Rectangle(parameters[0], parameters[1]);
                default:
                    throw new Exception("Unknown shape type.");
            }
        }
    }
}