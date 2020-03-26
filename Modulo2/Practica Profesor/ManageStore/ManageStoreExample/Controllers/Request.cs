using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Controllers
{
    public class Request
    {
        private Dictionary<string, string> data;

        public Request(Dictionary<string, string> data)
        {
            this.data = data;
        }

        public string Get(string key)
        {
            try
            {
                return this.data[key];
            }
            catch (System.Exception)
            {
                return "";
            }
        }
    }
}
