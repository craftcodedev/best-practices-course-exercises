using SRP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.UseCase
{
    public class UserUseCase
    {
        private UserFactory userFactory;
        private IUserRepository userRepository;

        public UserUseCase(UserFactory userFactory, IUserRepository userRepository)
        {
            this.userFactory = userFactory;
            this.userRepository = userRepository;
        }

        public void SignUp(string email, string nif)
        {
            User user = userFactory.Create(email, nif);
            userRepository.Save(user);
        }
    }
}
