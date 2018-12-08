using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Eventures.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<EventuresUser> _signInManager;
        private readonly ILogger<EventuresUser> _logger;

        public LogoutModel(SignInManager<EventuresUser> signInManager, ILogger<EventuresUser> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPost()
        {
            await _signInManager.SignOutAsync();

            _logger.LogInformation(message: $"User {User.Identity.Name} logged out on: {DateTime.UtcNow:dd/MM/yyyy hh:mm:ss}");

            return RedirectToAction("Index", "Home");
        }
    }
}