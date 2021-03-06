﻿using ManageStore.Controller;
using ManageStore.Repository;
using ManageStore.Services;
using ManageStore.UseCase;
using System;
using System.Collections.Generic;

namespace Manage_Store
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
            CustomerRepository customerRepository = new CustomerRepository();
            CustomerConverter customerConverter = new CustomerConverter();
            CreateCustomerUseCase customerUseCase = new CreateCustomerUseCase(customerRepository, customerConverter);
            CustomerPutController customerController = new CustomerPutController(customerUseCase);
            return customerController;
        }
    }
}
