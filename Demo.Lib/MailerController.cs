using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActionMailer.Net.Standalone;

namespace Demo.Lib
{
    public class MailerController : RazorMailerBase
    {
        public override string ViewPath
        {
            get { return "Templates"; }
        }

        public RazorEmailResult Verification(User model)
        {
            To.Add(model.EmailAddress);
            From = "foo@bar.com";
            Subject = "Account Verification";
            return Email("Verification", model);
        }

        public RazorEmailResult SampleHtml(User model)
        {
            To.Add(model.EmailAddress);
            From = "foo@bar.com";
            Subject = "Sample Google";
            return Email("Sample", model);
        }
    }
}
