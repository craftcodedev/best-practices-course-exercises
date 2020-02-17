using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;

namespace App.Domain.CustomerAggregate
{
    public class CustomerRepeatPassword
    {
        public static void Validate(string repeatPassword, string password)
        {
            new CustomerPassword(password);
            
            if (repeatPassword != password) {
                throw InvalidCustomerAttributeException.FromText("password must be equal to repeat password");
            }
        }
    }
}