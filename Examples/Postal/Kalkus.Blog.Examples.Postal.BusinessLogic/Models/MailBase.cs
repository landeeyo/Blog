using Postal;
using System.Collections.Generic;
using System.Net.Mail;

namespace Kalkus.Blog.Examples.Postal.BusinessLogic.Models
{
    public class MailBase : Email
    {
        public List<MailAddress> Recipients { get; set; }
        public List<MailAddress> BccRecipients { get; set; }
        public string Subject { get; set; }
        public string Template { get; set; }
    }
}