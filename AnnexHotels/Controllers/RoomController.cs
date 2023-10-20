using AnnexHotels.Core.Interfaces;
using AnnexHotels.Dtos.RoomDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnexHotels.Controllers
{
    [Route("api/hotels/{hotelId}/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService ?? throw new ArgumentNullException(nameof(roomService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomDto>>> GetRoomByHotelId(int hotelId)
        {
            return Ok(await _roomService.GetRoomsByHotelId(hotelId));
        }

        [HttpGet("{roomId}")]
        public async Task<ActionResult<RoomDto>> GetRoomByHotelId(int hotelId, int roomId)
        {
            return Ok(await _roomService.GetRoomByHotelId(hotelId, roomId));
        }

        [HttpPost]
        public async Task<ActionResult<RoomDto>> AddRoom(int hotelId, RoomCreationDto room)
        {
            var response = await _roomService.AddRoomByHotelId(hotelId, room);

            return Ok(response);
        }

        [HttpPut("{roomId}")]
        public async Task<ActionResult> UpdateRoom(int hotelId, int roomId, RoomUpdateDto room)
        {
            try
            {
                await _roomService.UpdateRoomByHotelId(hotelId, roomId, room);
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

        [HttpPatch("{roomId}")]
        public async Task<ActionResult> UpdatePartialRoom(int hotelId, int roomId, 
            JsonPatchDocument<RoomUpdateDto> patchDocument)
        {
            try
            {
                await _roomService.UpdatePartialRoom(hotelId, roomId, patchDocument);
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

        [HttpDelete("{roomId}")]
        public async Task<ActionResult> DeleteRoom(int hotelId, int roomId)
        {
            await _roomService.DeleteRoom(hotelId, roomId);
            return NoContent();
        }
    }
}
