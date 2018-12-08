using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Eventures.Areas.Identity.Pages
{
    [AllowAnonymous]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Message { get; private set; }
        
        public string Description { get; private set; }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var errorMessage = HttpContext.Request.Query["ErrorMessage"].ToString();
            var errorMessageTokens = errorMessage.Split(";");
            Message = errorMessageTokens[0];
            var descriptionTokens = errorMessageTokens[1].Split("=");
            Description = descriptionTokens[1];
        }
    }
}
