using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using INSY7315Prototype.Data;
using INSY7315Prototype.Models;
using System.Threading.Tasks;

namespace INSY7315Prototype.Controllers
{
    public class DonationsController : Controller
    {
        private readonly KingdomCatsDb _context;

        public DonationsController(KingdomCatsDb context)
        {
            _context = context;
        }

        // GET: /Donations
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Donations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Donation donation)
        {
            if (!ModelState.IsValid)
            {
                TempData["DonationError"] = "Please check your details and try again.";
                return RedirectToAction(nameof(Index));
            }

            _context.Donations.Add(donation);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Confirmation), new { id = donation.Id });
        }

        // GET: /Donations/Confirmation/5
        public async Task<IActionResult> Confirmation(int id)
        {
            var donation = await _context.Donations.FindAsync(id);
            if (donation == null) return NotFound();

            return View(donation);
        }
    }
}