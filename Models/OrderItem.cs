using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int OrderId { get; set; }
        
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public decimal UnitPrice { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        // relazione molti a uno con ordini
        public Order Order { get; set; }
        
        // relazione molti a uno con prodotti
        public Product Product { get; set; }
    }
}
