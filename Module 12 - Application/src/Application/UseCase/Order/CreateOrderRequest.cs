using System;
using System.Reflection;

namespace App.Application.UseCase
{
    public class CreateOrderRequest
    {
        public CreateOrderRequest(
            string id,
            string items,
            string customerId
        ) {
            this.Id = id;
            this.Items = items;
            this.CustomerId = customerId;
        }
        
        public string Id { get; }
        public string Items { get; }
        public string CustomerId { get; }
    }
}

