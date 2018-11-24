using Eventures.Data;
using Eventures.Web.Filters;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsService _eventsService;
        private readonly EventuresDbContext _context;
        private readonly ILogger<EventsController> _logger;

        public EventsController(IEventsService eventsService, EventuresDbContext
            context, ILogger<EventsController> logger)
        {
            _eventsService = eventsService;
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
        public IActionResult Create(EventViewModel model)
        {
            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!_eventsService.Create(model))
            {
                return View(model);
            }

            _logger.LogInformation("Event created: " + model.Name, model );

            return RedirectToAction(nameof(All));
        }

        
        public IActionResult All()
        {
            var collection = _eventsService.All();

            var allEventsViewModel = new AllEventsViewModel
            {
                Events = collection
            };
            
            return View("~/Views/Events/AllEvents.cshtml", allEventsViewModel);
        }
    }
}
