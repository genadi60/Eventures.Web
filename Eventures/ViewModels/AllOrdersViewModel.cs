using System.Collections.Generic;

namespace Eventures.ViewModels
{
    public class AllOrdersViewModel
    {
        public ICollection<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
