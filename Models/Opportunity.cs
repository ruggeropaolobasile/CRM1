using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM1.Models
{
public class Opportunity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public DateTime ExpectedCloseDate { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }
    }
}