using System.Net;

namespace Eventures.Exceptions
{
    public class UnauthorizedCustomException : BaseCustomException
    {
        public UnauthorizedCustomException(string message, string description) : base(message, description, (int)HttpStatusCode.Unauthorized)
        {
        }
    }
}
