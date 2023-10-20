using AnnexHotels.Dtos.RoomDtos;
using AnnexHotels.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Profiles
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomDto>();
            CreateMap<RoomCreationDto, Room>();
            CreateMap<RoomCreationDto, RoomDto>();
            CreateMap<RoomUpdateDto, Room>();
            CreateMap<Room, RoomUpdateDto>();
        }
    }
}
