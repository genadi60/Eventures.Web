using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Eventures.Web.Exceptions
{
    public class UnauthorizedCustomException : BaseCustomException
    {
        public UnauthorizedCustomException(string message, string description) : base(message, description, (int)HttpStatusCode.Unauthorized)
        {
        }
    }
}
