using System;

namespace CRM1.Models
{
    public enum InteractionType
    {
        InboundCall,
        OutboundCall,
        InboundMail,
        OutboundMail,
        InPerson
    }

    public class Interaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public InteractionType InteractionType { get; set; }
    }
}