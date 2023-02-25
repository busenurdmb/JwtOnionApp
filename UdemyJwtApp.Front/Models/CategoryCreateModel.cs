using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class CategoryCreateModel
    {
        [Required(ErrorMessage = "Kategori adı gereklidir")]
        public string? Definition { get; set; } = null!;
    }
}