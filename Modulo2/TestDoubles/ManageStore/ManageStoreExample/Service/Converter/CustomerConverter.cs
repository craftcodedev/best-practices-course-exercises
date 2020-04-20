using System;
using ManageStore.Model.Customer;

namespace ManageStore.Service.Convert
{
    public class CustomerConverter
    {
        public CustomerDTO Convert(Customer customer)
        {
            var id = customer.Id().CustomerID;
            var name = customer.Name().CustomerNAME;

            CustomerDTO c = new CustomerDTO(id, name);

            return c;
        }
    }
}
