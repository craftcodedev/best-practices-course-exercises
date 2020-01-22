using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Service.Logs;

namespace ManageStore
{
    public class StringHelper
    {
        private readonly ILoggable _logger;

        public StringHelper(ILoggable logger)
        {
            _logger = logger;
        }

        public string ToUpper(string value)
        {
            return value.ToUpper();
        }

        public string ToLower(string value)
        {
            _logger.Log($"Converting {value} to upper");
            return value.ToLower();
        }
    }
}
