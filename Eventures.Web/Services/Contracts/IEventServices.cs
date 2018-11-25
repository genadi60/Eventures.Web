using Eventures.Web.ViewModels;
using System.Collections.Generic;
using Eventures.Web.InputModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IEventServices
    {
        bool Create(EventCreateModel model);

        ICollection<EventViewModel> All();
        
    }
}
