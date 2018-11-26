using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventures.Models
{
    public class Order
    {
        public string Id { get; set; }

        public DateTime OrderedOn { get; set; }

        [Required]
        public string CustomerId { get; set; }
        public EventuresUser Customer { get; set; }

        [Required]
        public string EventId { get; set; }
        public Event Event { get; set; }

        public int TicketsCount { get; set; }
    }
}
