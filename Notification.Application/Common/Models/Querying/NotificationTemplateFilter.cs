using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Models.Querying
{
    public class NotificationTemplateFilter : FilterPagination
    {
        public IList<NotificationType> TemplateType { get; set; }
    }
}
