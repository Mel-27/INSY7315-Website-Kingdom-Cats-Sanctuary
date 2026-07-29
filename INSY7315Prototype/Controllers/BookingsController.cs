using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using INSY7315Prototype.Data;
using INSY7315Prototype.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INSY7315Prototype.Controllers
{
    public class BookingsController : Controller
    {
        private readonly KingdomCatsDb _context;

        public BookingsController(KingdomCatsDb context)
        {
            _context = context;
        }

    
        public async Task<IActionResult> Index(int? catId, int? month, int? year)
        {
            var vm = new BookingPageViewModel { CatId = catId };
            if (catId.HasValue)
            {
                var cat = await _context.Cats.FindAsync(catId.Value);
                vm.CatName = cat?.Name;
            }

            var today = DateTime.Today;
            int targetMonth = month ?? today.Month;
            int targetYear = year ?? today.Year;

            // Don't allow navigating before the current month
            if (new DateTime(targetYear, targetMonth, 1) < new DateTime(today.Year, today.Month, 1))
            {
                targetMonth = today.Month;
                targetYear = today.Year;
            }

            vm.Month = targetMonth;
            vm.Year = targetYear;
            vm.MonthName = new DateTime(targetYear, targetMonth, 1).ToString("MMMM yyyy");

            var firstOfMonth = new DateTime(targetYear, targetMonth, 1);
            var daysInMonth = DateTime.DaysInMonth(targetYear, targetMonth);
            int startOffset = (int)firstOfMonth.DayOfWeek;
            var days = new List<int?>();
            for (int i = 0; i < startOffset; i++) days.Add(null);
            for (int d = 1; d <= daysInMonth; d++) days.Add(d);
            while (days.Count % 7 != 0) days.Add(null);
            for (int i = 0; i < days.Count; i += 7)
                vm.CalendarWeeks.Add(days.GetRange(i, 7));

            var prev = firstOfMonth.AddMonths(-1);
            var next = firstOfMonth.AddMonths(1);
            vm.PrevMonth = prev.Month;
            vm.PrevYear = prev.Year;
            vm.NextMonth = next.Month;
            vm.NextYear = next.Year;
            vm.CanGoPrev = prev >= new DateTime(today.Year, today.Month, 1);

            vm.TimeSlots = new List<Bookingpageviewmodel>
    {
        new Bookingpageviewmodel { Label = "Morning Bliss", TimeRange = "10:00 AM - 10:45 AM" },
        new Bookingpageviewmodel { Label = "Coffee & Cats", TimeRange = "11:30 AM - 12:15 PM" },
        new Bookingpageviewmodel { Label = "Golden Hour Purrs", TimeRange = "01:00 PM - 01:45 PM" },
    };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Booking booking)
        {
            booking.SessionType = booking.CatId.HasValue ? "Adoption Viewing" : "Kitten Petting Session";
            booking.Status = "Confirmed";

            if (!ModelState.IsValid)
            {
                TempData["BookingError"] = "Please check your details and try again.";
                return RedirectToAction(nameof(Index), new { catId = booking.CatId });
            }

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Confirmation), new { id = booking.Id });
        }

        // GET: /Bookings/Confirmation/5
        public async Task<IActionResult> Confirmation(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null) return NotFound();

            if (booking.CatId.HasValue)
            {
                var cat = await _context.Cats.FindAsync(booking.CatId.Value);
                ViewBag.CatName = cat?.Name;
            }

            return View(booking);
        }
    }
}