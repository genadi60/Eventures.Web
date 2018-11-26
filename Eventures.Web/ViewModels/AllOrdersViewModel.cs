using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.ViewModels
{
    public class AllOrdersViewModel
    {
        public ICollection<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
