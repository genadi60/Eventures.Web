using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Models
{
    public class EventuresUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UCN { get; set; }

        [Required]
        public string RoleId { get; set; }
        public virtual  IdentityRole Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
