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
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ServiceRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<Service>> GetAllAsync()
        {
            return await _dbContext.Services.ToListAsync();
        }
    }
}
