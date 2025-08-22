using System.ComponentModel.DataAnnotations;

namespace ProductInventorySystem.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Category { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}
