using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IAccountServices
    {
        bool Create(RegisterViewModel model);

        bool DoLogin(LoginViewModel model);
    }
}
