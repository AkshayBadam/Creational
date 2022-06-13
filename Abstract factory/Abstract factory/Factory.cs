using System;
namespace Shapes
{
	public abstract class AbstractFactory
	{
        public GetShape(string shapeType);
		public static AbstractFactory CreateShape(string FactoryType)
        {
			if(FactoryType.Equals("Edges"))
            {
				return new EdgeShaped();
            }
			else
            {
				//return new NonEdgeFactory();
            }
        }
	}
}