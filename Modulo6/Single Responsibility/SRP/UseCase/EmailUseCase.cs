using SRP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.UseCase
{
    public class EmailUseCase
    {
        private IEmailRepository emailRepository;

        public EmailUseCase(IEmailRepository emailRepository)
        {
            this.emailRepository = emailRepository;
        }

        public void Send(EmailInfo emailInfo)
        {
            emailRepository.Send(emailInfo);
        }
    }
}
