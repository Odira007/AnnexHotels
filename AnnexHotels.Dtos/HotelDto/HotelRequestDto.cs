using System;
using System.Collections.Generic;
using AnnexHotels.Models.Enums;
using AnnexHotels.Dtos.CompanyDto;
using AnnexHotels.Models;
using AnnexHotels.Dtos.RoomDtos;

namespace AnnexHotels.Dtos.HotelDto
{
    public class HotelRequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Status Status { get; set; }
        public string Description { get; set; }
        public ICollection<RoomDto> RoomDtos { get; set; } = new List<RoomDto>();
    }
}
