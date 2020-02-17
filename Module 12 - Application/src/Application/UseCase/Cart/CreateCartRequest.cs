using System;
using System.Reflection;

namespace App.Application.UseCase
{
    public class CreateCartRequest
    {
        public CreateCartRequest(
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

