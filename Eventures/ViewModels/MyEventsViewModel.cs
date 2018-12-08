using System.Collections.Generic;

namespace Eventures.ViewModels
{
    public class MyEventsViewModel
    {
        public virtual ICollection<OrderViewModel> Events { get; set; } = new List<OrderViewModel>();
    }
}
