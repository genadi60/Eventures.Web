using System;
using System.Linq;
using Eventures.Models;
using Eventures.Web.InputModels;
using Eventures.Web.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly SignInManager<EventuresUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly ILogger<EventuresUser> _logger;

        public AccountServices(SignInManager<EventuresUser> signInManager, RoleManager<IdentityRole> roleManager, ILogger<EventuresUser> logger)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        public bool Create(AccountRegisterModel model)
        {
            model.Role = _signInManager.UserManager.Users.Any() ? null : "Admin";

            var role = _roleManager.Roles.FirstOrDefault(r => r.Name == model.Role);

            var user = new EventuresUser { UserName = model.Username, FirstName = model.FirstName, LastName = model.LastName, Role = role, Email = model.Email, UCN = model.UCN};

            
            var result = _signInManager.UserManager.CreateAsync(user, model.Password).Result;

            if (!result.Succeeded)
            {
                return false;
            }

            result = _signInManager.UserManager.AddToRoleAsync(user, model.Role).Result;

            if (!result.Succeeded)
            {
               return false;
            }

            _logger.LogInformation($"User {model.Username} created a new account with password on: [{DateTime.UtcNow:dd-MMM-yyyy HH:mm:ss}].");

            return true;
        }

        public bool DoLogin(AccountLoginModel model)
        {
            var user = _signInManager.UserManager.Users.FirstOrDefault(u => u.UserName == model.Username);

            if (user == null)
            {
                return false;
            }

            var result = _signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                lockoutOnFailure: false
            ).Result;

            if (result.Succeeded)
            {
                _logger.LogInformation(message: $"MyIdentity: {user.FirstName}. Logged in on: {DateTime.UtcNow:dd-MMM-yyyy HH:mm:ss}");

            }

            return true;
        }
    }
}
