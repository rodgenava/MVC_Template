using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ASPdotNetCoreWebApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous] // Allows unauthenticated access
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Example: hard-coded validation; replace with actual user verification
            if (username == "admin" && password == "password")
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin") // Add roles if necessary
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties
                    {
                        IsPersistent = true, // Keeps the user logged in after closing the browser
                        //IsPersistent = false, 
                    });

                return RedirectToAction("Index", "Home");
            }

            // If login fails, show error
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }

        [Authorize] // Only accessible to authenticated users
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
