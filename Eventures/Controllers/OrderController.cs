using Eventures.Exceptions;
using Eventures.InputModels;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{

    public class OrderController : Controller
    {
        private readonly UserManager<EventuresUser> _userManager;

        private readonly IOrderServices _orderServices; 

        public OrderController(UserManager<EventuresUser> userManager, IOrderServices orderServices)
        {
            _userManager = userManager;
            _orderServices = orderServices;
        }

        public IActionResult Create()
        {
           return View("~/Views/Event/AllEvents.cshtml");
        }

        [HttpPost]
        public IActionResult Create(int tickets, string eventId)
        {
            if (!_orderServices.ById(eventId))
            {
                const string message = "Event not found";
                const string description = "Please check your Event properties.";
                throw new NotFoundCustomException(message, description);
            }

            var orderViewModel = new OrderCreateModel()
            {
                EventId = eventId,
                Tickets = tickets,
                CustomerId = _userManager.GetUserId(User)
            };

            if (!_orderServices.Create(orderViewModel))
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("MyEvents", "User");
        }

        public IActionResult All()
        {
            var collection = _orderServices.All();

            var allOrdersViewModel = new AllOrdersViewModel
            {
                Orders = collection
            };

            return View("~/Views/Order/AllOrders.cshtml", allOrdersViewModel);
        }
    }
}
