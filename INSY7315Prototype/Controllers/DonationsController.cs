using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class DonationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
