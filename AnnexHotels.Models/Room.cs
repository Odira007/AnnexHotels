using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }

        [Column(TypeName = "money")]
        public decimal PricePerDay { get; set; }
        public bool IsBooked { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        public Booking Booking { get; set; }
        public int? BookingId { get; set; }
    }
}
