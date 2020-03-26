using ManageStore.Controllers;
using ManageStore.Model.Customer;
using ManageStore.Repository;
using ManageStore.UseCase;
using System;
using System.Collections.Generic;
using ManageStore.Service.Convert;
using ManageStore.Service.Logs;

namespace GestionTienda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Which action (create/get) would you like execute:");
            string action = Console.ReadLine();

            switch (action)
            {
                case "create":
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    Console.Write("Please, insert customer id:");
                    data.Add("id", Console.ReadLine());
                    Console.Write("Please, insert customer name:");
                    data.Add("name", Console.ReadLine());
                    Request request = new Request(data);
                    CustomerPutController controller = CreateCustomerPutController();
                    controller.CreateCustomerAction(request);
                    break;
                }
                case "get":
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    Console.Write("Please, insert customer id:");
                    data.Add("id", Console.ReadLine());
                    Request request = new Request(data);
                    CustomerGetController controller = CreateCustomerGetController();
                    CustomerDTO customer = controller.GetCustomerAction(request);
                    Console.WriteLine("Hola " + customer.Name + " tu id es: " + customer.Id);
                    break;
                }
                default:
                    Console.WriteLine("Bye");
                    break;
            }
        }

        private static CustomerPutController CreateCustomerPutController()
        {
            LoggingService loggingService = new LoggingService();
            ICustomerRepository CustomerRepository = new CustomerRepository(loggingService);
            CreateCustomerUseCase createCustomerUseCase = new CreateCustomerUseCase(CustomerRepository);
            CustomerPutController controller = new CustomerPutController(createCustomerUseCase);
            return controller;
        }

        private static CustomerGetController CreateCustomerGetController()
        {
            LoggingService loggingService = new LoggingService();
            ICustomerRepository CustomerRepository = new CustomerRepository(loggingService);
            FindCustomerByIdUseCase findCustomerByIdUseCase = new FindCustomerByIdUseCase(CustomerRepository);
            CustomerConverter customerConverter = new CustomerConverter();
            CustomerGetController controller = new CustomerGetController(findCustomerByIdUseCase, customerConverter);
            return controller;
        }
    }
}
