using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace INSY7315Prototype.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int? CatId { get; set; }

        [BindNever, ValidateNever]
        public string SessionType { get; set; }

        public DateTime BookingDate { get; set; }
        public string TimeSlot { get; set; }
        public string ParticipantName { get; set; }
        public string ParticipantEmail { get; set; }

        [BindNever, ValidateNever]
        public string Status { get; set; } = "Confirmed";
    }
}