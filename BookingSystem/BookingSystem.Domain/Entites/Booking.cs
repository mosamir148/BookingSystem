using BookingSystem.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entites
{
    public class Booking
    {
        public int Id { get; set; }

        public string CustomerId { get; set; } = null!;

        public int ServiceId { get; set; }

        public int TimeSlotId { get; set; }

        public BookingStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
