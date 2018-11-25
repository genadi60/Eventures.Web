using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Web.InputModels
{
    public class EventCreateModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Place { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime End { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        [Range(typeof(decimal), minimum:"0.01", maximum:"79228162514264337593543950335")]
        public decimal PricePerTicket { get; set; }
    }
}
