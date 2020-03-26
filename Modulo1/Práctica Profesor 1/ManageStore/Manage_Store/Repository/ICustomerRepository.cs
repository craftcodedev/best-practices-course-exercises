using ManageStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Repository
{
    public interface ICustomerRepository
    {
        bool Save(Customer customer);
    }
}
