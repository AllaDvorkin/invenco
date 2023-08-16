using promotion_engine;
using System;
using System.Collections.Generic;
using external_api;

class Program
{
    static void Main()
    {
        var products = new List<Product>()
        {
            new Product(1, 34.5),
            new Product(20, 100),
            new Product(33, 23.12),
            new Product(41, 78.98),
            new Product(7, 14.14),
            new Product(7, 0.99),
            new Product(1, 21),
            new Product(99, 21.5),
            new Product(123, 0.5),
            new Product(19, 0.21),
            new Product(82, 9.99),
        };
        var providers = new List<IProvider>()
        {
            new promBestAPI(),
            new prom4UAPI(),
        };

        var engine = new PromotionEngine(providers);
        engine.LoadProvidersDiscounts(); // this function needs to be run daily to update the current discounts for all providers

        var products_after_discount = engine.GetDiscounts(products);

        foreach (var product in products_after_discount)
            Console.WriteLine($"product {product.ID} price is now: {product.Price}");

        Console.ReadLine();
    }
}
