using AnnexHotels.Dtos.BookingDtos;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Interfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDto>> GetBookings();
        Task<BookingDto> GetBookingById(int bookingId, bool includeRooms);
        Task<BookingDto> GetBookingByCustomerId(int customerId, int bookingId);
        Task<BookingDto> GetBookingsByCustomerId(int customerId);
        Task<BookingDto> GetBookingByHotelId(int hotelId, int bookingId, bool includeRooms);
        Task<BookingDto> GetBookingsByHotelId(int hotelId);
        Task<BookingDto> AddBooking(int companyId, BookingCreationDto booking);
        Task UpdateBookingAsync(int bookingId, BookingUpdateDto booking);
        Task UpdatePartialBookingAsync(int bookingId, JsonPatchDocument<BookingUpdateDto> patchDocument);
        Task DeleteBookingAsync(int customerId, int bookingId);
    }
}
