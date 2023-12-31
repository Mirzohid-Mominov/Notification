﻿using Notification.Application.Common.Notifications.Models;

namespace Notification.Application.Common.Notifications.Services
{
    public interface IEmailRenderingService
    {
        ValueTask<string> RenderAsync(
            EmailMessage message,
             CancellationToken cancellationToken = default);
    }
}
