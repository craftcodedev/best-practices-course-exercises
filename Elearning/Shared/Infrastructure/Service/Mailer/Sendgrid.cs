namespace elearning.Shared.Infrastructure.Service.Mailer
{
    public class Sendgrid : IMailer
    {
        public Sendgrid()
        {
        }

        public void Send(string from, string to, string subject, string body)
        {
        }
    }
}