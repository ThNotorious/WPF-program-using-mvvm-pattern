using Homework_18_Patterns.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework_18_Patterns.Data
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }  
        public DbSet<AnimalSpecies> Species { get; set; }  
        public DbSet<AnimalClass> AnimalClasses { get; set; }

        public ApplicationContext()
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Homework_18_PatternsDB;Trusted_Connection=true");
        }
    }
}
