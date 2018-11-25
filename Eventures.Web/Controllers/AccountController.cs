using System;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.Web.InputModels;
using Eventures.Web.Services.Contracts;
using Eventures.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<EventuresUser> _signIn;

        private readonly ILogger<EventuresUser> _logger;

        private readonly IAccountServices _accountServices;

        public AccountController(SignInManager<EventuresUser> signIn, 
            ILogger<EventuresUser> logger, IAccountServices accountServices)
        {
            _signIn = signIn;
            _logger = logger;
            _accountServices = accountServices;
        }
        
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(AccountLoginModel accountLoginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(accountLoginModel);
            
            }

            bool isLogged = _accountServices.DoLogin(accountLoginModel);

                if (!isLogged)
                {
                    var errorModel = new ErrorViewModel
                    {
                        RequestId = "Username or Password incorrect."
                    };
                    return View("Error", errorModel);
                }
  
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(AccountRegisterModel model)
        {
            if (_signIn.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool isCreated = _accountServices.Create(model);

            if (!isCreated)
            {
                return View(model);
            }

            return View("~/Views/Account/Registered.cshtml");
        }

        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();

            _logger.LogInformation(message: $"EventuresUser logged out on: {DateTime.UtcNow:dd/MM/yyyy hh:mm:ss}");

            return RedirectToAction("Index", "Home");
        }
    }
}
