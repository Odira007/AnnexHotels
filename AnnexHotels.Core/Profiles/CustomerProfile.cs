using AnnexHotels.Dtos.CustomerDtos;
using AnnexHotels.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerCreationDto, Customer>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CustomerUpdateDto>();
        }
    }
}
