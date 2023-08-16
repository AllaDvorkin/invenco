using external_api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace promotion_engine
{
    public class PromotionEngine
    {
        private List<IProvider> _providers;
        private List<int> _providers_discounts;

        public PromotionEngine(List<IProvider> providers)
        {
            _providers = providers;
            _providers_discounts = new List<int>(); 
        }
        public void LoadProvidersDiscounts()
        {
            foreach (var provider in _providers)
            {
                try
                {
                    _providers_discounts.AddRange(provider.GetDiscountableItemIds().Result);
                }
                catch 
                {
                    Console.WriteLine($"Error getting prodacts list for {provider.Name}");
                }
            }
        }
        public List<Product> GetDiscounts(List<Product> products)
        {
            var list = new List<Product>();
            var result = new List<Product>();

            foreach (var product in products)
            {
                if (_providers_discounts.Contains(product.ID))
                    list.Add(product);
                else
                    result.Add(product);
            }
            var curr_time = DateTime.Now;
            bool is_night = false;
            if (curr_time.Hour > 20 || curr_time.Hour < 6)
                is_night = true;
            
            List<double?> product_discount = new List<double?>();
            foreach (var product in list)
            {
                product_discount.Clear();
                foreach (var provider in _providers)
                {
                    try
                    {
                        product_discount.Add(provider.CalculateDiscount(product.ID, product.Price).Result);
                    }
                    catch
                    {
                        Console.WriteLine($"Error getting discount for {product.ID} from {provider.Name}");
                    }
                }
                double? newPrice = product.Price;
                if (is_night)
                {
                    foreach(var discount in product_discount)
                    {
                        newPrice -= discount; 
                    }
                }
                else
                {
                    double? max_discount = product_discount.Max<double?>();
                    newPrice -= max_discount;
                }

                result.Add(new Product(product.ID, newPrice.GetValueOrDefault()));
            }

            return result;
        }
    }
}
