using AutoMapper;
using CarComparison.App.Infrastructure.DTO;
using CarComparison.Core.Entities;
using CarComparison.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparison.App.Infrastructure.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car,CarDTO > ()
                .ForMember(destination => destination.Color,
                 opt => opt.MapFrom(source => Enum.GetName(typeof(EnumColor), source.Color))); 
        }
    }
}
