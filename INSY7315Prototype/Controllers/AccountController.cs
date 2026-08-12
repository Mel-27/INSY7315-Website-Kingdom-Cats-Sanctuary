using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}
    }
}