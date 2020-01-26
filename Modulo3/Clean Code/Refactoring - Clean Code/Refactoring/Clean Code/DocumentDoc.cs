using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Clean_Code
{
    public class DocumentDoc : IDocumentType
    {
        public string ConvertToPDF(string path)
        {
            return "DocToPDF";
        }
    }
}
