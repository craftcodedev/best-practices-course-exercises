using System.Collections.Generic;

namespace ManageStore.Service.Logs
{
    public interface ILoggingService
    {
        bool WriteToFile(List<ILoggable> itemsToLog, string path);
        bool ReadFile(string customerId, string path);
    }
}
