using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Clean_Code
{
    public interface IDocumentType
    {
        string ConvertToPDF(string path);
    }
}
