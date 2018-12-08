using System.Collections.Generic;

namespace Eventures.ViewModels
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

        public virtual ICollection<OrderViewModel> Events { get; set; } = new List<OrderViewModel>();
    }
}
