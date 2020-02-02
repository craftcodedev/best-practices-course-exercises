using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AdapterNew;
using Newtonsoft.Json;

namespace Adapter.Student
{
    public class StudentApi
    {
        public XDocument GetStudentsInXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Students");
            var xAttributes = StudentDataProvider.GetData()
                .Select(m => new XElement("Student",
                    new XAttribute("City", m.City),
                    new XAttribute("Name", m.Name),
                    new XAttribute("Age", m.Age)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
