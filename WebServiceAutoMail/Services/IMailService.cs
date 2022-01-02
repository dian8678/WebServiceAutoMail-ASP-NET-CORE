using WebServiceAutoMail.Model;

namespace WebServiceAutoMail.Services
{
    public interface IMailService
    {
       public Task SendMailAsync(MailRequest mailRequest);
    }
}
