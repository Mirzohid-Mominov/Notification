using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Models
{
    public class SmsNotificationRequest : NotificationRequest
    {
        public SmsNotificationRequest() => Type = Domain.Enums.NotificationType.Sms;
    }
}
