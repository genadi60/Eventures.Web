using System.ComponentModel.DataAnnotations;

namespace Eventures.Web.InputModels
{
    public class AccountLoginModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Username")]
        [RegularExpression(@"^([a-zA-Z0-9-_~.*]+)$", ErrorMessage = "Found illegal character(s) or White Space in Username.")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
