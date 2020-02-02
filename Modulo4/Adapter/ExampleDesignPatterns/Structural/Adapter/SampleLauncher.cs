using Adapter.Student;
using System;

namespace AdapterNew
{
    class SampleLauncher
    {
        static void Main(string[] args)
        {
            //NO ADAPTER
            StudentApi sapi = new StudentApi();
            var xml = sapi.GetStudentsInXML();
            Console.WriteLine(xml);

            //ADAPTER
            sapi = new StudentApi();
            xml = sapi.GetStudentsInXML();
            IStudentAdapter adapter = new JsonAdapter();
            var json = adapter.Convert(xml);
        }
    }
}
