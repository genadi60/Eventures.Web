using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data;
using Eventures.Models;
using Eventures.Web.InputModels;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly EventuresDbContext _context;

        public OrderServices(EventuresDbContext context)
        {
            _context = context;
        }

        public bool Create(OrderCreateModel model)
        {
            var order = new Order
            {
                EventId = model.EventId,
                CustomerId = model.CustomerId,
                TicketsCount = model.Tickets,
                OrderedOn = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return true;
        }

        public ICollection<OrderViewModel> All()
        {
            return _context.Orders
                .Select(o => new OrderViewModel
                {
                    EventName = o.Event.Name,
                    CustomerName = o.Customer.FirstName,
                    OrderedOn = o.OrderedOn.ToString("dd-MMM-yy HH:mm:ss")
                })
                .ToList();
        }
    }
}
