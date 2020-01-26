using RefactorController.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Repository
{
    public interface ICustomerRepository
    {
        bool Save(Customer customer);
    }
}
