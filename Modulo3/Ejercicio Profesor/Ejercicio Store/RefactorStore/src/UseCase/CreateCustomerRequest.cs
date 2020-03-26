using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.UseCase
{
    public class CreateCustomerRequest
    {
        public string Id;
        public string Name;

        public CreateCustomerRequest(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
