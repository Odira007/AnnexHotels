using AnnexHotels.Dtos.CompanyDto;
using AnnexHotels.Models;
using AnnexHotels.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Dtos.HotelDto
{
    public class HotelUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public Status Status { get; set; }
        public string Description { get; set; }
    }
}
