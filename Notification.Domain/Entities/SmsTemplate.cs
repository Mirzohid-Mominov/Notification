using Type = Notification.Domain.Enums.NotificationType;


namespace Notification.Domain.Entities
{
    public class SmsTemplate : NotificationTemplate
    {
        public SmsTemplate()
        {
            Type = Type.Sms;
        }
    }
}
