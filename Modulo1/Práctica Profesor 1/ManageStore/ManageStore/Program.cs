using ManageStore.Controller;
using ManageStore.Repository;
using ManageStore.UseCase;
using System;
using System.Collections.Generic;

namespace ManageStore
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

            var controller = GetController();
            controller.CreateCustomerAction(request);
        }

        private static CustomerPutController GetController()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            CreateCustomerUseCase customerUseCase = new CreateCustomerUseCase(customerRepository);
            CustomerPutController customerController = new CustomerPutController(customerUseCase);
            return customerController;
        }
    }
}
