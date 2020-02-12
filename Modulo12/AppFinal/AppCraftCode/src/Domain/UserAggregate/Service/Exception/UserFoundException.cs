using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate.Service.Exception
{
    public class UserFoundException
    {
        public UserFoundException(string message) { }

        public static UserFoundException FromEmail(UserEmail email)
        {
            return new UserFoundException(string.Format("user is already registered with the email {0}.", email.GetValue()));
        }
    }
}
