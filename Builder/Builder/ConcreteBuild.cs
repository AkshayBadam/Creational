using System;
namespace BuilderEx
{
    public class ConcreteBuild : Build
    {

        public override void body()
        {
            Console.WriteLine("Body fixed");
        }

        public override void seater()
        {
            Console.WriteLine("Seater Fixed");
        }

        public override void engine()
        {
            Console.WriteLine("Engine Fixed");
        }

        public override void lights()
        {
            Console.WriteLine("Lights fixed");
        }
    }
}