using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Eventures.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<EventuresUser> _signInManager;
        private readonly UserManager<EventuresUser> _userManager;
        private readonly ILogger<EventuresUser> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<EventuresUser> userManager,
            SignInManager<EventuresUser> signInManager,
            ILogger<EventuresUser> logger,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(20, MinimumLength = 3)]
            [Display(Name = "Username")]
            [RegularExpression(@"^([a-zA-Z0-9-_~.*]+)$", ErrorMessage = "Found illegal character(s) or White Space in Username.")]
            [ScaffoldColumn(false)]
            public string Username { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 3)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 3)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [RegularExpression(@"^([0-9]+)$", ErrorMessage = "UCN should consist of numbers.")]
            [StringLength(10, MinimumLength = 10, ErrorMessage = "UCN should consist of exactly 10 numbers.")]
            public string UCN { get; set; }

            public string Role { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                Input.Role = _signInManager.UserManager.Users.Any() ? "User" : "Admin";

                var role = _roleManager.Roles.FirstOrDefault(r => r.Name == Input.Role);

                var user = new EventuresUser
                {
                    UserName = Input.Username,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    RoleId = role?.Id,
                    Email = Input.Email,
                    UCN = Input.UCN
                };
                
                var result = await  _userManager.CreateAsync(user, Input.Password);

                if (!result.Succeeded)
                {
                    return null;
                }

                result = _signInManager.UserManager.AddToRoleAsync(user, Input.Role).Result;

                if (!result.Succeeded)
                {
                    return null;
                }

                if (result.Succeeded)
                {
                    _logger.LogInformation($"User {Input.Username} created a new account with password on: [{DateTime.UtcNow:dd-MMM-yyyy HH:mm:ss}].");

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
