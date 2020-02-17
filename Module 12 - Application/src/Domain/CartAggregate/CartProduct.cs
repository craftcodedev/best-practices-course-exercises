using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.CartAggregate
{
    public class CartProduct
    {
        public CartProduct(string id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }
    }
}