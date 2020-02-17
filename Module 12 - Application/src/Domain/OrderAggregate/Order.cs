using App.Shared.Domain;
using App.Domain.OrderAggregate.Event;
using System;
using System.Collections.Generic;

namespace App.Domain.OrderAggregate
{
    public class Order : AggregateRoot
    {
        private Order(
            OrderId id,
            OrderStatus status,
            OrderItems items,
            OrderCustomerId customerId,
            DateTime createdAt,
            DateTime updatedAt
        ) {
            this.Id = id;
            this.Status = status;
            this.Items = items;
            this.CustomerId = customerId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public static Order Create(OrderId id, OrderItems items, OrderCustomerId customerId)
        {
            OrderStatus status = new OrderStatus(OrderStatus.INPROGRESS_STATUS);
            DateTime createdAt = DateTime.Now;
            DateTime updatedAt = DateTime.Now;

            Order order = new Order(id, status, items, customerId, createdAt, updatedAt);

            order.Record(new OrderCreatedEvent(
                order.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["status"] = order.Status.GetValue(),
                    ["customer_id"] = order.CustomerId.GetValue(),
                    ["created_at"] = order.CreatedAt.ToString(),
                }
            ));

            return order;
        }

        public OrderId Id { get; private set; }
        public OrderStatus Status { get; private set; }
        public OrderItems Items { get; private set; }
        public OrderCustomerId CustomerId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public decimal GetTotalPrice()
        {
            return 1;
        }

        public void Finish()
        {
            this.Status = new OrderStatus(OrderStatus.FINISHED_STATUS);

            this.Record(new OrderFinishedEvent(
                this.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["status"] = this.Status.GetValue()
                }
            ));
        }
    }
}