using AnnexHotels.Dtos.BookingDtos;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.CustomerDtos
{
    public class CustomerUpdateDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<BookingDto> OrderRequestDtos { get; set; } =
            new List<BookingDto>();
    }
}
