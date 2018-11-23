using System.Collections.Generic;

namespace Eventures.Web.ViewModels
{
    public class AllEventsViewModel
    {
        public virtual ICollection<EventViewModel> Events { get; set; } = new List<EventViewModel>();
    }
}
