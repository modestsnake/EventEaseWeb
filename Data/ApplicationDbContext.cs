using Microsoft.EntityFrameworkCore;
using EventEaseApp.Models;

namespace EventEaseApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; } = default!;
        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<Booking> Bookings { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Additional configuration if needed
        }
    }
}
