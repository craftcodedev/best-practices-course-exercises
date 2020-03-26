using System;
using System.Collections.Generic;
using System.IO;

namespace ManageStore.Service.Logs
{
    public class LoggingService : ILoggingService
    {
        public bool WriteToFile(List<ILoggable> itemsToLog, string path)
        {
            string fullPath = path + "\\Logs.txt";

            if (File.Exists(fullPath))
            {
                foreach (var item in itemsToLog)
                {
                    using (StreamWriter writer = new StreamWriter(path + "\\Logs.txt", true))
                    {
                        writer.WriteLine(item.Log($"{item} saved"));
                    }
                }

                return true;
            }

            return false;
        }

        public bool ReadFile(string customerId, string path)
        {
            string fullPath = path + "\\Logs.txt";

            if (File.Exists(fullPath))
            {
                var lines = File.ReadAllLines(fullPath);

                foreach (string linea in lines)
                {
                    if (linea.Contains(customerId))
                    {
                        int index = linea.IndexOf(':');

                        string sub = string.Empty;

                        if (index >= 0)
                        {
                            sub = linea.Substring(0, index);

                            if (sub == customerId)
                            {
                                return true;
                            }
                        }
                    }
                }

                return false;
            }

            return false;
        }
    }
}
