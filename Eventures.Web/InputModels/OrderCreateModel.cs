using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.InputModels
{
    public class OrderCreateModel
    {
        public string EventId { get; set; }

        public string CustomerId { get; set; }

        public DateTime OrderedOn { get; set; }

        public int Tickets { get; set; }
    }
}
