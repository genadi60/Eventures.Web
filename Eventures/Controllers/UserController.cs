using System;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<EventuresUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IUserServices _userServices;

        private readonly ILogger<EventuresUser> _logger;

        public UserController(SignInManager<EventuresUser> signInManager, IUserServices userServices,RoleManager<IdentityRole> roleManager, ILogger<EventuresUser> logger)
        {
            _signInManager = signInManager;
            _userServices = userServices;
            _roleManager = roleManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            var userId = _signInManager.UserManager.GetUserId(User);

            var userViewModel = _userServices.GetUser(userId);

            var role = _roleManager.Roles.FirstOrDefault(r => r.Id == userViewModel.RoleId);

            if (userId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (role != null && role.Name == "Admin")
            {
                return View("~/Views/User/AdminHome.cshtml", userViewModel);
            }

            return View("~/Views/User/UserHome.cshtml", userViewModel);
        }

        public IActionResult  MyEvents()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            var userId = _signInManager.UserManager.GetUserId(User);

            var userViewModel = _userServices.GetUser(userId);

            //var role = _roleManager.Roles.FirstOrDefault(r => r.Id == userViewModel.RoleId);

            if (userId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("~/Views/User/MyEvents.cshtml", userViewModel);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            _logger.LogInformation(message: $"EventuresUser {User.Identity.Name} logged out on: {DateTime.UtcNow:dd/MM/yyyy hh:mm:ss}");

            return RedirectToAction("Index", "Home");
        }
    }
}
