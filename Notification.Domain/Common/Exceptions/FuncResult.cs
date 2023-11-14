using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Common.Exceptions
{
    public class FuncResult<T>
    {
        public T Data { get; set; }

        public Exception? Exception { get; set; }

        public bool IsSucces => Exception is null;

        public FuncResult(T data) => Data = data;

        public FuncResult(Exception exception) => Exception = exception;
    }
}
