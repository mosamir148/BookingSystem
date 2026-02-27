using BookingSystem.Application.Irepo;
using BookingSystem.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Services
{
    public class ServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            this._serviceRepository = serviceRepository;
        }

        public async Task<List<Service>> GetAllAsync()
        {
            return await _serviceRepository.GetAllAsync();
        }
    }
}
