using System;
using Facade.Interfaces;

namespace Facade.Inventory
{
    class InventoryManager : IInventory
    {
        public void Update(int productId)
        {
            Console.WriteLine(string.Format("Product {0} is subtracted from the store's inventory." , productId));
        }
    }
}
