using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities
{
    public class SmsHistory : NotificationHistory
    {
        public SmsHistory()
        {
            Type = NotificationType.Sms;
        }

        public string SenderPhoneNumber { get; set; } = default!;

        public string ReceiverPhoneNumber { get; set; } = default!; 
    }
}
