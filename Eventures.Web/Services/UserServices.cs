using System.Linq;
using Eventures.Data;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services
{
    public class UserServices : IUserServices
    {
        private readonly EventuresDbContext _context;

        public UserServices(EventuresDbContext context)
        {
            _context = context;
        }
        public UserViewModel GetUser(string id)
        {
            var user = _context.EventuresUsers.Single(u => u.Id == id);

            var userViewModel = new UserViewModel
                
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    RoleId = user.RoleId,
                    UCN = user.UCN
                };

            return userViewModel;
        }
    }
}
