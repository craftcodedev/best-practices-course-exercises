using App.Shared.Domain;

namespace App.Domain.CartAggregate
{
    public class CartCustomerId : UUID
    {
        public CartCustomerId(string value) : base(value) {}
    }
}