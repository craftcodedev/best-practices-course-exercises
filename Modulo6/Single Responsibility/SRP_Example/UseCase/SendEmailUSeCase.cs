using SRP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.UseCase
{
    public class SendEmailUseCase
    {
        private IMailer _mailer;

        public SendEmailUseCase(IMailer mailer)
        {
            _mailer = mailer;
        }

        public void SendMail(EmailInfo emailInfo)
        {
            _mailer.Send(emailInfo);
        }
    }
}
