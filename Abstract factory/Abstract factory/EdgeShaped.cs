using System;
namespace Shapes
{
    public class EdgeShaped : AbstractFactory
    {
        public GetShape(string shapeType)
        {
            if (shapeType.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            if (shapeType.Equals("Square"))
            {
                return new Square();
            }
        }
    }
}