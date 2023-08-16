using System;

namespace core
{
    public class PointOfSale
    {
        private readonly IBusinessLogic _logic;

        public PointOfSale(IBusinessLogic logic)
        {
            _logic = logic;
        }

        public void ShowWelocmeScreen()
        {
            var message = _logic.GetWelcomeMessage();
            var magicNumber = _logic.CalculateMagicNumber(42);
            Console.WriteLine($"{message} : your magic number is --> {magicNumber}");
        }
    }
}