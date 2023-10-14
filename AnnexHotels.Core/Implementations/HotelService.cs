using AnnexHotels.Core.Interfaces;
using AnnexHotels.Data.Interfaces;
using AnnexHotels.Dtos.HotelDto;
using AnnexHotels.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Implementations
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository ?? throw new ArgumentNullException(nameof(hotelRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<HotelWithoutRoomsDto>> GetHotels()
        {
            var hotels = await _hotelRepository.GetHotelsAsync();
            var hotelDtos = _mapper.Map<IEnumerable<HotelWithoutRoomsDto>>(hotels);

            return hotelDtos;
        }

        public async Task<HotelWithoutRoomsDto> GetHotelById(int hotelId, bool includeRooms)
        {
            var hotel = await _hotelRepository.GetHotelByIdAsync(hotelId, includeRooms);
            var hotelDto = _mapper.Map<HotelWithoutRoomsDto>(hotel);

            return hotelDto;
        }

        public async Task<HotelRequestDto> AddHotel(int companyId, HotelCreationDto hotel)
        {
            var hotelToBeCreated = _mapper.Map<Hotel>(hotel);

            if (!await _hotelRepository.CheckCompanyExists(companyId))
            {
                // to be replaced with logging
                throw new Exception("Company does not exist");
            }

            await _hotelRepository.AddHotelByCompanyIdAsync(companyId, hotelToBeCreated);
            await _hotelRepository.SaveChangesAsync();

            var hotelDto = _mapper.Map<HotelRequestDto>(hotelToBeCreated);

            return hotelDto;
        }

        public async Task UpdateHotelAsync(int hotelId, HotelUpdateDto hotel)
        {
            // get the hotel to be updated
            var hotelEntity = await _hotelRepository.GetHotelByIdAsync(hotelId, false);

            if (hotelEntity == null)
            {
                // log "hotel with the id {id} could not be found"
            }

            _mapper.Map(hotel, hotelEntity);

            await _hotelRepository.SaveChangesAsync();
        }

        public async Task UpdatePartialHotelAsync(int hotelId, JsonPatchDocument<HotelUpdateDto> patchDocument)
        {
            var hotelEntity = await _hotelRepository.GetHotelByIdAsync(hotelId, false);
            if (hotelEntity == null)
            {
                // log error
            }

            var hotelToPatch = _mapper.Map<HotelUpdateDto>(hotelEntity);
            patchDocument.ApplyTo(hotelToPatch);

            _mapper.Map(hotelToPatch, hotelEntity);

            await _hotelRepository.SaveChangesAsync();
        }
    }
}
