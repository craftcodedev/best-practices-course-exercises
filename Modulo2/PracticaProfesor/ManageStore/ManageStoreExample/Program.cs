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
            Dictionary<string, string> data = new Dictionary<string, string>();
            Console.Write("Write a customer id ");
            data.Add("id", Console.ReadLine());
            Console.Write("Write a customer name ");
            data.Add("name", Console.ReadLine());
            Request request = new Request(data);

            var controller = CreateCustomerPutController();
            controller.CreateCustomerAction(request);
        }

        private static CustomerPutController CreateCustomerPutController()
        {
            LoggingService loggingService = new LoggingService();
            ICustomerRepository CustomerRepository = new CustomerRepository(loggingService);
            CustomerConverter customerConverter = new CustomerConverter();
            CreateCustomerUseCase createCustomerUseCase = new CreateCustomerUseCase(CustomerRepository, customerConverter);
            CustomerPutController controller = new CustomerPutController(createCustomerUseCase);
            return controller;
        }
    }
}
