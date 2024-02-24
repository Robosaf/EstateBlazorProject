using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet("Login")]
        public IActionResult Index([FromQuery]string returnUrl)
        {
            var redirectUri = returnUrl == null ? Url.Content("~/") : "/" + returnUrl;

            if (User.Identity.IsAuthenticated)
            {
                return LocalRedirect(redirectUri);
            }

            return Challenge();
        }

        [HttpGet("Logout")]
        public async Task<IActionResult> LogOut([FromQuery] string returnUrl)
        {
            var redirectUri = returnUrl == null ? Url.Content("~/") : "/" + returnUrl;

            if (!User.Identity.IsAuthenticated)
            {
                return LocalRedirect(redirectUri);
            }

            await HttpContext.SignOutAsync();

            return LocalRedirect(redirectUri);
        }
    }
}
