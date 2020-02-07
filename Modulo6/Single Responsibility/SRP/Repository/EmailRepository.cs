using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Repository
{
    public class EmailRepository : IEmailRepository
    {
        public void Send(EmailInfo emailInfo)
        {
            var mail = new MailMessage("solid@dh.com", emailInfo.From);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome";
            mail.Body = "Course SOLID";
            client.Send(mail);
        }
    }
}
