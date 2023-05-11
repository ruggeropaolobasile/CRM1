using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        // relazione molti a molti con i ruoli
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
