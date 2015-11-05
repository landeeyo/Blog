using Kalkus.Blog.Examples.Postal.BusinessLogic.Models;
using Postal;
using System.IO;
using System.Net.Mail;
using System.Web.Mvc;

namespace Kalkus.Blog.Examples.Postal.BusinessLogic.Mailer
{
    public class Mailer : IMailer
    {
        public void SendMailUsingTemplate(MailBase model)
        {
            // Get the path to the directory containing views
            //var viewsPath = Path.GetFullPath(@"..\Debug\MailTemplates");

            //var engines = new ViewEngineCollection();
            //var path = new FileSystemRazorViewEngine(viewsPath);
            //engines.Add((IViewEngine)path);

            //var service = new EmailService(engines);
            //service.Send(model);

                
            var viewsPath = Path.GetFullPath(@"..\..\Views");

            var engines = new ViewEngineCollection();
            engines.Add(new FileSystemRazorViewEngine(viewsPath));

            var service = new EmailService(engines);

            dynamic email = new Email("Test");
            email.Message = "Hello, non-asp.net world!";
            service.Send(email);
        }

        public void SendMail(MailMessage message)
        {
            throw new System.NotImplementedException();
        }
    }
}