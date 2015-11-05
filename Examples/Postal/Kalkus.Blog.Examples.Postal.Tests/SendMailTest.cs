using Kalkus.Blog.Examples.Postal.BusinessLogic;
using Kalkus.Blog.Examples.Postal.BusinessLogic.Mailer;
using Kalkus.Blog.Examples.Postal.BusinessLogic.Models;
using System.Collections.Generic;
using System.Net.Mail;
using Xunit;

namespace Kalkus.Blog.Examples.Postal.Tests
{
    public class SendMailTest
    {
        [Fact]
        public void Test()
        {
            var mailer = new Mailer();
            var model = new MailBase()
            {
                Subject = "Test",
                Template = Consts.MailTemplates.Example
            };
            model.Recipients = new List<MailAddress>();
            model.Recipients.Add(new MailAddress("landeyo@10g.pl"));
            mailer.SendMailUsingTemplate(model);
        }
    }
}