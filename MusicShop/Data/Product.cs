using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
