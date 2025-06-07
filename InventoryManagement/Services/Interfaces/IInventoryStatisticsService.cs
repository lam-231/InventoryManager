using InventoryManagement.Models;
using System.Collections.Generic;

namespace InventoryManagement.Services
{
    public interface IInventoryStatisticsService
    {
        int GetTotalQuantity(IEnumerable<Product> products);
        decimal GetTotalValue(IEnumerable<Product> products);
    }
}
