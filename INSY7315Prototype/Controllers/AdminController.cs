using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}