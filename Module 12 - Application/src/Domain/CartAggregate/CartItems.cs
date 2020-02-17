using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.CartAggregate
{
    public class CartItems : List<Item>
    {
        public Item FindByProductId(string productId)
        {
            return new Item();
        } 
        public void Remove(string productId)
        {
            
        } 
    }
}