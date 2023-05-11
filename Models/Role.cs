using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM1.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // relazione molti a molti con gli utenti
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
