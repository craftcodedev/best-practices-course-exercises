using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter.Student
{
    class JsonAdapter : IStudentAdapter
    {
        public string Convert(XDocument xml)
        {
            return JsonConvert.SerializeObject(xml);
        }
    }
}
