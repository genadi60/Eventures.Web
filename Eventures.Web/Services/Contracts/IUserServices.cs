using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IUserServices
    {
        UserViewModel GetUser(string id);
    }
}
