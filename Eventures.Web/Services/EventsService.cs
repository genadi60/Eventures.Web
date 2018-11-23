using System;
using System.Collections.Generic;
using System.Linq;
using Eventures.Data;
using Eventures.Models;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext _context;
        public EventsService(EventuresDbContext context)
        {
            _context = context;
        }

        public bool Create(EventViewModel model)
        {
            if (model == null)
            {
                return false;
            }
            var eventModel = new Event
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Place = model.Place,
                Start = DateTime.Parse(model.Start),
                End = DateTime.Parse(model.End),
                TotalTickets = model.TotalTickets,
                PricePerTicket = model.PricePerTicket
            };

            _context.Events.Add(eventModel);
            _context.SaveChanges();

            return true;
        }

        public ICollection<EventViewModel> All()
        {
            return _context.Events
                .Select(e => new EventViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Place = e.Place,
                    Start = e.Start.ToString("dd-MMM-yy HH:mm"),
                    End = e.End.ToString("dd-MMM-yy HH:mm"),
                    TotalTickets = e.TotalTickets,
                    PricePerTicket = e.PricePerTicket
                })
                .ToList();
        }
    }
}
