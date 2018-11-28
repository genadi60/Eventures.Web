using System.Collections.Generic;
using Eventures.Web.InputModels;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IOrderServices
    {
        bool Create(OrderCreateModel model);

        ICollection<OrderViewModel> All();

        bool ById(string id);
    }
}
