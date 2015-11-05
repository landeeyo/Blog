using Kalkus.Blog.Examples.Postal.BusinessLogic.Models;
using System.Net.Mail;

namespace Kalkus.Blog.Examples.Postal.BusinessLogic.Mailer
{
    public interface IMailer
    {
        void SendMailUsingTemplate(MailBase model);
        void SendMail(MailMessage message);
    }
}