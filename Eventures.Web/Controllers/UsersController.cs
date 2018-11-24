using System;
using System.Linq;
using Eventures.Data;
using Eventures.Models;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<EventuresUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IUserServices _userServices;

        public UsersController(SignInManager<EventuresUser> signInManager, IUserServices userServices,RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userServices = userServices;
            _roleManager = roleManager;
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
                return View("~/Views/Users/AdminHome.cshtml", userViewModel);
            }

            return View("~/Views/Users/UserHome.cshtml", userViewModel);
        }
    }
}
