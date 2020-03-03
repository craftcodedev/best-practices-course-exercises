using SRP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.UseCase
{
    public class UserUseCase
    {
        private UserFactory _userFactory;
        private IUserRepository _userRepository;

        public UserUseCase(UserFactory userFactory, IUserRepository userRepository)
        {
            _userFactory = userFactory;
            _userRepository = userRepository;
        }

        public void AddUser(string email, string nif)
        {
            User user = _userFactory.Create(email, nif);
            _userRepository.Save(user);
        }
    }
}
