using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entites
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int DurationInMinutes { get; set; }

        public string ProviderId { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        // علاقة Service بالـ TimeSlots
        public ICollection<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    }
}
