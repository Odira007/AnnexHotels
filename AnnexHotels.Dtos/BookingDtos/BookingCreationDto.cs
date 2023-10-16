using AnnexHotels.Dtos.RoomDtos;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.BookingDtos
{
    public class BookingCreationDto
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get => ReservedRooms.Sum(e => e.PricePerDay); }
        public decimal Discount { get => TotalPrice * (10 / 100); }
        public decimal Cost
        {
            get
            {
                TimeSpan duration = CheckOutDate - CheckInDate;
                return duration.Days * (TotalPrice - Discount);
            }
        }
        public ICollection<RoomDto> ReservedRooms { get; set; } = new List<RoomDto>();
    }
}
