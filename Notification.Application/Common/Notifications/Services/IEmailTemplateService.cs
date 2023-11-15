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
    public interface IEmailTemplateService
    {
        IQueryable<EmailTemplate> Get(
            Expression<Func<EmailTemplate, bool>>? predicate = default, 
            bool asNoTracking = false);

        ValueTask<IList<EmailTemplate>> GetByFilterAsync(
            FilterPagination paginationOptions, 
            bool asNoTracking = false, 
            CancellationToken cancellationToken = default);

        ValueTask<EmailTemplate> CreateAsync(
            EmailTemplate emailTemplate,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);
    }
}
