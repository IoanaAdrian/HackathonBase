using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using backend.Entities;
using backend.Models;

namespace backend.Mappers
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<BlinkerCommandModel, Commands>()
                .ForMember(c => c.left_value,
                    bl => bl.MapFrom(b => b.LeftLed))
                .ForMember(c => c.right_value, o => o.MapFrom(b => b.RightLed))
                .ForMember(c => c.valid, o => o.MapFrom(b => true))
                .ReverseMap();
        }

    }
}
