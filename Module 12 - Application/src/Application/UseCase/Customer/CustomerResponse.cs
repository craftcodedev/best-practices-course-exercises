using System;
using System.Reflection;
using App.Shared.Domain.Bus.UseCase;

namespace App.Application.UseCase
{
    public class CustomerResponse : IResponse
    {
        public CustomerResponse(string id, string firstName)
        {
            this.Id = id;
            this.FirstName = firstName;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
    }
}