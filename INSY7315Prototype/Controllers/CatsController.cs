using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
