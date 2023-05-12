using System.ComponentModel.DataAnnotations;
namespace CRM1.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        // altre proprietà necessarie

        [Range(1, 5)]
        public int Rating { get; set; }
    }
}