using Eventures.Models;

namespace Eventures.Data
{
    using Microsoft.EntityFrameworkCore;
        using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class EventuresDbContext : IdentityDbContext<EventuresUser>
    {
        public EventuresDbContext()
        {
            
        }

        public EventuresDbContext(DbContextOptions<EventuresDbContext> options) : base(options)
        {
            
        }

        public DbSet<EventuresUser> EventuresUsers { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EventuresUser>().HasMany(o => o.Orders)
                .WithOne(c => c.Customer)
                .HasForeignKey(fk => fk.CustomerId);

            builder.Entity<Event>().HasMany(o => o.Orders)
                .WithOne(e => e.Event)
                .HasForeignKey(fk => fk.EventId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
