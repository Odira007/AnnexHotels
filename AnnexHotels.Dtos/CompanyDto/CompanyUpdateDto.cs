using AnnexHotels.Dtos.HotelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.CompanyDto
{
    public class CompanyUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
