using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime OrderDate { get; set; }
        
        public DateTime? ShippedDate { get; set; }
        
        [Required]
        public int CustomerId { get; set; }
        
        public decimal TotalAmount { get; set; }
        
        // relazione uno a molti con order items
        public ICollection<OrderItem> OrderItems { get; set; }
        
        // relazione molti a uno con i clienti
        public Customer Customer { get; set; }
    }
}