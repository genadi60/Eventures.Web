using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eventures.Models;
using Eventures.ViewModels;
using Microsoft.AspNetCore.Identity;
using Eventures.Areas.Identity.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eventures.Controllers
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
            
            return RedirectToAction("Index", "User");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorModel = new ErrorModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier};
            return View("~/Areas/Identity/Pages/Error.cshtml",errorModel);
        }
    }
}
