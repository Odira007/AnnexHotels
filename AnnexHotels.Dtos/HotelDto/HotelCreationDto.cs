using AnnexHotels.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnexHotels.Dtos.CompanyDto;
using AnnexHotels.Dtos.RoomDtos;
using AnnexHotels.Models;

namespace AnnexHotels.Dtos.HotelDto
{
    public class HotelCreationDto
    {
        public string Name { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
        public ICollection<RoomDto> RoomDtos { get; set; } = new List<RoomDto>();
        
    }
}
