using Microsoft.EntityFrameworkCore;

namespace PeopleService.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<EmailDetails> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(x => x.Name)
                .HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Person>()
                .Property(x => x.LastName)
                .HasMaxLength(50).IsRequired();

            modelBuilder.Entity<EmailDetails>()
                .Property(x => x.Email)
                .HasMaxLength(50).IsRequired();
        }
    }
}
