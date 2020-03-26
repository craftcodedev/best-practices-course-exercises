using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CreateCustomerUseCase
    {
        private ICustomerRepository customerRepository;

        public CreateCustomerUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void Execute(string id, string name)
        {
            Customer customer = new Customer(id, name);
            customerRepository.Save(customer);
            var logger = Logger.GetInstance();
            logger.Log("Saved to database: " + id);
        }
    }
}
