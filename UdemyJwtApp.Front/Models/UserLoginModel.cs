using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "username gerekli")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "password gerekli")]
        public string Password { get; set; } = null!;
    }
}