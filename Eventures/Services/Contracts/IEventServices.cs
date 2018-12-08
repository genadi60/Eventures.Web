using System.Collections.Generic;
using Eventures.InputModels;
using Eventures.ViewModels;

namespace Eventures.Services.Contracts
{
    public interface IEventServices
    {
        bool Create(EventCreateModel model);

        ICollection<EventViewModel> All();
        
    }
}
