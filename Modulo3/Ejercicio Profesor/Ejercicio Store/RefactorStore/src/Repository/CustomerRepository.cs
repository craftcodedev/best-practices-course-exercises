using System.Collections.Generic;
using RefactorController.src.Model;
using RefactorController.src.Service.Log;

namespace RefactorController.src.Repository
{
    public class CustomerRepository
    {
        private ILoggingService _loggingService;

        public CustomerRepository(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public bool Save(Customer customer)
        {
            var changedItems = new List<ILoggable>
            {
                customer
            };

            _loggingService.WriteToFile(changedItems, "C:\\Users\\Usuario\\Documents");
            return true;
        }    
    }
}
