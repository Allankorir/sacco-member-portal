using Microsoft.AspNetCore.Mvc;
using SaccoDashboard.Models.Auth;

namespace SaccoDashboard.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVm model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction(
                "Index",
                "Dashboard");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVm model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction(
                "Login",
                "Account");
        }
    }
}