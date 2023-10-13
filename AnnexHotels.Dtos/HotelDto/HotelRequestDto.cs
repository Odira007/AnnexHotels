using System;
using System.Collections.Generic;
using AnnexHotels.Models.Enums;
using AnnexHotels.Dtos.CompanyDto;
using AnnexHotels.Dtos.RoomDto;
using AnnexHotels.Models;

namespace AnnexHotels.Dtos.HotelDto
{
    public class HotelRequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Status Status { get; set; }
        public string Description { get; set; }
        public ICollection<RoomRequestDto> RoomRequestDtos { get; }
    }
}
