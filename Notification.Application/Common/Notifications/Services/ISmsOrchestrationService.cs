﻿using Notification.Application.Common.Enums;
using Notification.Application.Common.Notifications.Models;
using Notification.Domain.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Services
{
    public interface ISmsOrchestrationService
    {
        ValueTask<FuncResult<bool>> SendAsync(
            SmsNotificationRequest request,
            CancellationToken cancellationToken = default);
    }
}
