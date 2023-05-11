using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string? City { get; set; }

        [Required]
        [MaxLength(20)]
        public string? State { get; set; }

        [Required]
        [MaxLength(10)]
        public string? ZipCode { get; set; }

        // relazione molti a uno con i clienti
        public Customer? Customer { get; set; }
    }
}
