using System.Collections.Generic;
using Eventures.Models;
using Eventures.Web.InputModels;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Web.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UCN { get; set; }

        public string RoleId { get; set; }

        public virtual ICollection<EventCreateModel> Events { get; set; }
    }
}
