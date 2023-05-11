using System;
using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime InvoiceDate { get; set; }
        
        public decimal TotalAmount { get; set; }
        
        [Required]
        public int OrderId { get; set; }
        
        // relazione molti a uno con gli ordini
        public Order Order { get; set; }
    }
}
