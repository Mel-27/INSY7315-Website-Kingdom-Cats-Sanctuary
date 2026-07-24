using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
