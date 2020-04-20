using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Model
{
    public class CustomerDTO
    {
        public string Id;
        public string Name;

        public CustomerDTO(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
