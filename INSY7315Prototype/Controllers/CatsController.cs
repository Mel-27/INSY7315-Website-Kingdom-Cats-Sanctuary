using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using INSY7315Prototype.Data;
using System.Threading.Tasks;

namespace INSY7315Prototype.Controllers
{
    public class CatsController : Controller
    {
        private readonly KingdomCatsDb _context;

        public CatsController(KingdomCatsDb context)
        {
            _context = context;
        }

        // GET: /Cats
        public async Task<IActionResult> Index()
        {
            var cats = await _context.Cats.ToListAsync();
            return View(cats);
        }
    }
}