using Notification.Application.Common.Models.Querying;
using Notification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Services
{
    public interface IEmailHistoryService
    {
        ValueTask<IList<EmailHistory>> GetByFilterAsync(
            FilterPagination paginationOptions,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default);

        ValueTask<EmailHistory> CreateAsync(
            EmailHistory smsTemplate,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);
    }
}
