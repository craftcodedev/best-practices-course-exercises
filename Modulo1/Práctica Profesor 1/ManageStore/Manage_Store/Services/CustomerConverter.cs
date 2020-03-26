using ManageStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Services
{
    public class CustomerConverter
    {
        public CustomerDTO Convert(Customer customer)
        {
            CustomerDTO dto = new CustomerDTO(customer.Id().Id(), customer.Name().Name());
            return dto;
        }
    }
}
