using BookingSystem.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastructure.Configrations
{
    public class SeerviseConfigration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");


            builder.HasData(
             new Service
             {
                 Id = 1,
                 Name = "Dental Check",
                 Description = "Basic dental examination",
                 Price = 200,
                 ProviderId = "provider1" // <-- لازم تحطها
             },
             new Service
            {
        Id = 2,
        Name = "Haircut",
        Description = "Men haircut",
        Price = 100,
        ProviderId = "provider1" // <-- لازم تحطها
              });


        }


    }
}
