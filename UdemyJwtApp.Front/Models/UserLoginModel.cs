using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class UserLoginModel
    {
<<<<<<< HEAD
        [Required(ErrorMessage = "username gerekli")]
=======
        [Required(ErrorMessage ="username gerekli")]
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "password gerekli")]
        public string Password { get; set; } = null!;
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
