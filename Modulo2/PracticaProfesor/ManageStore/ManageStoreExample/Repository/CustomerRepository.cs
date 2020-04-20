using System;
using System.Collections.Generic;
using System.Linq;
using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;
using ManageStore.Repository.Exception;
using ManageStore.Service.Convert;
using ManageStore.Service.Logs;

namespace ManageStore.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private ILoggingService _loggingService;

        public CustomerRepository(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public Customer FindById(CustomerId id)
        {
            bool found = _loggingService.ReadFile(Convert.ToString(id.CustomerID), PathFile.PATH_FILE);

            if (!found)
            {
                return null;
            }

            return Customer.Create(id, new CustomerName("customer"));
        }

        public bool Save(Customer customer)
        {
            try
            {
                var changedItems = new List<ILoggable>
                {
                    customer
                };

                _loggingService.WriteToFile(changedItems, PathFile.PATH_FILE);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
