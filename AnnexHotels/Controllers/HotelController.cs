using AnnexHotels.Core.Interfaces;
using AnnexHotels.Dtos.HotelDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnexHotels.Controllers
{
    [Route("api/companies/{companyId}/hotels")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService ?? throw new ArgumentNullException(nameof(hotelService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelWithoutRoomsDto>>> GetHotels()
        {
            return Ok(await _hotelService.GetHotels());
        }

        [HttpGet("{hotelId}")]
        public async Task<ActionResult<HotelWithoutRoomsDto>> GetHotelById(int hotelId, bool includeRooms)
        {
            return Ok(await _hotelService.GetHotelById(hotelId, includeRooms));
        }

        [HttpPost]
        public async Task<ActionResult<HotelRequestDto>> CreateHotel(int companyId, HotelCreationDto hotel)
        {
            var finalHotelCreated = await _hotelService.AddHotel(companyId, hotel);
            return CreatedAtRoute("GetHotelById",
                new
                {
                    companyId = companyId,
                    hotelId = finalHotelCreated.Id
                },
                finalHotelCreated);
        }
    }
}
