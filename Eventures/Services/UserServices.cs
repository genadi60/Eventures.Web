using System.Linq;
using Eventures.Data;
using Eventures.Services.Contracts;
using Eventures.ViewModels;

namespace Eventures.Services
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
            var user = _context.EventuresUsers.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return null;
            }
            var myEvents = _context.Orders
                .Where(o => o.CustomerId == user.Id)
                .Select(e => new OrderViewModel()
                {
                    EventName = e.Event.Name,
                    EventStart = e.Event.Start.ToString("dd-MMM-yy HH:mm:ss"),
                    EventEnd = e.Event.End.ToString("dd-MMM-yy HH:mm:ss"),
                    TicketsCount = e.TicketsCount
                })
                .ToList();

            var userViewModel = new UserViewModel
                
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    RoleId = user.RoleId,
                    UCN = user.UCN,
                    Events = myEvents
                };

            return userViewModel;
        }
    }
}
