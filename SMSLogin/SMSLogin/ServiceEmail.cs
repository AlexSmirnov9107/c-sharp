using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
namespace SMSLogin
{
    class ServiceEmail
    {
        public async Task SendEmailAsync(string text, string email,string subject )
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("shadowalex9107@gmail.com", "Alexandr Smirnov"),
                Subject = subject,
                PlainTextContent = text
            };
            msg.AddTo(new EmailAddress(email, "For User"));
            var response = await client.SendEmailAsync(msg);
        }
    }
}
