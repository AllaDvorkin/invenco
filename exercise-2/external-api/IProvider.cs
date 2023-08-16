using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace external_api
{
    public interface IProvider
{
    string Name { get; }
    Task<List<int>> GetDiscountableItemIds();

    Task<double?> CalculateDiscount(int itemId, double price);

}
}
