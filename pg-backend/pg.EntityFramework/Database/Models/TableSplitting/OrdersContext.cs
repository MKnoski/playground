using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace pg.EntityFramework.Database.Models.TableSplitting
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedOrder>(dob =>
            {
                dob.ToTable("Orders");
                dob.Property(o => o.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Order>(ob =>
            {
                ob.ToTable("Orders");
                ob.Property(o => o.Status).HasColumnName("Status");
                ob.HasOne(o => o.DetailedOrder).WithOne()
                    .HasForeignKey<DetailedOrder>(o => o.Id);
            });
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<DetailedOrder> DetailedOrders { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseLoggerFactory(MyLoggerFactory);
    }
}