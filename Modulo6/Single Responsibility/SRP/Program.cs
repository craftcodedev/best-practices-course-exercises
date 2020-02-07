using SRP.Repository;
using SRP.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailUseCase emailUseCase = new EmailUseCase(new EmailRepository());
            UserUseCase userUseCase = new UserUseCase(new UserFactory(), new UserRepository());

            EmailInfo emailInfo = new EmailInfo
            {
                From = "ruben@craft.com",
                To = "agustin@craft.com",
                Subject = "Course",
                Message = "Hello"
            };

            string nif = "1234567890";

            emailUseCase.Send(emailInfo);
            userUseCase.SignUp(emailInfo.From, nif);

        }
    }
}
