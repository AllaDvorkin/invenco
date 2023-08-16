namespace core
{
    public sealed class BusinessLogic : IBusinessLogic
    {
        public string GetWelcomeMessage()
        {
            return "Hello Passport-X";
        }

        public decimal CalculateMagicNumber(int input)
        {
            return input * 10 + 23 - 6 + 1;
        }
    }
}