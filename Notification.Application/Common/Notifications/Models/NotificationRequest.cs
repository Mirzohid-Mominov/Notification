using Notification.Application.Common.Enums;
using Notification.Domain.Enums;
using NotificationTemplateType = Notification.Application.Common.Enums.NotificationTemplateType
namespace Notification.Application.Common.Notifications.Models
{
    public class NotificationRequest
    {
        public Guid ReceiverId { get; set; }

        public NotificationTemplateType TemplateType { get; set; }

        public Dictionary<string, string> Variables { get; set; }

        public NotificationType? NotificationType { get; set; }

        public Guid? SerderId { get; set; }
    }
}
