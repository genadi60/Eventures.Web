using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Models
{
    public class EventuresUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UCN { get; set; }

        public string RoleId { get; set; }
        public virtual  IdentityRole Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
