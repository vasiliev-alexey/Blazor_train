using Microsoft.EntityFrameworkCore;
using PizzaSPA.Shared;

namespace PizzaSPA.Server.DataStores
{
    public class PizzaPlaceDbContext : DbContext
    {
        public PizzaPlaceDbContext(
            DbContextOptions<PizzaPlaceDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DB\\pizza_store.db");
        }


        public DbSet<Pizza> Pizzas { get; set; }
        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var pizzaEntity = modelBuilder.Entity<Pizza>();
            pizzaEntity.HasKey(pizza => pizza.Id);
            pizzaEntity.Property(pizza => pizza.Price)
                .HasColumnType("money");
        }

    }
}