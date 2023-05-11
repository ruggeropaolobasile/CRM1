using Microsoft.EntityFrameworkCore;
using CRM1.Models;
namespace CRM1
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options) : base(options)
        {
        }

        // Inserisci qui le proprietà DbSet per le entità del tuo CRM
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
    }
}
