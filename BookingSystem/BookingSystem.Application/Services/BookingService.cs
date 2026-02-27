using BookingSystem.Application.Dtos;
using BookingSystem.Application.Irepo;
using BookingSystem.Domain.Entites;
using BookingSystem.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookingSystem.Application.Services
{
    public class BookingService
    {
        private readonly IBookingRepository _repository;

        public BookingService(IBookingRepository repository)
        {
            _repository = repository;
        }


        public async Task<string> CreateBookingAsync(CreateBookingRequest request)
        {
            var timeSlot = await _repository.GetTimeSlotAsync(request.TimeSlotId);

            if (timeSlot == null) return "TimeSlot not found";
            if (timeSlot.IsBooked) return "This TimeSlot is already booked";

            var booking = new Booking
            {
                CustomerId = request.CustomerId,
                ServiceId = request.ServiceId,
                TimeSlotId = request.TimeSlotId,
                Status = BookingStatus.Confirmed
            };

            timeSlot.IsBooked = true;

            await _repository.AddBookingAsync(booking);
            await _repository.SaveChangesAsync();

            return "Booking created successfully";
        }
    }
}
