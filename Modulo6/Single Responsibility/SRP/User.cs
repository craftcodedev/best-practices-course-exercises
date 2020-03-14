using SRP.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class User
    {
        private UserEmail email;
        private UserNIF nif;

        public User(UserEmail email, UserNIF nif)
        {
            this.email = email;
            this.nif = nif;
        }

        public static User SignUp(UserEmail email, UserNIF nif)
        {
            return new User(email, nif);
        }
    }
}
