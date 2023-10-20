using AnnexHotels.Dtos.RoomDtos;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Interfaces
{
    public interface IRoomService
    {
        Task<IEnumerable<RoomDto>> GetRooms();
        Task<RoomDto> GetRoomById(int id);
        Task<IEnumerable<RoomDto>> GetRoomsByHotelId(int hotelId);
        Task<RoomDto> GetRoomByHotelId(int hotelId, int roomId);
        Task<RoomDto> AddRoomByHotelId(int hotelId, RoomCreationDto room);
        Task UpdateRoomByHotelId(int hotelId, int roomId, RoomUpdateDto room);
        Task UpdatePartialRoom(int hotelId, int roomId, JsonPatchDocument<RoomUpdateDto> patchDocument);
        Task DeleteRoom(int hotelId, int roomId);
    }
}
