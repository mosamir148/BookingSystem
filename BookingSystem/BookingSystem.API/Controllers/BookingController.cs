using BookingSystem.Application.Dtos;
using BookingSystem.Domain.Entites;
using BookingSystem.Domain.Enum;
using BookingSystem.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingRequest request)
        {
            // 1️⃣ نتأكد إن الـ TimeSlot موجود
            var timeSlot = await _context.TimeSlots
                .FirstOrDefaultAsync(t => t.Id == request.TimeSlotId);

            if (timeSlot == null)
                return NotFound("TimeSlot not found");

            // 2️⃣ نتأكد إنه مش محجوز
            if (timeSlot.IsBooked)
                return BadRequest("This TimeSlot is already booked");

            // 3️⃣ نعمل Booking جديد
            var booking = new Booking
            {
                CustomerId = request.CustomerId,
                ServiceId = request.ServiceId,
                TimeSlotId = request.TimeSlotId,
                Status = BookingStatus.Confirmed
            };

            // 4️⃣ نغير حالة الـ TimeSlot
            timeSlot.IsBooked = true;

            // 5️⃣ نحفظ في الداتا بيز
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return Ok("Booking created successfully");
        }
    }
}
