using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnexHotels.Dtos.RoomDtos;
using AnnexHotels.Models.Enums;

namespace AnnexHotels.Dtos.BookingDtos
{
    public class BookingDto
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal Cost { get; set; }
        public BookingStatus bookingStatus { get; set; }
        public ICollection<RoomDto> ReservedRooms { get; set; } = new List<RoomDto>();
    }
}
