using System;
namespace BuilderEx
{
	public class Program
	{
		public static void Main()
		{
			Director d = new Director();
			ConcreteBuild product=new ConcreteBuild();
			d.construct(product);
		}
	}
}
