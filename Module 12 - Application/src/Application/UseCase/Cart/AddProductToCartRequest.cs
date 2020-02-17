using System;
using System.Reflection;

namespace App.Application.UseCase
{
    public class AddProductToCartRequest
    {
        public AddProductToCartRequest(
            string id,
            string customerId,
            string productId
        ) {
            this.Id = id;
            this.CustomerId = customerId;
            this.ProductId = productId;
        }
        
        public string Id { get; }
        public string CustomerId { get; }
        public string ProductId { get; }
    }
}

