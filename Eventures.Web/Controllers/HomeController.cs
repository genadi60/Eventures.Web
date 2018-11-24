using System.Diagnostics;
using Eventures.Models;
using Eventures.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<EventuresUser> _signInManager;

        public HomeController(SignInManager<EventuresUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return View(); 
            }
            
            return RedirectToAction("Index", "Users");
        }
    }
}
