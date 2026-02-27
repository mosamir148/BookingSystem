using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Dtos
{
    public class CreateBookingRequest
    {
        public string CustomerId { get; set; } = null!;

        public int ServiceId { get; set; }

        public int TimeSlotId { get; set; }
    }
}
