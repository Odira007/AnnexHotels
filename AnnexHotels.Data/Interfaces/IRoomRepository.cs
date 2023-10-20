using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetRooms();
        Task<Room> GetRoomByIdAsync(int id);
        Task<IEnumerable<Room>> GetRoomsByHotelIdAsync(int hotelId);
        Task<Room> GetRoomByHotelIdAsync(int Id, int hotelId);
        Task AddRoomByHotelIdAsync(int id, Room room);
        Task<bool> CheckRoomExists(int hotelId, int roomId);
        Task DeleteRoomAsync(int hotelId, int roomId);
        Task<bool> SaveChangesAsync();
    }
}
