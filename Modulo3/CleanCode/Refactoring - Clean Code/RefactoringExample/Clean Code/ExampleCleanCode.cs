using Refactoring.Clean_Code;
using System.Collections.Generic;
using System.IO;

namespace TecnicasRefactoring.Clean_Code.NoCleanCode
{
    public class ExampleCleanCode
    {
        public string ExecuteConverter(string path)
        {
            Dictionary<string, IDocumentType> dicConverters = new Dictionary<string, IDocumentType>()
            {
                { ".txt", new DocumentTxt() },
                { ".doc", new DocumentDoc() },
                { ".xlsx", new DocumentExcel() },
                { ".jpeg", new DocumentImg() },
            };

            var conversor = dicConverters[Path.GetExtension(path).ToLower()];
            return conversor.ConvertToPDF(path);            
        }
    }
}
