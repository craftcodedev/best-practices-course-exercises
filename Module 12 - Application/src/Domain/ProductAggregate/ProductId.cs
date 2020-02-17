using App.Shared.Domain;

namespace App.Domain.ProductAggregate
{
    public class ProductId : UUID
    {
        public ProductId(string value) : base(value) {}
    }
}