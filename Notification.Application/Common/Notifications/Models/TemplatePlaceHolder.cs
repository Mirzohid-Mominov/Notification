using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Notifications.Models
{
    public class TemplatePlaceHolder
    {
        public string PlaceHolder { get; set; } = default!;

        public string PlaceHolderValue { get; set; } = default!;

        public string? Value { get; set; } = default!;

        public bool IsValid { get; set; }
    }
}
