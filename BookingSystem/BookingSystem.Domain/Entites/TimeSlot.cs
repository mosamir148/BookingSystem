using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entites
{
    public class TimeSlot
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; } = null!;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsBooked { get; set; } = false;
    }
}
