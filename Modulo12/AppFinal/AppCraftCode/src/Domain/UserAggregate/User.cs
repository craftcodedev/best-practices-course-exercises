using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate
{
    public class User
    {
        private User(
            UserId id,
            UserEmail email,
            string password,
            string firstName,
            string lastName,
            string country,
            DateTime createdAt,
            DateTime updatedAt
        )
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public static User SignUp(
            UserId id,
            UserEmail email,
            string password,
            string firstName,
            string lastName,
            string country
        )
        {
            DateTime createdAt = DateTime.Now;
            DateTime updatedAt = DateTime.Now;
            User user = new User(id, email, password, firstName, lastName, country, createdAt, updatedAt);

            return user;
        }

        public UserId Id { get; private set; }

        public UserEmail Email { get; private set; }

        public string Password { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Country { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}
