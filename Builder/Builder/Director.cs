using System;
namespace BuilderEx
{
	class Director
	{
		public void construct(ConcreteBuild product)
		{
			product.body();
			product.seater();
			product.engine();
			product.lights();
		}


	}
}