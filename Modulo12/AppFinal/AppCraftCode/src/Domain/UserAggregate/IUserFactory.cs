using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate
{
    public interface IUserFactory
    {
        User Create(
            string id,
            string email,
            string password,
            string firstName,
            string lastName,
            string country
        );
    }
}
