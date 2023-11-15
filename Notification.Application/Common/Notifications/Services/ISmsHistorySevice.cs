using Notification.Application.Common.Models.Querying;
using Notification.Domain.Entities;

namespace Notification.Application.Common.Notifications.Services
{
    public interface ISmsHistorySevice
    {
        ValueTask<IList<SmsHistory>> GetByFilterAsync(
            FilterPagination paginationOptions,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default);

        ValueTask<SmsHistory> CreateAsync(
            SmsHistory smsTemplate,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);
    }
}

