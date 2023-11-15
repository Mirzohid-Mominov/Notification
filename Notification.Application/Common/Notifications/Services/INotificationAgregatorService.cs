using Notification.Application.Common.Models.Querying;
using Notification.Application.Common.Notifications.Models;
using Notification.Domain.Common.Exceptions;
using Notification.Domain.Entities;

namespace Notification.Application.Common.Notifications.Services
{
    public interface INotificationAgregatorService
    {
        ValueTask<FuncResult<bool>> SendAsync(
            NotificationRequest notificationRequest,
            CancellationToken cancellationToken = default);

        ValueTask<IList<NotificationTemplate>> GetTemplatesByFilterAsync(
            NotificationTemplateFilter filter,
            CancellationToken cancellationToken = default);
    }
}
