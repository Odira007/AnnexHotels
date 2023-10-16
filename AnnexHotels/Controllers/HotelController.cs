using AnnexHotels.Core.Interfaces;
using AnnexHotels.Dtos.HotelDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnexHotels.Controllers
{
    [Route("api/hotels")]
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
            var hotel = await _hotelService.GetHotelById(hotelId, includeRooms);

            if (hotel == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return hotel;
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

        [HttpPut("{hotelId}")]
        public async Task<ActionResult> UpdateHotel(int hotelId, HotelUpdateDto hotel)
        {
            try
            {
                await _hotelService.UpdateHotelAsync(hotelId, hotel);
            }
            catch(ArgumentNullException)
            {
                return BadRequest(ModelState);
            }
            catch(Exception)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPatch("{hotelId}")]
        public async Task<ActionResult> UpdatePartialHotel(int hotelId, JsonPatchDocument<HotelUpdateDto> patchDocument)
        {
            try
            {
                await _hotelService.UpdatePartialHotelAsync(hotelId, patchDocument);
            }
            catch (ArgumentNullException)
            {
                return BadRequest(ModelState);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
