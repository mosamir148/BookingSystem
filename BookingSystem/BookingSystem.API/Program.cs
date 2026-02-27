using BookingSystem.Application;
using BookingSystem.Application.Irepo;
using BookingSystem.Application.Services;
using BookingSystem.Infrastructure;
using BookingSystem.Infrastructure.Persistence;
using BookingSystem.Infrastructure.repo;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddInfraStracture().AddApplicationService();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
