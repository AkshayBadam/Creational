using System;
namespace Factory
{
	class VisaCard: Card
	{
        private int Credit;
        public VisaCard(int Cred)
        {
            Credit = Cred;

        }
        public override int Creditlimit()
        {
            return Credit;
        }
    }
}