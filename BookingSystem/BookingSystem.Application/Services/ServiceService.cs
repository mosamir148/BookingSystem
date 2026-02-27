using AutoMapper;
using BookingSystem.Application.Dtos;
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
        private readonly IMapper _mapper;

        public ServiceService(IServiceRepository serviceRepository,IMapper mapper)
        {
            this._serviceRepository = serviceRepository;
            this._mapper = mapper;
        }

        public async Task<List<ServiceDto>> GetAllAsync()
        {
            var services = await _serviceRepository.GetAllAsync();

           var mapper = _mapper.Map<List<ServiceDto>>(services);
            return mapper;
        }
    }
}
