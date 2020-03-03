using SRP.Repository;
using SRP.Services;
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
            SendEmailUseCase sendEmailUseCase = new SendEmailUseCase(new SendGrid());
            UserUseCase userUseCase = new UserUseCase(new UserFactory(), new UserRepository());

            EmailInfo emailInfo = new EmailInfo
            {
                From = "craftCode@craft.com",
                To = "ruben@craft.com",
                Subject = "Subject",
                Message = "Message"
            };

            string email = "example@craft.com";
            string nif = "12345678901";

            userUseCase.AddUser(email, nif);
            sendEmailUseCase.SendMail(emailInfo);
        }
    }
}
