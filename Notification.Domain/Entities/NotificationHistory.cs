using Notification.Domain.Common.Entities;
using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities
{
    public abstract class NotificationHistory : IEntity
    {
        public Guid Id { get; set; }

        public Guid TemplateId { get; set; }

        public Guid SenderUserId { get; set; }

        public Guid ReceiverUserId { get; set; }

        public NotificationType Type { get; set; }

        public string Content { get; set; } = default!;

        public NotificationTemplate Template { get; set; }
    }
}
