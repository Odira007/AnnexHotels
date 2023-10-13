using AnnexHotels.Dtos.HotelDto;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.Interfaces
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetHotelsAsync();
        Task<Hotel> GetHotelByIdAsync(int hotelId, bool includeRooms);
        Task<IEnumerable<Hotel>> GetHotelsByCompanyIdAsync(int companyId);
        Task<Hotel> GetHotelByCompanyIdAsync(int companyId, int hotelId);
        Task AddHotelAsync(Hotel hotel);
        Task AddHotelByCompanyIdAsync(int companyId, Hotel hotel);
        Task<HotelUpdateDto> UpdateHotelAsync(int hotelId);
        Task UpdatePartialHotelAsync(int hotelId);
        Task DeleteHotelAsync(int hotelId);
        Task<bool> CheckHotelExists(int hotelId);
        Task<bool> CheckCompanyExists(int companyId);
        Task<bool> SaveChangesAsync();
    }
}
