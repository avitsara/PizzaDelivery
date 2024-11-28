using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Server.Model;


namespace PizzaDelivery.Server.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order_Items> Order_Items { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Pizza>().ToTable("Pizza");
            modelBuilder.Entity<Order_Items>().ToTable("Order_Items");
            modelBuilder.Entity<Orders>().ToTable("Orders");

            modelBuilder.Entity<Orders>().HasMany(o => o.items).WithOne().HasForeignKey(oi => oi.order_id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
