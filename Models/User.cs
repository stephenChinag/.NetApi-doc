using System.ComponentModel.DataAnnotations;

namespace UserRegistrationApp.Models
{
    public class User
    {

        [Required, StringLength(50)]
        public string? FullName { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }
        [Required, MinLength(6)]
        public string? Password { get; set; }
    }
}