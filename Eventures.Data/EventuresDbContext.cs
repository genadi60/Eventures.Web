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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
