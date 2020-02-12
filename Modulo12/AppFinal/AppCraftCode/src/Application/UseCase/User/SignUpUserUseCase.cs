using AppCraftCode.src.Domain.UserAggregate;
using AppCraftCode.src.Domain.UserAggregate.Service;
using AppCraftCode.src.Shared.Domain.Bus.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Application.UseCase.User
{
    public class SignUpUserUseCase : IUseCase
    {
        private IUserFactory userFactory;
        private SignUpUserValidator signUpUserValidator;
        private IUserRepository userRepository;

        public SignUpUserUseCase(
            IUserFactory userFactory,
            SignUpUserValidator signUpUserValidator,
            IUserRepository userRepository
        )
        {
            this.userFactory = userFactory;
            this.signUpUserValidator = signUpUserValidator;
            this.userRepository = userRepository;
        }
        public IResponse Execute(IRequest req)
        {
            SignUpUserRequest request = req as SignUpUserRequest;
            Domain.UserAggregate.User user = this.userFactory.Create(
                request.Id,
                request.Email,
                request.Password,
                request.FirstName,
                request.LastName,
                request.Country
            );

            signUpUserValidator.Validate(user.Email);

            userRepository.Save(user);

            return null;
        }
    }
}
