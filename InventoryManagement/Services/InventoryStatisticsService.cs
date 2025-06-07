using InventoryManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Services
{
  public class InventoryStatisticsService : IInventoryStatisticsService
  {
    public int GetTotalQuantity(IEnumerable<Product> products)
    {
      if (products == null)
          throw new ArgumentNullException(nameof(products));
      return products.Sum(p => p.Quantity);
    }

    public decimal GetTotalValue(IEnumerable<Product> products)
    {
      if (products == null)
          throw new ArgumentNullException(nameof(products));
      return products.Sum(p => p.Price * p.Quantity);
    }
  }
}
