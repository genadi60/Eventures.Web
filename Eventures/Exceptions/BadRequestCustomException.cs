using System.Net;

namespace Eventures.Exceptions
{
    public class BadRequestCustomException : BaseCustomException
    {
        public BadRequestCustomException(string message, string description) : base(message, description, (int)HttpStatusCode.BadRequest)
        {
        }
    }
}
