using App.Shared.Domain;
using App.Domain.ProductAggregate.Event;
using System.Collections.Generic;

namespace App.Domain.ProductAggregate
{
    public class Product : AggregateRoot
    {
        private Product(
            ProductId id,
            ProductName name,
            ProductDescription description,
            ProductPrice price
        ) {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        public static Product Create(
            ProductId id,
            ProductName name,
            ProductDescription description,
            ProductPrice price
        ) {
            Product product = new Product(id, name, description, price);

            product.Record(new ProductCreatedEvent(
                product.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["name"] = product.Name.GetValue(),
                    ["description"] = product.Description.GetValue(),
                    ["price"] = product.Price.GetValue().ToString()
                }
            ));

            return product;
        }

        public ProductId Id { get; private set; }
        public ProductName Name { get; private set; }
        public ProductDescription Description { get; private set; }
        public ProductPrice Price { get; private set; }
    }
}
