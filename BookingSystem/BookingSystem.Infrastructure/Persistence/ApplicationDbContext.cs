using BookingSystem.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastructure.Persistence
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) :base(option)    
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public DbSet<Service> Services { get; set; }

        public DbSet<TimeSlot> TimeSlots { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}
