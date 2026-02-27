using BookingSystem.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Irepo
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetAllAsync();  
    }
}
