using AnnexHotels.Dtos.HotelDto;
using AnnexHotels.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Profiles
{
    public class HotelProfile : Profile
    {
        public HotelProfile()
        {
            CreateMap<Hotel, HotelWithoutRoomsDto>();
            CreateMap<HotelCreationDto, HotelRequestDto>();
            CreateMap<HotelUpdateDto, Hotel>();
            CreateMap<Hotel, HotelUpdateDto>();
        }
    }
}
