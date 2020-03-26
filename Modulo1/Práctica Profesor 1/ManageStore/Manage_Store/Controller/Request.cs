using System.Collections.Generic;

namespace ManageStore.Controller
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
            return data[key];
        }
    }
}