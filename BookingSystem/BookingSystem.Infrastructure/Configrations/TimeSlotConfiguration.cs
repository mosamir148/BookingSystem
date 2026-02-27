using BookingSystem.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastructure.Configrations
{
    public class TimeSlotConfiguration : IEntityTypeConfiguration<TimeSlot>
    {
        public void Configure(EntityTypeBuilder<TimeSlot> builder)
        {
            builder.HasData(
                new TimeSlot
                {
                    Id = 1,
                    ServiceId = 1,
                    StartTime = new DateTime(2026, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(2026, 1, 1, 11, 0, 0),
                    IsBooked = false
                },
                new TimeSlot
                {
                    Id = 2,
                    ServiceId = 1,
                    StartTime = new DateTime(2026, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(2026, 1, 1, 12, 0, 0),
                    IsBooked = false
                }
            );
        }
    }
}