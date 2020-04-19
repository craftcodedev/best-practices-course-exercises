using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Adapter.Student
{
    class StudentApiJsonAdapter : IStudentApiFormatAdapter
    {
        private StudentApi studentApi;

        public StudentApiJsonAdapter(StudentApi studentApi)
        {
            this.studentApi = studentApi;
        }

        public string GetStudents()
        {
            XDocument xml = this.studentApi.GetStudentsInXML();
            return JsonConvert.SerializeObject(xml);
        }
    }
}
