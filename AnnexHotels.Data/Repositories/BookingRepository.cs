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
    public class BookingRepository : IBookingRepository
    {
        private readonly AnnexHotelsDbContext _dbContext;

        public BookingRepository(AnnexHotelsDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task AddBookingByCustomerIdAsync(int customerId, Booking booking)
        {
            var customer = await GetCustomerByIdAsync(customerId, false);

            if (customer != null)
            {
                customer.Bookings.Add(booking);
            }
        }

        public async Task DeleteBookingAsync(int bookingId)
        {
            var booking = await _dbContext.Bookings.FirstOrDefaultAsync(e => e.Id == bookingId);

            _dbContext.Bookings.Remove(booking);
        }

        public async Task<IEnumerable<Booking>> GetBookingsByCustomerIdAsync(int customerId)
        {
            return await _dbContext.Bookings
                .Where(e => e.CustomerId == customerId).ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetBookingsByHotelIdAsync(int hotelId)
        {
            return await _dbContext.Bookings
                .Where(e => e.HotelId == hotelId).ToListAsync();
        }

        public async Task<Booking> GetBookingByCustomerIdAsync(int customerId, int bookingId)
        {
            return await _dbContext.Bookings
                .Where(e => e.CustomerId == customerId && e.Id == bookingId).FirstOrDefaultAsync();
        }

        public async Task<Booking> GetBookingByHotelIdAsync(int hotelId, int bookingId)
        {
            return await _dbContext.Bookings
                .Where(e => e.HotelId == hotelId && e.Id == bookingId).FirstOrDefaultAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int bookingId, bool includeReservations)
        {
            if (includeReservations)
            {
                return await _dbContext.Bookings.Include(e => e.ReservedRooms)
                    .FirstOrDefaultAsync(e => e.Id == bookingId);
            }

            return await _dbContext.Bookings.FirstOrDefaultAsync(e => e.Id == bookingId);
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return await _dbContext.Bookings.ToListAsync();
        }

        public async Task<bool> CheckBookingExists(int bookingId)
        {
            var booking = await _dbContext.Bookings.FirstOrDefaultAsync(e => e.Id == bookingId);

            return booking != null;
        }

        public async Task<bool> CheckCustomerExists(int customerId)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(e => e.Id == customerId);

            return customer != null;
        }

        public async Task<Customer> GetCustomerByIdAsync(int customerId, bool includeBookings)
        {
            if (includeBookings)
            {
                return await _dbContext.Customers.Include(e => e.Bookings)
                    .FirstOrDefaultAsync(e => e.Id == customerId);
            }

            return await _dbContext.Customers.FirstOrDefaultAsync(e => e.Id == customerId);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _dbContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
