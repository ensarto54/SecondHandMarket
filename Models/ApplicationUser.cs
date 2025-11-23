using Microsoft.AspNetCore.Identity;

namespace SecondHandMarket.Models
{
    public class ApplicationUser : IdentityUser
    {
        // İleride profil alanı eklemek istersen buraya ekleyebilirsin
        // public string? FullName { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
