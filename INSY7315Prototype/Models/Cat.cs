using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace INSY7315Prototype.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AgeDisplay { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string? Badge { get; set; }
        public string? TagsCsv { get; set; }
        public string? PhotoUrl { get; set; }
        public string AdoptionStatus { get; set; } = "Available";

        [NotMapped]
        public List<string> Tags
        {
            get => string.IsNullOrEmpty(TagsCsv)
                ? new List<string>()
                : TagsCsv.Split(',').Select(t => t.Trim()).ToList();
            set => TagsCsv = value == null ? null : string.Join(",", value);
        }
    }
}