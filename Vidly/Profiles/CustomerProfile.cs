﻿using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() { 
        CreateMap<Customer, CustomerDto>();
        }
    }
}
