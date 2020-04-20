using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Models;
using ManageStore.Services;

namespace ManageStore.Repository
{
    class CustomerRepository : ICustomerRepository
    {
        public bool Save(Customer customer)
        {
            List<ILoggable> listItems = new List<ILoggable>
            {
                customer
            };

            LoggingService.WriteToFile(listItems, PathFile.PATH_FILE);
            return true;
        }
    }
}
