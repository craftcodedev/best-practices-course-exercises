using RefactorController.src.Controller;
using RefactorController.src.Repository;
using RefactorController.src.Service;
using RefactorController.src.Service.Log;
using RefactorController.src.UseCase;
using System;
using System.Collections.Generic;

namespace RefactorStore
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerController controller = CustomerPutController();

            Dictionary<string, string> data = new Dictionary<string, string>();
            Console.Write("Please, insert customer id:");
            data.Add("id", Console.ReadLine());
            Console.Write("Please, insert customer name:");
            data.Add("name", Console.ReadLine());
            Request request = new Request(data);

            try
            {
                var dto = controller.CustomerAction(request);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static CustomerController CustomerPutController()
        {
            LoggingService service = new LoggingService();
            CustomerRepository repository = new CustomerRepository(service);
            CustomerConverter converter = new CustomerConverter();
            CreateCustomerUseCase useCase = new CreateCustomerUseCase(repository, converter);
            return new CustomerController(useCase);
        }
    }
}
