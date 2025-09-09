using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace DxBlazorApplicationScheduler.Login
{
    [Microsoft.AspNetCore.Mvc.Route("account")]
    public class LoginController : Controller
    {
        readonly UserAccountService _userAccountService;

        public LoginController(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] string username, string password)
        {
            if (username == null)
            {
                return new BadRequestResult();
            }

            var user = _userAccountService.GetByUserName(username);

            if (user == null || user.Password != password)
            {
                return new NotFoundResult();
            }

            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Role, user.Role)
        };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name,
    ClaimTypes.Role);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return Redirect("/");
        }
    }



}
