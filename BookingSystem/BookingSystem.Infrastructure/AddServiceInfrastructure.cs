using BookingSystem.Application.Irepo;
using BookingSystem.Application.Services;
using BookingSystem.Infrastructure.repo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastructure
{
    public static class AddServiceInfrastructure
    {
        public static IServiceCollection AddInfraStracture(this IServiceCollection services)
        {

            services.AddScoped<IServiceRepository, ServiceRepository>();
          


            services.AddScoped<IBookingRepository, BookingRepository>();
            
            return services;
        }
    }
}
