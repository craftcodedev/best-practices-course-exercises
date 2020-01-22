using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Models
{
    public class CustomerDTO
    {
        private string id;
        private string name;

        public CustomerDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
