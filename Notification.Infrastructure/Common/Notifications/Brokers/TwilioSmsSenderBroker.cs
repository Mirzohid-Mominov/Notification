﻿using Notification.Application.Common.Notifications.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Notification.Infrastructure.Common.Notifications.Brokers
{
    public class TwilioSmsSenderBroker : ISmsSernderBroker
    {
        public ValueTask<bool> SendAsync(
            string senderPhoneNumber, 
            string receiverPhoneNumber, 
            string message, 
            CancellationToken cancellationToken)
        {
            var test = "ACe09f7247dfbdf25dbe2ef0acdf2279f9";
            var test1 = "e1fdedded3a1a2ddf74da5336dd7687d";

            TwilioClient.Init(test, test1);

            var messageContent = MessageResource.Create(
                body: message,
                from: new Twilio.Types.PhoneNumber(senderPhoneNumber),
                to: new Twilio.Types.PhoneNumber(receiverPhoneNumber)

                return new(true);
        }
    }
}
