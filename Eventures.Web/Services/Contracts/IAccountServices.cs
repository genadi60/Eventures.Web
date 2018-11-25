using Eventures.Web.InputModels;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IAccountServices
    {
        bool Create(AccountRegisterModel model);

        bool DoLogin(AccountLoginModel model);
    }
}
