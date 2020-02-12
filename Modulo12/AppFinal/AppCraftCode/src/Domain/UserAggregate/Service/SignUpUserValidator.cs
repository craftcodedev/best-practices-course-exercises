using AppCraftCode.src.Domain.UserAggregate.Service.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate.Service
{
    public class SignUpUserValidator
    {
        private IUserRepository userRepository;

        public SignUpUserValidator(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Validate(UserEmail email)
        {
            User user = this.userRepository.FindOneByEmail(email);

            if (user is User)
            {
                throw new System.Exception("");
            }
        }
    }
}
