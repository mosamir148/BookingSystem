using BookingSystem.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Irepo
{
    public interface IBookingRepository
    {
        Task<Booking?> GetBookingAsync(int bookingId);
        Task AddBookingAsync(Booking booking);
        Task<TimeSlot?> GetTimeSlotAsync(int timeSlotId);
        Task SaveChangesAsync();
    }
}
