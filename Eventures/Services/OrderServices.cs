using System;
using System.Collections.Generic;
using System.Linq;
using Eventures.Data;
using Eventures.InputModels;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels;

namespace Eventures.Services
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

        public bool ById(string id)
        {
            return _context.Events.Any(e => e.Id.Equals(id));
        }
    }
}
