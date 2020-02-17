using App.Shared.Domain;

namespace App.Domain.CustomerAggregate
{
    public class CustomerId : UUID
    {
        public CustomerId(string value) : base(value) {}
    }
}