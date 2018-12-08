using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Eventures.Filters
{
    public class AdminCreateEventActionFilter : IActionFilter
    {
        private readonly ILogger<AdminCreateEventActionFilter> _logger;

        public AdminCreateEventActionFilter(ILogger<AdminCreateEventActionFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.Log(LogLevel.Information,
                $"[{DateTime.UtcNow}] Administrator {context.HttpContext.User.Identity.Name} create event {context.ModelState["Name"].RawValue} ({context.ModelState["Start"].RawValue} / {context.ModelState["End"].RawValue}).");
        }
    }
}
