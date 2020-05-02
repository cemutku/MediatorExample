using Microsoft.EntityFrameworkCore;

namespace MediatRExample.Data
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Contact 1 FirstName", LastName = "Contact 1 LastName" },
                new Contact { Id = 2, FirstName = "Contact 2 FirstName", LastName = "Contact 2 LastName" },
                new Contact { Id = 3, FirstName = "Contact 3 FirstName", LastName = "Contact 3 LastName" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
