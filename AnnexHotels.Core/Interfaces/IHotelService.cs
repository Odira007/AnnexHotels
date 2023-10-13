using AnnexHotels.Dtos.HotelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Interfaces
{
    public interface IHotelService
    {
        public Task<IEnumerable<HotelWithoutRoomsDto>> GetHotels();
        public Task<HotelWithoutRoomsDto> GetHotelById(int hotelId, bool includeRooms);
        public Task<HotelRequestDto> AddHotel(int companyId, HotelCreationDto hotel);
        //public Task<IEnumerable<Hotel>> GetHotelsByCompanyIdAsync(int companyId);
        //public Task<Hotel> GetHotelByCompanyIdAsync(int companyId, int hotelId);
        //public Task<Hotel> AddHotelAsync(Hotel hotel);
        //public Task<Hotel> AddHotelByCompanyIdAsync(Hotel hotel);
        //public Task UpdateHotelAsync(int hotelId);
        //public Task UpdatePartialHotelAsync(int hotelId);
        //public Task DeleteHotelAsync(int hotelId);
    }
}
