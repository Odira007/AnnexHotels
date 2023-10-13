using AnnexHotels.Dtos.BookingDto;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.CustomerDto
{
    public class CustomerUpdateDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<BookingRequestDto> OrderRequestDtos { get; set; } =
            new List<BookingRequestDto>();
    }
}
