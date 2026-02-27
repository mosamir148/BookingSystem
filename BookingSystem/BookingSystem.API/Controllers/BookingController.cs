using BookingSystem.Application.Dtos;
using BookingSystem.Application.Services;
using BookingSystem.Domain.Entites;
using BookingSystem.Domain.Enum;
using BookingSystem.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly BookingService _bookingService;

        public BookingController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingRequest request)
        {
            var result = await _bookingService.CreateBookingAsync(request);

            if (result.Contains("not found") || result.Contains("already booked"))
                return BadRequest(result);

            return Ok(result);
        }
    }
}

