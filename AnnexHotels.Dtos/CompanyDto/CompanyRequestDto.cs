using AnnexHotels.Dtos.HotelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.CompanyDto
{
    public class CompanyRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<HotelRequestDto> HotelRequestDtos { get; set; } =
            new List<HotelRequestDto>();
    }
}
