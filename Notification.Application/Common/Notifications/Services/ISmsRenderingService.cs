﻿using Notification.Application.Common.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Services
{
    public interface ISmsRenderingService
    {
        ValueTask<string> RenderAsync(
            SmsMessage smsMessage,
            CancellationToken cancellationToken = default);
    }
}
