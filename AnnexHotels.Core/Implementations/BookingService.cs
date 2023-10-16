using AnnexHotels.Core.Interfaces;
using AnnexHotels.Data.Interfaces;
using AnnexHotels.Dtos.BookingDtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepository bookingRepository, IMapper mapper)
        {
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<BookingDto>> GetBookings()
        {
            var bookings = await _bookingRepository.GetBookingsAsync();

            if (bookings.Count() == 0)
            {
                // log
            }

            var bookingDtos = _mapper.Map<IEnumerable<BookingDto>>(bookings);

            return bookingDtos;
        }

        public Task<BookingDto> GetBookingById(int bookingId, bool includeRooms)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> GetBookingsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> GetBookingByCustomerId(int customerId, int bookingId)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> GetBookingByHotelId(int hotelId, int bookingId, bool includeRooms)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> GetBookingsByHotelId(int hotelId)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> AddBooking(int companyId, BookingCreationDto booking)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookingAsync(int bookingId, BookingUpdateDto booking)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePartialBookingAsync(int bookingId, JsonPatchDocument<BookingUpdateDto> patchDocument)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookingAsync(int customerId, int bookingId)
        {
            throw new NotImplementedException();
        }
    }
}







