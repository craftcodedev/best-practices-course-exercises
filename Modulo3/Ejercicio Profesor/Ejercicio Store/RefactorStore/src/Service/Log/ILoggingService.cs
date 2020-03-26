using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Service.Log
{
    public interface ILoggingService
    {
        bool WriteToFile(List<ILoggable> list, string path);
    }
}
