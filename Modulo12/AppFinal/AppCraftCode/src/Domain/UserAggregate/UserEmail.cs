using AppCraftCode.src.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate
{
    public class UserEmail : StringValueObject
    {
        public UserEmail(string value) : base(value)
        {
            try
            {
                new System.Net.Mail.MailAddress(value);
            }
            catch
            {
                throw new Exception("email");
            }
        }
    }
}
