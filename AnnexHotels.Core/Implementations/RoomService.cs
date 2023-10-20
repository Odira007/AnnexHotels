using AnnexHotels.Core.Interfaces;
using AnnexHotels.Data.Interfaces;
using AnnexHotels.Dtos.RoomDtos;
using AnnexHotels.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Implementations
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IHotelRepository _hotelRepository;
        private readonly ILogger<RoomService> _logger;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IHotelRepository hotelRepository, ILogger<RoomService> logger, IMapper mapper)
        {
            _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
            _hotelRepository = hotelRepository ?? throw new ArgumentNullException(nameof(hotelRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<RoomDto>> GetRooms()
        {
            var rooms = await _roomRepository.GetRooms();
            var response = _mapper.Map<IEnumerable<RoomDto>>(rooms);

            return response;
        }

        public async Task<RoomDto> GetRoomById(int id)
        {
            var room = await _roomRepository.GetRoomByIdAsync(id);

            if (room == null)
            {
                _logger.LogInformation($"The hotel with the Id: {id} could not be found");
            }

            var response = _mapper.Map<RoomDto>(room);

            return response;
        }

        public async Task<IEnumerable<RoomDto>> GetRoomsByHotelId(int hotelId)
        {
            if (!await _hotelRepository.CheckHotelExists(hotelId))
            {
                _logger.LogInformation("The hotel with the Id: {hotelId} could not be found");
            }

            var rooms = await _roomRepository.GetRoomsByHotelIdAsync(hotelId);
            var response = _mapper.Map<IEnumerable<RoomDto>>(rooms);

            return response;
        }
        
        public async Task<RoomDto> GetRoomByHotelId(int hotelId, int roomId)
        {
            if (!await _hotelRepository.CheckHotelExists(hotelId))
            {
                _logger.LogInformation($"The hotel with the Id: {hotelId} could not be found");
            }

            if (!await _roomRepository.CheckRoomExists(hotelId, roomId))
            {
                _logger.LogInformation($"The room with the Id: {roomId} could not be found");
            }

            var room = await _roomRepository.GetRoomByHotelIdAsync(roomId, hotelId);
            var response = _mapper.Map<RoomDto>(room);

            return response;
        }

        public async Task<RoomDto> AddRoomByHotelId(int hotelId, RoomCreationDto room)
        {

            if (!await _hotelRepository.CheckHotelExists(hotelId))
            {
                _logger.LogInformation($"The hotel with the Id: {hotelId} could not be found");
            }

            var roomToBeCreated = _mapper.Map<Room>(room);
            await _roomRepository.AddRoomByHotelIdAsync(hotelId, roomToBeCreated);
            await _roomRepository.SaveChangesAsync();

            var response = _mapper.Map<RoomDto>(roomToBeCreated);

            return response;
        }

        public async Task UpdateRoomByHotelId(int hotelId, int roomId, RoomUpdateDto room)
        {
            if (!await _hotelRepository.CheckHotelExists(hotelId))
            {
                _logger.LogInformation($"The hotel with the Id: {hotelId} could not be found");
            }

            var roomEntity = await _roomRepository.GetRoomByHotelIdAsync(roomId, hotelId);

            if (roomEntity == null)
            {
                _logger.LogInformation($"The room with the Id: {roomId} could not be found");
            }

            _mapper.Map(room, roomEntity);

            await _roomRepository.SaveChangesAsync();
        }

        public async Task UpdatePartialRoom(int hotelId, int roomId, 
            JsonPatchDocument<RoomUpdateDto> patchDocument)
        {
            if (!await _hotelRepository.CheckHotelExists(hotelId))
            {
                _logger.LogInformation($"The hotel with the Id: {hotelId} could not be found");
            }

            var roomEntity = await _roomRepository.GetRoomByHotelIdAsync(roomId, hotelId);
            var roomToPatch = _mapper.Map<RoomUpdateDto>(roomEntity);

            patchDocument.ApplyTo(roomToPatch);
            _mapper.Map(roomToPatch, roomEntity);

            await _roomRepository.SaveChangesAsync();
        }

        public async Task DeleteRoom(int hotelId, int roomId)
        {
            await _roomRepository.DeleteRoomAsync(hotelId, roomId);
            await _roomRepository.SaveChangesAsync();
        }
    }
}
