using System;

namespace Eventures.InputModels
{
    public class OrderCreateModel
    {
        public string EventId { get; set; }
        
        public string CustomerId { get; set; }

        public DateTime OrderedOn { get; set; }

        public int Tickets { get; set; }
    }
}
