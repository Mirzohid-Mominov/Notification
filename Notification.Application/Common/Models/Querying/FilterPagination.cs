using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Common.Models.Querying
{
    public class FilterPagination
    {
        public int PageSize { get; set; } = 10;

        public int PageToken { get; set; } = 1;
    }
}
