using Notification.Domain.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Extansions
{
    public static class ExceptionExtension
    {
        public static async ValueTask<FuncResult<T>>  GetValueAsync<T>(this Func<Task<T>> func) where T : struct
        {
            FuncResult<T> result;

            try
            {
                result = new FuncResult<T>(await func());
            }
            catch (Exception ex)
            {
                result = new FuncResult<T>(ex);
            }

            return result;  
        }
    }
}
