using BookingSystem.Application.Services;
using BookingSystem.Application.Validators;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;



namespace BookingSystem.Application
{
    public static class ApplicationServicep
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddValidatorsFromAssemblyContaining<CreateBookingRequestValidator>();
            services.AddScoped<BookingService>();
            services.AddScoped<ServiceService>();
            return services;
        }
    }
}
