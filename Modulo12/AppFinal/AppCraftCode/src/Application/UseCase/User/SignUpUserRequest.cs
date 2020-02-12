using AppCraftCode.src.Shared.Domain.Bus.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Application.UseCase.User
{
    public class SignUpUserRequest : IRequest
    {
        public SignUpUserRequest(
            string id,
            string email,
            string password,
            string repeatPassword,
            string firstName,
            string lastName,
            string country
        )
        {
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
