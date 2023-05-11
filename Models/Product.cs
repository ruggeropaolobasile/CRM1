using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        public int Quantity { get; set; }
        
        // altre proprietà necessarie

        // relazione uno a molti con ordini
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}