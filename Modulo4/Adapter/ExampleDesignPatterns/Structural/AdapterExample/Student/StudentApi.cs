using System;
using System.Linq;
using System.Xml.Linq;

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
