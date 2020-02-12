using AppCraftCode.src.Domain.UserAggregate;
using AppCraftCode.src.Infrastructure.Service.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Infrastructure.Service.User
{
    public class UserFactory : IUserFactory
    {
        private IHashing hashing;

        public UserFactory(IHashing hashing)
        {
            this.hashing = hashing;
        }

        public Domain.UserAggregate.User Create(string id, string email, string password, string firstName, string lastName, string country)
        {
            password = this.hashing.Hash(password);
            UserId userId = new UserId(id);
            UserEmail userEmail = new UserEmail(email);

            return Domain.UserAggregate.User.SignUp(userId, userEmail, password, firstName, lastName, country);
        }
    }
}
