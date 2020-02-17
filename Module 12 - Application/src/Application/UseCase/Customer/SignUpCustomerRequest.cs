using System;
using System.Reflection;
using App.Shared.Domain.Bus.UseCase;

namespace App.Application.UseCase
{
    public class SignUpCustomerRequest : IRequest 
    {
        public SignUpCustomerRequest(
            string id,
            string email,
            string password,
            string repeatPassword,
            string firstName,
            string lastName,
            string country
        ) {
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.RepeatPassword = repeatPassword;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }
        
        public string Id { get; }
        public string Email { get; }
        public string Password { get; }
        public string RepeatPassword { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Country { get; }
    }
}

