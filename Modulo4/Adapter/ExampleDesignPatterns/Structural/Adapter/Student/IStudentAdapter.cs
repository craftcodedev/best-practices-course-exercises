using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter.Student
{
    public interface IStudentAdapter
    {
        string Convert(XDocument xml);
    }
}
