using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMSLogin
{
    class ServiceSMS
    {
        private string accountSid = "AC997b23646032dfe1b7acca0740de00a2";
        // Your Auth Token from twilio.com/console
        private string authToken = "b6c05ae4b552292afbd4ddbdc80385a5";

        public ServiceSMS()
        {
            TwilioClient.Init(accountSid, authToken);
        }

        public string SendSms(string to, string text)
        {
            var message = MessageResource.Create(
              to: new PhoneNumber("+7"+to),
                from: new PhoneNumber("+12164466538 "),
                body: text);

            return message.Sid;
        }
    }



}
