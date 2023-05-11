using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string? Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        // relazione molti a uno con i clienti
        public Customer? Customer { get; set; }
    }
}
