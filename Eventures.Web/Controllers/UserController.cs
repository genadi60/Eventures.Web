using System.Linq;
using Eventures.Models;
using Eventures.Web.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<EventuresUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IUserServices _userServices;

        public UserController(SignInManager<EventuresUser> signInManager, IUserServices userServices,RoleManager<IdentityRole> roleManager)
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
                return View("~/Views/User/AdminHome.cshtml", userViewModel);
            }

            return View("~/Views/User/UserHome.cshtml", userViewModel);
        }
    }
}
