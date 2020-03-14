using SRP.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserFactory
    {
        public User Create(string email, string nif)
        {
            UserEmail userEmail = new UserEmail(email);
            UserNIF userNIF = new UserNIF(nif);
            return User.SignUp(userEmail, userNIF);
        }
    }
}
