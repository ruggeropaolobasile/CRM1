using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoleId { get; set; }

        // relazione molti a uno con gli utenti
        public User User { get; set; }

        // relazione molti a uno con i ruoli
        public Role Role { get; set; }
    }
}
