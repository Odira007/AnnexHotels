using AnnexHotels.Dtos.HotelDto;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.RoomDto
{
    public class RoomRequestDto : BaseEntityForDtos
    {
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsBooked { get; set; }
        public bool CheckedIn { get; set; }
        public HotelRequestDto HotelRequestDto { get; set; }
    }
}
