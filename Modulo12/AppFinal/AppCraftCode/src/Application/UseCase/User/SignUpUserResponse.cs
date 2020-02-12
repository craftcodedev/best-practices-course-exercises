using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Application.UseCase.User
{
    public class SignUpUserResponse
    {
        public SignUpUserResponse(
            string id,
            string email,
            string firstName,
            string lastName,
            string country,
            string role
        )
        {
            this.Id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Role = role;
        }

        public string Id { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Country { get; }
        public string Role { get; }
    }
}
