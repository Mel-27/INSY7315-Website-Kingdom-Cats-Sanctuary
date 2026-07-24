using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class MerchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
