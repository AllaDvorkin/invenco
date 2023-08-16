namespace promotion_engine
{
    public class Product
    {
        public Product(int id, double price)
        {
            ID = id;
            Price = price;
        }

        public int ID { get; }
        public double Price { get; }
    }
}
