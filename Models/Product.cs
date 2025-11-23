using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHandMarket.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Kategori ilişkisi
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // Ürünün sahibi (Identity User)
        public string OwnerId { get; set; } = null!;
        public ApplicationUser Owner { get; set; } = null!;

        // Resim yolu
        public string? ImagePath { get; set; }
    }
}
