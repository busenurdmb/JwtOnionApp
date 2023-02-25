using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class UpdateCategoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kategori adı gereklidir")]
        public string? Definition { get; set; }
    }
}