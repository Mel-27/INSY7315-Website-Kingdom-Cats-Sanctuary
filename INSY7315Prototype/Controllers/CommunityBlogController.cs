using Microsoft.AspNetCore.Mvc;

namespace INSY7315Prototype.Controllers
{
    public class CommunityBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
