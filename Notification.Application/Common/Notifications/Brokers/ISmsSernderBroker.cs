using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Brokers
{
    public interface ISmsSernderBroker
    {
        ValueTask<bool> SendAsync(
            string senderPhoneNumber,
            string receiverPhoneNumber,
            string message,
            CancellationToken cancellationToken
            );
    }
}
