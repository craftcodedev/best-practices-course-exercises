using System;
using System.Collections.Generic;
using System.IO;

namespace RefactorController.src.Service.Log
{
    public class LoggingService : ILoggingService
    {
        public bool WriteToFile(List<ILoggable> itemsToLog, string path)
        {
            string fullPath = path + "/Logs.txt";

            try
            {
                if (!File.Exists(fullPath))
                {
                    File.Create(fullPath);
                }

                if (File.Exists(fullPath))
                {
                    foreach (var item in itemsToLog)
                    {
                        using (StreamWriter writer = new StreamWriter(path + "/Logs.txt", true))
                        {
                            writer.WriteLine(item.Log());
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
