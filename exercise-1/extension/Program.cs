using core;
using extension;

class Program
{
    static void Main()
    {
        var pos = new PointOfSale(new CountryBusinessLogic());
        pos.ShowWelocmeScreen();
    }
}
