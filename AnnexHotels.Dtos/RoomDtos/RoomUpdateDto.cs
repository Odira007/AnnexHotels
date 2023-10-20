using AnnexHotels.Dtos.HotelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.RoomDtos
{
    public class RoomUpdateDto
    {
        public string RoomType { get; set; }
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsBooked { get; set; }
    }
}
