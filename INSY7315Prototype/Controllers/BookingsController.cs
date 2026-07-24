using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class BookingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
