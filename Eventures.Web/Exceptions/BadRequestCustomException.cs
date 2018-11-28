using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Eventures.Web.Exceptions
{
    public class BadRequestCustomException : BaseCustomException
    {
        public BadRequestCustomException(string message, string description) : base(message, description, (int)HttpStatusCode.BadRequest)
        {
        }
    }
}
