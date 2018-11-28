using Eventures.Web.InputModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IAccountServices
    {
        bool Create(AccountRegisterModel model);

        bool DoLogin(AccountLoginModel model);
    }
}
