using BookingSystem.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ServiceService _serviceService;

        public ServicesController(ServiceService serviceService)
        {
            this._serviceService = serviceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var services = await _serviceService.GetAllAsync();
            return Ok(services);
        }
    }
}
