using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class UpdateCategoryModel
    {
        public int Id { get; set; }
<<<<<<< HEAD
        [Required(ErrorMessage = "Kategori adı gereklidir")]
        public string? Definition { get; set; }
    }
}
=======
        [Required(ErrorMessage ="Kategori adı gereklidir")]
        public string? Definition { get; set; }
    }
}
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
