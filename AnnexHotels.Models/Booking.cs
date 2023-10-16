using AnnexHotels.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Hotel Hotel { get; set; }
        public int? HotelId { get; set; }
        public BookingStatus BookingStatus { get; set; }
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
        public ICollection<Room> ReservedRooms { get; set; } = new List<Room>();
    }
}
