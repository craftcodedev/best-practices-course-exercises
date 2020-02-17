using System;
using System.Reflection;

namespace App.Application.UseCase
{
    public class CreatePaymentRequest
    {
        public CreatePaymentRequest(
            string id,
            decimal price,
            string method,
            string orderId,
            string customerId
        ) {
            this.Id = id;
            this.Price = price;
            this.Method = method;
            this.OrderId = orderId;
            this.CustomerId = customerId;
        }
        
        public string Id { get; }
        public decimal Price { get; }
        public string Method { get; }
        public string OrderId { get; }
        public string CustomerId { get; }
    }
}

