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
            Email emailVO = new Email(email);
            NIF nifVO = new NIF(nif);
            return User.SignUp(emailVO, nifVO);
        }
    }
}
