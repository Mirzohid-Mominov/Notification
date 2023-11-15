using Notification.Application.Common.Models.Querying;
using Notification.Domain.Entities;
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
        IQueryable<SmsTemplate> Get(Expression<Func<SmsTemplate, bool>>? predicate = default, bool asNoTracking = false);

        ValueTask<IList<SmsTemplate>> GetByFilterAsync(
            FilterPagination filterPagination,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default);

        ValueTask<SmsTemplate> CreateAsync(
            SmsTemplate template,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default);
    }
}
