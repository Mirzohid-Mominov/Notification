using Notification.Domain.Common.Entities;
using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities
{
    public abstract class NotificationTemplate : IEntity
    {
        public Guid Id { get; set; }

        public string Content { get; set; } = default!;

        public NotificationType Type { get; set; }

        public IList<NotificationHistory> Histories { get; set; } = new List<NotificationHistory>();
    }
}
