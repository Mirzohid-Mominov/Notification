using Notification.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = default!;

        public string PhoneNumber { get; set; } = default!;

        public string EmailAddress { get; set; } = default!;
    }
}
