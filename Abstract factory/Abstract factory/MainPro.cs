using System;
namespace Shapes
{
	public class Program
	{
		static void Main()
		{ 
			Shape shap = null;
			AbstractFactory shapetyp = null;
			shapetyp = AbstractFactory.CreateShape("Edges");
			Console.Writeline(shapetyp.GetType().Name);

		}
	}
}