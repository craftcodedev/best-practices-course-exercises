using ManageStore.Model.Customer.ValueObject.Exception;
using Model;

namespace ManageStore.Model.Customer.ValueObject
{
    public class CustomerName : ValueObject<CustomerName>
    {
        public const int MAX_SIZE = 15;
        public string CustomerNAME { get; }

        public CustomerName(string customerName)
        {
            CustomerNAME = customerName;

            if (IsNotValid(customerName))
            {
                throw new System.Exception("Invalid customer name");
            }

            value = customerName;
        }

        private bool IsNotValid(string customerName)
        {
            try
            {
                if (customerName.Length == 0)
                {
                    InvalidCustomerNameException.FromEmpty();
                    return true;
                }

                if (customerName.Length > CustomerName.MAX_SIZE)
                {
                    InvalidCustomerNameException.FromMaxLength();
                    return true;
                }

                return false;
            }
            catch
            {
                return true;
            }
        }

        protected override bool EqualsCore(CustomerName customerName)
        {
            return CustomerNAME == customerName.CustomerNAME;
        }
    }
}
