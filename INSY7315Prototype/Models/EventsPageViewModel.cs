namespace INSY7315Prototype.Models
{
    public class EventsPageViewModel
    {
        public List<EventItem> Events { get; set; } = new();
        public ImpactSummary Impact { get; set; } = new();
    }

    public class EventItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }                  
        public string DateDisplay { get; set; } = string.Empty;  
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty; 
        public string Cause { get; set; } = string.Empty;         
        public decimal? Price { get; set; }
        public string? PhotoUrl { get; set; }
        public bool IsMostPopular { get; set; }
    }

    public class ImpactSummary
    {
        public int Id { get; set; }
        public decimal AmountRaised { get; set; }
        public string PeriodLabel { get; set; } = "Impact Last Month";
        public string Description { get; set; } = string.Empty; 
    }
}