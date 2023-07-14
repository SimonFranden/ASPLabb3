using ASPLabb3_DataAcces;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ASPLabb3_DataAcces.Models;

namespace ASPLabb3_DataAcces.Data
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
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=APILabbDB;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Interest> Interests => Set<Interest>();
        public DbSet<Link> Links => Set<Link>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Kalle Anka", TelephoneNumber = "070-1234567" },
                new Person { Id = 2, Name = "Långben", TelephoneNumber = "070-1234567" },
                new Person { Id = 3, Name = "Musse Pigg", TelephoneNumber = "070-1234567" }
            );

            modelBuilder.Entity<Interest>().HasData(
            new Interest { Id = 1, Title = "Naturfotografi", Description = "Naturfotografi är ett brett spektrum av fotografier som tagits utomhus med naturliga motiv.", PersonId = 1},
            new Interest { Id = 2, Title = "Basket", Description = "Basket eller basketboll (äldre benämning korgboll) är en lagidrott och bollsport.", PersonId = 2 }
            );

            modelBuilder.Entity<Link>().HasData(
            new Link { Id = 1, LinkAdress = "www.naturfotograferna.se", InterestId = 1 },
            new Link { Id = 2, LinkAdress = "www.nba.com", InterestId = 2}
            );
        }
    }

}
