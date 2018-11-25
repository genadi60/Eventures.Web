using System.ComponentModel.DataAnnotations;

namespace Eventures.Web.InputModels
{
    public class AccountRegisterModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Username")]
        [RegularExpression(@"^([^a-zA-Z0-9-_~.*]+)$", ErrorMessage = "Found illegal character(s) or White Space in Username.")]
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
        [RegularExpression(@"^([^0-9]+)$")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "UCN should consist of exactly 10 numbers.")]
        public string UCN { get; set; }

        public string Role { get; set; }
    }
}
