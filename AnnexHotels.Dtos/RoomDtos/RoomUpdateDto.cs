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
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsBooked { get; set; }
        public bool CheckedIn { get; set; }
        public HotelRequestDto HotelRequestDto { get; set; }
    }
}
