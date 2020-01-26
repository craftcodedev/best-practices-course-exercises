using RefactorController.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Service
{
    public class CustomerConverter
    {
        public CustomerDTO Convert(Customer customer)
        {
            return new CustomerDTO(customer.Id().Id(), customer.Name().Name());
        }
    }
}
