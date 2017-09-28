using AutoMapper;
using DATATABLEANDJQUEry.Dto;
using DATATABLEANDJQUEry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATATABLEANDJQUEry.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Students3, Students3Dto>();
            CreateMap<Students3Dto, Students3>();

        }
    }
}