using System.ComponentModel.DataAnnotations;

namespace Pratik_IdentityandDataProtection.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
