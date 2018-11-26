using Eventures.Web.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IOrderServices
    {
        bool Create(OrderCreateModel model);

        ICollection<OrderViewModel> All();
    }
}
