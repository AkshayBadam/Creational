using System;
namespace Factory
{
    class VisaFactory : CardFactory
    {
        public override Card GetCard()
        {
            return new VisaCard(50000);
        }
    }
}
