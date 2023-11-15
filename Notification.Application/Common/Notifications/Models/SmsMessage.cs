using Notification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Models
{
    public class SmsMessage : NotificationMessage
    {
        public string SenderPhoneNumber { get; set; } = default!;

        public string ReceiverPhoneNumber { get; set; } = default!;

        public SmsTemplate Template { get; set; } = default!;

        public string Message { get; set; } = default!;
    }
}
