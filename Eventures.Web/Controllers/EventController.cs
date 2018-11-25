using Eventures.Data;
using Eventures.Web.Filters;
using Eventures.Web.InputModels;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventServices _eventServices;
        private readonly EventuresDbContext _context;
        private readonly ILogger<EventController> _logger;

        public EventController(IEventServices eventServices, EventuresDbContext
            context, ILogger<EventController> logger)
        {
            _eventServices = eventServices;
            _context = context;
            _logger = logger;
        }

        public IActionResult Create()
        {
            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
           
        }

        [TypeFilter(typeof(AdminCreateEventActionFilter))]
        [HttpPost]
        public IActionResult Create(EventCreateModel model)
        {
            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!_eventServices.Create(model))
            {
                return View(model);
            }

            _logger.LogInformation("Event created: " + model.Name, model );

            return RedirectToAction(nameof(All));
        }

        
        public IActionResult All()
        {
            var collection = _eventServices.All();

            var allEventsViewModel = new AllEventsViewModel
            {
                Events = collection
            };
            
            return View("~/Views/Event/AllEvents.cshtml", allEventsViewModel);
        }
    }
}
