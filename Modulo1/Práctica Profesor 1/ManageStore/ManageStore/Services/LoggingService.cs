using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Services
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> listItems, string path)
        {
            string full = path + "\\Logs.txt";

            if(File.Exists(full))
            {
                foreach (var item in listItems)
                {
                    using (StreamWriter sw = new StreamWriter(full, true))
                    {
                        sw.WriteLine(item.Log());
                    }
                }
            }
        }
    }
}
