using Microsoft.AspNetCore.Mvc;

namespace SaccoDashboard.Models.Auth
{
    public class JwtResponseVm : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
