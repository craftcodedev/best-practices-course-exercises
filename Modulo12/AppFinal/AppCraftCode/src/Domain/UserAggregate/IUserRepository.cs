using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate
{
    public interface IUserRepository
    {
        User FindOneById(UserId id);
        User FindOneByEmail(UserEmail email);
        void Save(User customer);
    }
}
