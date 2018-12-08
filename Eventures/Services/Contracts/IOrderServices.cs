using System.Collections.Generic;
using Eventures.InputModels;
using Eventures.ViewModels;

namespace Eventures.Services.Contracts
{
    public interface IOrderServices
    {
        bool Create(OrderCreateModel model);

        ICollection<OrderViewModel> All();

        bool ById(string id);
    }
}
