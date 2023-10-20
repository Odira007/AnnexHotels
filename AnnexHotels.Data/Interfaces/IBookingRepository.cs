using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetBookingsAsync();
        Task<Booking> GetBookingByIdAsync(int bookingId, bool includeRooms);
        Task<IEnumerable<Booking>> GetBookingsByCustomerIdAsync(int customerId);
        Task<IEnumerable<Booking>> GetBookingsByHotelIdAsync(int hotelId);
        Task<Booking> GetBookingByCustomerIdAsync(int customerId, int bookingId);
        Task<Booking> GetBookingByHotelIdAsync(int hotelId, int bookingId);
        Task AddBookingByCustomerIdAsync(int customerId, Booking booking);
        Task DeleteBookingAsync(int bookingId);
        Task<bool> CheckBookingExists(int bookingId);
        Task<bool> CheckCustomerExists(int customerId);
        Task<bool> SaveChangesAsync();
    }
}
