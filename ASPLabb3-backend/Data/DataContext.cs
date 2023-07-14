using ASPLabb3_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;


namespace ASPLabb2.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ASPLabb3DB;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Interest> Interests => Set<Interest>();
        public DbSet<Link> Links => Set<Link>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Person 1", TelephoneNumber = "070-1234567" },
                new Person { Id = 2, Name = "Person 2", TelephoneNumber = "070-1234567" }

            );
        }
    }

}
