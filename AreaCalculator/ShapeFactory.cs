using AreaCalculator.Shapes;

namespace AreaCalculator
{
    public class ShapeFactory
    {
        /// <summary>
        /// Creates a new object that implements the IShape interface 
        /// </summary>
        /// <param name="shapeType">Type of the shape being created</param>
        /// <param name="parameters">Value for the shape being created</param>
        /// <returns>Returns a new object that implements the IShape interface</returns>
        /// <exception cref="Exception">It is thrown out when the shape type does not exist</exception>
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