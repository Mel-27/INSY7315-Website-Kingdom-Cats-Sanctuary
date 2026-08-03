using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace INSY7315Prototype.Models
{
    public class Donation
    {
        public int Id { get; set; }

        public string DonorName { get; set; }
        public string DonorEmail { get; set; }
        public decimal Amount { get; set; }

        // "PayPal" or "Ozow"
        public string PaymentMethod { get; set; }

        [BindNever, ValidateNever]
        public DateTime DonatedOn { get; set; } = DateTime.UtcNow;
        
        //Status defaults to "Pending" rather than "Confirmed"
        //have no real payment gateway wired up yet, so nothing has actually been paid.
        [BindNever, ValidateNever]
        public string Status { get; set; } = "Pending";
    }
}