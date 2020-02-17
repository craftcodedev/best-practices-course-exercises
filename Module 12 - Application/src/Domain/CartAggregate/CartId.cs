using App.Shared.Domain;

namespace App.Domain.CartAggregate
{
    public class CartId : UUID
    {
        public CartId(string value) : base(value) {}
    }
}