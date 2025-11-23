using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SecondHandMarket.Models.ViewModels
{
    public class ProductCreateViewModel
    {
        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0, 999999)]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public IFormFile? ImageFile { get; set; }

        // Dropdown için
        public IEnumerable<Category>? Categories { get; set; }
    }
}
