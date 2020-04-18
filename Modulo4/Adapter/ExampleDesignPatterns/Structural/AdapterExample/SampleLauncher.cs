using Adapter.Student;
using System;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //NO ADAPTER
            StudentApi sapi = new StudentApi();
            var xml = sapi.GetStudentsInXML();
            Console.WriteLine(xml);

            //ADAPTER
            sapi = new StudentApi();
            IStudentApiFormatAdapter adapter = new StudentApiJsonAdapter(sapi);
            var json = adapter.GetStudents();
            Console.WriteLine(json);
        }
    }
}
