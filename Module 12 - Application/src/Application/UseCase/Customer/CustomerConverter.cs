using System;
using System.Reflection;
using App.Domain.CustomerAggregate;
using App.Shared.Domain.Bus.UseCase;

namespace App.Application.UseCase
{
    public class CustomerConverter : IResponse
    {
        public CustomerResponse Convert(Customer customer)
        {
            return new CustomerResponse(
                customer.Id.GetValue(),
                customer.FirstName.GetValue()
            );
        }
    }
}