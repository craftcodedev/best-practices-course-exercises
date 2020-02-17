using App.Domain.CartAggregate.Event;
using App.Shared.Domain;
using System;
using System.Collections.Generic;

namespace App.Domain.CartAggregate
{
    public class Cart : AggregateRoot
    {
        private const int MAX_ITEMS = 10;

        private Cart(
            CartId id,
            CartCustomerId customerId,
            CartStatus status,
            CartItems items,
            DateTime createdAt,
            DateTime updatedAt
        ) {
            this.Id = id;
            this.CustomerId = customerId;
            this.Status = status;
            this.Items = items;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public static Cart Create(
            CartId id,
            CartCustomerId customerId,
            CartProduct product)
        {
            DateTime createdAt = DateTime.Now;
            DateTime updatedAt = DateTime.Now;
            CartStatus status = new CartStatus(CartStatus.OPEN_STATUS);
            CartItems cartItems = new CartItems();
            Cart cart = new Cart(id, customerId, status, cartItems, createdAt, updatedAt);

            cart.Record(new CartCreatedEvent(
                cart.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["status"] = cart.Status.GetValue(),
                    ["customer_id"] = cart.CustomerId.GetValue(),
                    ["created_at"] = cart.CreatedAt.ToString(),
                }
            ));

            return cart;
        }

        public CartId Id { get; private set; }
        public CartStatus Status { get; private set; }
        public CartItems Items { get; private set; }
        public CartCustomerId CustomerId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public void Add(CartProduct product)
        {
            this.CanAdd(product);
            this.Items.Add(new Item());
        }

        public void CanAdd(CartProduct product)
        {
            if (this.Items.Count >= Cart.MAX_ITEMS) {
                //throw "Cannot add more than 10 items of each cart."
            }
            
            Item item = this.Items.FindByProductId(product.Id);

            if (item is Item) {
                //throw
            }
        }

        public void Remove(CartProduct product)
        {
            this.Items.Remove(product.Id);
        }

        public void ProceedToCheckout(CartStatus status)
        {
            if (status.GetValue() != CartStatus.CLOSED_STATUS) {
                //throw
            }

            this.Status = status;

            this.Record(new CartCreatedEvent(
                this.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["status"] = this.Status.GetValue(),
                }
            ));
        }
    }
}
