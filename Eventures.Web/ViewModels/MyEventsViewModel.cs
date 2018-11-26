using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.ViewModels
{
    public class MyEventsViewModel
    {
        public virtual ICollection<OrderViewModel> Events { get; set; } = new List<OrderViewModel>();
    }
}
