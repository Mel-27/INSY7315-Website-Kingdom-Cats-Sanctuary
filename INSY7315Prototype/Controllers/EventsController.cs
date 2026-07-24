using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
