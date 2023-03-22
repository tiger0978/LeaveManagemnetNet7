﻿using AutoMapper;
using LeaveManagemnet.Web.Data;
using LeaveManagemnet.Web.Models;

namespace LeaveManagemnet.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}