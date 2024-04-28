using Card.Entities;
using Microsoft.EntityFrameworkCore;

namespace CardFinder.DataAcess
{
    public class CardDbContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Database=CARD;Port=5432;User Id=postgres;Password=123;");
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Cardd> cards { get; set; }
    }
}
