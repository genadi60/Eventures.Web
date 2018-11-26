using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.Web.InputModels;
using Eventures.Web.Services;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;
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

        [HttpPost]
        public IActionResult Create()
        {
            var result = Request.Form;
            var eventId = result.Keys.First();
            var ticketsCount = result[eventId];

            var orderViewModel = new OrderCreateModel()
            {
                EventId = eventId,
                Tickets = int.Parse(ticketsCount),
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
