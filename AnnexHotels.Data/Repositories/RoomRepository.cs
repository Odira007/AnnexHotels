using AnnexHotels.Data.DbContexts;
using AnnexHotels.Data.Interfaces;
using AnnexHotels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AnnexHotelsDbContext _dbContext;

        public RoomRepository(AnnexHotelsDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task AddRoomByHotelIdAsync(int id, Room room)
        {
            var hotel = await _dbContext.Hotels.Where(e => e.Id == id).FirstOrDefaultAsync();

            if (hotel != null)
            {
                hotel.Rooms.Add(room);
            }
        }

        public async Task<Room> GetRoomByHotelIdAsync(int id, int hotelId)
        {
            return await _dbContext.Rooms
                .Where(e => e.Id == id && e.HotelId == hotelId).FirstOrDefaultAsync();
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _dbContext.Rooms.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _dbContext.Rooms.OrderBy(e => e.RoomNumber).ToListAsync();
        }

        public async Task<IEnumerable<Room>> GetRoomsByHotelIdAsync(int hotelId)
        {
            return await _dbContext.Rooms.OrderBy(e => e.RoomNumber)
                .Where(e => e.HotelId == hotelId).ToListAsync();
        }

        public async Task<bool> CheckRoomExists(int hotelId, int roomId)
        {
            var room = await _dbContext.Rooms
                .Where(e => e.HotelId == hotelId && e.Id == roomId).FirstOrDefaultAsync();

            return room == null;
        }

        public async Task DeleteRoomAsync(int hotelId, int roomId)
        {
            var room = await GetRoomByHotelIdAsync(roomId, hotelId);
            _dbContext.Remove(room);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
