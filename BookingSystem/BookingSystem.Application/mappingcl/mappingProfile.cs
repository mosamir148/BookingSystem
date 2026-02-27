using AutoMapper;
using BookingSystem.Application.Dtos;
using BookingSystem.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.mappingcl
{
    public class mappingProfile:Profile
    {
        public mappingProfile()
        {
            CreateMap<Service, ServiceDto>();
            
        }
    }
}
