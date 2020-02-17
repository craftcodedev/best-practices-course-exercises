using App.Shared.Domain;
using App.Domain.CustomerAggregate.Event;
using System.Collections.Generic;
using System;

namespace App.Domain.CustomerAggregate
{
    public class Customer : AggregateRoot
    {
        private Customer(
            CustomerId id,
            CustomerEmail email,
            CustomerHashedPassword password,
            CustomerFirstName firstName,
            CustomerLastName lastName,
            CustomerCountry country,
            DateTime createdAt,
            DateTime updatedAt
        ) {
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public static Customer SignUp(
            CustomerId id,
            CustomerEmail email,
            CustomerHashedPassword password,
            CustomerFirstName firstName,
            CustomerLastName lastName,
            CustomerCountry country
        ) {
            DateTime createdAt = DateTime.Now;
            DateTime updatedAt = DateTime.Now;
            Customer customer = new Customer(id, email, password, firstName, lastName, country, createdAt, updatedAt);
            
            customer.Record(new CustomerSignedUpEvent(
                customer.Id.GetValue(),
                new Dictionary<string, string>()
                {
                    ["email"] = customer.Email.GetValue(),
                    ["first_name"] = customer.FirstName.GetValue(),
                    ["last_name"] = customer.LastName.GetValue(),
                    ["country"] = customer.Country.GetValue(),
                    ["created_at"] = customer.CreatedAt.ToString(),
                }
            ));

            return customer;
        }
        
        public CustomerId Id { get; private set; }

        public CustomerEmail Email { get; private set; }
        
        public CustomerHashedPassword Password { get; private set; }
        
        public CustomerFirstName FirstName { get; private set; }
        
        public CustomerLastName LastName { get; private set; }
        
        public CustomerCountry Country { get; private set; }
        
        public DateTime CreatedAt { get; private set; }
        
        public DateTime UpdatedAt { get; private set; }
    }
}