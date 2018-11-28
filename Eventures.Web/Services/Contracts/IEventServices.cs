using System.Collections.Generic;
using Eventures.Web.InputModels;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IEventServices
    {
        bool Create(EventCreateModel model);

        ICollection<EventViewModel> All();
        
    }
}
