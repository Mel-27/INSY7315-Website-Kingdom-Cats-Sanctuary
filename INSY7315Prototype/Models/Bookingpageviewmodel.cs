using System.Collections.Generic;

namespace INSY7315Prototype.Models
{
    public class Bookingpageviewmodel
    {
        public string Label { get; set; }
        public string TimeRange { get; set; }
        public bool IsFullyBooked { get; set; }
    }

    public class BookingPageViewModel
    {
        public int? CatId { get; set; }
        public string CatName { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }
        public string MonthName { get; set; }

        // Each inner list is one calendar week (7 cells); null = blank filler cell
        public List<List<int?>> CalendarWeeks { get; set; } = new();

        public List<Bookingpageviewmodel> TimeSlots { get; set; } = new();

        // Month navigation
        public int PrevMonth { get; set; }
        public int PrevYear { get; set; }
        public int NextMonth { get; set; }
        public int NextYear { get; set; }
        public bool CanGoPrev { get; set; }
    }
}