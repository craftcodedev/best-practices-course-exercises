using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Clean_Code
{
    public class DocumentExcel : IDocumentType
    {
        public string ConvertToPDF(string path)
        {
            return "ExcelToPDF";
        }
    }
}
