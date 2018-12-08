using Eventures.ViewModels;

namespace Eventures.Services.Contracts
{
    public interface IUserServices
    {
        UserViewModel GetUser(string id);
    }
}
