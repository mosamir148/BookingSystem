using BookingSystem.Application.Irepo;
using BookingSystem.Domain.Entites;
using BookingSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastructure.repo
{

        public class BookingRepository : IBookingRepository
        {
            private readonly ApplicationDbContext _context;

            public BookingRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Booking?> GetBookingAsync(int bookingId)
            {
                return await _context.Bookings.FindAsync(bookingId);
            }

            public async Task AddBookingAsync(Booking booking)
            {
                await _context.Bookings.AddAsync(booking);
            }

            public async Task<TimeSlot?> GetTimeSlotAsync(int timeSlotId)
            {
                return await _context.TimeSlots.FindAsync(timeSlotId);
            }

            public async Task SaveChangesAsync()
            {
                await _context.SaveChangesAsync();
            }


        }
}
