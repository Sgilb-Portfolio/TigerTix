using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using System;

namespace TigerTix.Web.Controllers
{
    public class AppController : Controller
    {

        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: App/FAQ
        public IActionResult FAQ()
        {
            return View();
        }

        // GET: App/Login
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        // POST: App/Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "1")
                {
                    // Logic for admin authentication
                    await SignInUser(model.Username, "Admin");
                    //return RedirectToAction("AdminDashboard"); // Redirect to the admin dashboard
                    // Take the user back to the homepage
                    return RedirectToAction("Index");

                }
                else if (model.Password.Length == 8 && int.TryParse(model.Password, out _))
                {
                    // Logic for user authentication with any 8-digit password
                    await SignInUser(model.Username, "User");
                    //return RedirectToAction("UserDashboard"); // Redirect to the user dashboard
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }
            return View(model);
        }

        private async Task SignInUser(string username, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal,
                new AuthenticationProperties { IsPersistent = true });
        }

        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}
