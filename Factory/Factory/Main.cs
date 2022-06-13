using System;
namespace Factory
{
	public class Program
	{
        public static void Main()
		{
			CardFactory f = null;
			f = new VisaFactory();
			Card c = f.GetCard();
			Console.WriteLine(c.Creditlimit());

		}
	}
}