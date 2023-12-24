using System.ComponentModel.DataAnnotations;

namespace GuardianGateAPI.Models
{
    public class UserLogInRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }
}
