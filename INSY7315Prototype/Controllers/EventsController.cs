using Microsoft.AspNetCore.Mvc;
using INSY7315Prototype.Models;

namespace INSY7315Prototype.Controllers
{
    public class EventsController : Controller
    {
        // GET: /Events
        // NOTE: using static dummy data for now, not the database — this is
        // purely for page design/layout. Swap back to KingdomCatsDb once the
        // EventDate migration issue is sorted out.
        public IActionResult Index()
        {
            var viewModel = new EventsPageViewModel
            {
                Events = new List<EventItem>
                {
                    new EventItem
                    {
                        Id = 1,
                        Title = "Nip, Sip & Paint — International Cats Day",
                        EventDate = new DateTime(2026, 8, 8, 10, 30, 0),
                        DateDisplay = "Saturday, 8 August 2026 • 10:30 AM",
                        Description = "Come celebrate International Cats Day with us! Sip a coffee or mimosa, get creative on canvas, and spend the morning with our sanctuary cats. Includes a beverage, catnip, canvas, and paint — please bring a blanket to sit on.",
                        Location = "Kingdom Cats Sanctuary",
                        Cause = "Sanctuary Fundraiser",
                        Price = 100.00m,
                        PhotoUrl = "/images/nipSipPaint.jpeg",
                        IsMostPopular = true
                    },
                    new EventItem
                    {
                        Id = 2,
                        Title = "Golden Hours Family Market",
                        EventDate = new DateTime(2026, 7, 19, 10, 0, 0),
                        DateDisplay = "Sunday, 19 July 2026 • 10:00 AM – 3:00 PM",
                        Description = "Join us at the Golden Hours Family Market for a morning of shopping, music, and family fun — come find our stall and say hello to the team.",
                        Location = "21 Uitsig Road, Durban North",
                        Cause = "Community Market",
                        Price = null,
                        PhotoUrl = "/images/goldenHoursMarket.jpeg",
                        IsMostPopular = false
                    },
                    new EventItem
                    {
                        Id = 3,
                        Title = "Spring Purrathon",
                        EventDate = new DateTime(2026, 9, 11, 18, 0, 0),
                        DateDisplay = "Friday, 11 September 2026 • Overnight at the Sanctuary",
                        Description = "Spend all night in the enclosure with the kitties! Bring your own bedding, sleeping bag, pillow, and torch, and enjoy a night surrounded by love, purrs, and paws.",
                        Location = "37 Jeanne Howes Place, Crestholme",
                        Cause = "Sanctuary Fundraiser",
                        Price = null,
                        PhotoUrl = "/images/springPurrathon.jpeg",
                        IsMostPopular = false
                    }
                }.OrderBy(e => e.EventDate).ToList(),
                Impact = new ImpactSummary
                {
                    AmountRaised = 12450,
                    PeriodLabel = "Impact Last Month",
                    Description = ""
                }
            };

            return View(viewModel);
        }

        // GET: /Events/Rsvp/5
        public IActionResult Rsvp(int id)
        {
            return View();
        }
    }
}