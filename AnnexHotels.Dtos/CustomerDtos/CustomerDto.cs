using AnnexHotels.Dtos.BookingDtos;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.CustomerDtos
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get => $"{LastName} {FirstName}"; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<BookingDto> BookingRequestDtos { get; set; } =
            new List<BookingDto>();
    }
}
