namespace Shapes
{
    public abstract class AbstractFactoryBase
    {
        public static AbstractFactory CreateShape(string FactoryType)
        {
            if (FactoryType.Equals("Edges"))
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