using System.ComponentModel.DataAnnotations;

namespace Vitae.ViewModel
{
    public class AuthViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
