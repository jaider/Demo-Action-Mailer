using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Lib
{
    public class MailerHelper
    {
        public static void Send()
        {
            var user = new User { EmailAddress = "contact@jaider.net", Name = "Jaider Ariza" };
            new MailerController().Verification(user).DeliverAsync();
            new MailerController().SampleHtml(user).DeliverAsync();
        }
    }
}
