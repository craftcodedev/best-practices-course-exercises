using App.Shared.Domain;
using App.Domain.PaymentAggregate.Event;
using System;
using System.Collections.Generic;

namespace App.Domain.PaymentAggregate
{
    public class Payment : AggregateRoot
    {
        public Payment(
            PaymentId id,
            PaymentPrice price,
            PaymentMethod method,
            PaymentOrderId orderId,
            PaymentCustomerId customerId,
            DateTime createdAt
        )
        {
            this.Id = id;
            this.Price = price;
            this.Method = method;
            this.OrderId = orderId;
            this.CustomerId = customerId;
            this.CreatedAt = createdAt;
        }

        public static Payment Create(
            PaymentId id,
            PaymentPrice price,
            PaymentMethod method,
            PaymentOrderId orderId,
            PaymentCustomerId customerId)
        {
            DateTime createdAt = DateTime.Now;
            
            Payment payment = new Payment(id, price, method, orderId, customerId, createdAt);

            payment.Record(new PaymentCreatedEvent(
                payment.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["price"] = payment.Price.GetValue().ToString(),
                    ["method"] = payment.Method.GetValue(),
                    ["order_id"] = payment.OrderId.GetValue(),
                    ["customer_id"] = payment.CustomerId.GetValue(),
                    ["created_at"] = payment.CreatedAt.ToString(),
                }
            ));

            return payment;
        }

        public PaymentId Id { get; private set; }
        public PaymentPrice Price { get; private set; }
        public PaymentMethod Method { get; private set; }
        public PaymentOrderId OrderId { get; private set; }
        public PaymentCustomerId CustomerId { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}