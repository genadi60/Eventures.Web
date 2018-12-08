using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventures.Models
{
    public class Event
    {
        public string Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public int TotalTickets { get; set; }

        [Required]
        public decimal PricePerTicket { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
