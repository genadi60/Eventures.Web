using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.ViewModels
{
    public class OrderViewModel
    {
        public string EventName { get; set; }

        public string CustomerName { get; set; }

        public string OrderedOn { get; set; }

        public string EventStart { get; set; }

        public string EventEnd { get; set; }

        public int TicketsCount { get; set; }
    }
}
