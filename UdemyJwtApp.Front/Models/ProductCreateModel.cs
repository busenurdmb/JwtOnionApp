using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class ProductCreateModel
    {
        [Required(ErrorMessage = "Ürün adı boş geçilemez")]
        public string? Name { get; set; }
<<<<<<< HEAD

        [Required(ErrorMessage = "Stok boş geçilemez")]

        public int Stock { get; set; }

        [Required(ErrorMessage = "Fiyat boş geçilemez")]

        public decimal Price { get; set; }

=======
       
        [Required(ErrorMessage = "Stok boş geçilemez")]

        public int Stock { get; set; }
        
        [Required(ErrorMessage = "Fiyat boş geçilemez")]

        public decimal Price { get; set; }
      
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        [Required(ErrorMessage = "Kategori seçimi yapınız")]
        public int CategoryId { get; set; }
        public SelectList? Categories { get; set; }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
