using System.ComponentModel.DataAnnotations;

namespace INSY7315Prototype.Models
{
    public class User
    {
        [Key] 
        public int userId { get; set; }
    
        [Required]
        public string fullName { get; set; }   = string.Empty;


        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
      

    }
}
