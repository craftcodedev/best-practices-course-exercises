namespace elearning.Shared.Infrastructure.Service.Mailer
{
    public interface IMailer
    {
        void Send(string from, string to, string subject, string body);
    }
}