using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities
{
    public class EmailHistory : NotificationHistory
    {
       public EmailHistory()
        {
            Type = NotificationType.Email;
        }

        public string SendEmailAddres { get; set; } = default!;

        public string ReceiverEmailAddress { get; set; } = default!;

        public string Subject { get; set; } = default!;
    }
}
