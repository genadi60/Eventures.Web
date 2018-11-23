using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IEventsService
    {
        bool Create(EventViewModel model);

        ICollection<EventViewModel> All();
    }
}
