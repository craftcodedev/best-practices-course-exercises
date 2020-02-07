using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class User
    {
        private Email email;
        private NIF nif;

        public User(Email email, NIF nif)
        {
            this.email = email;
            this.nif = nif;
        }

        public static User SignUp(Email email, NIF nif)
        {
            return new User(email, nif);
        }

        public string EmailInfoUser()
        {
            return email.EmailParam();
        }

        public string NIFInfoUser()
        {
            return nif.NIFParam();
        }
    }
}
