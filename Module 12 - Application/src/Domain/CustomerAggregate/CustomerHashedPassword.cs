using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;

namespace App.Domain.CustomerAggregate
{
    public class CustomerHashedPassword : StringValueObject
    {
        public CustomerHashedPassword(string value) : base(value) {}
    }
}