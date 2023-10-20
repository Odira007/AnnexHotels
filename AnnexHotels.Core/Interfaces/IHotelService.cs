using AnnexHotels.Dtos.HotelDto;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelWithoutRoomsDto>> GetHotels();
        Task<HotelWithoutRoomsDto> GetHotelById(int hotelId, bool includeRooms);
        Task<HotelRequestDto> AddHotel(int companyId, HotelCreationDto hotel);
        Task UpdateHotelAsync(int hotelId, HotelUpdateDto hotel);
        public Task UpdatePartialHotelAsync(int hotelId, JsonPatchDocument<HotelUpdateDto> patchDocument);
        //public Task<IEnumerable<Hotel>> GetHotelsByCompanyIdAsync(int companyId);
        //public Task<Hotel> GetHotelByCompanyIdAsync(int companyId, int hotelId);
        //public Task<Hotel> AddHotelByCompanyIdAsync(Hotel hotel);
        //public Task DeleteHotelAsync(int hotelId);
    }
}
