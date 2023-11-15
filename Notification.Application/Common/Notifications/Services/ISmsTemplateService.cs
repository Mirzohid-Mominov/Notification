using Notification.Application.Common.Enums;
using Notification.Application.Common.Models.Querying;
using Notification.Domain.Entities;
using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Services
{
    public interface ISmsTemplateService
    {
        ValueTask<IList<SmsTemplate>> GetByFilterAsync(
            FilterPagination paginationOptions,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default);

        ValueTask<SmsTemplate?> GetByTypeAsync(
            NotificationTemplateType templateType,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default);

        ValueTask<SmsTemplate> CreateAsync(
            SmsTemplate template,
            bool asNoTracking = true,
            CancellationToken cancellationToken = default);
    }
}
