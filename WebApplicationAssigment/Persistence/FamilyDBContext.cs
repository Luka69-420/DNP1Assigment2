using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApplicationAssigment.Persistence
{
    public class FamilyDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Pet> Pets { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source = Family.db");
        }
      
    }
}