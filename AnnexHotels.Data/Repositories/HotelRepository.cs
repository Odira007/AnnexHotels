using AnnexHotels.Data.DbContexts;
using AnnexHotels.Data.Interfaces;
using AnnexHotels.Dtos.HotelDto;
using AnnexHotels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly AnnexHotelsDbContext _dbContext;

        public HotelRepository(AnnexHotelsDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task AddHotelAsync(Hotel hotel)
        {
            await _dbContext.AddAsync(hotel);
        }

        public async Task AddHotelByCompanyIdAsync(int companyId, Hotel hotel)
        {
            var company = await GetCompanyByIdAsync(companyId, false);

            if (company != null)
            {
                company.Hotels.Add(hotel);
            }
        }

        public async Task DeleteHotelAsync(int hotelId)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(e => e.Id == hotelId);

            _dbContext.Hotels.Remove(hotel);
        }

        public async Task<Hotel> GetHotelByCompanyIdAsync(int companyId, int hotelId)
        {
            return await _dbContext.Hotels.Where(e => e.CompanyId == companyId && e.Id == hotelId)
                .FirstOrDefaultAsync();
        }

        public async Task<Hotel> GetHotelByIdAsync(int hotelId, bool includeRooms)
        {
            if (includeRooms)
            {
                return await _dbContext.Hotels.Include(e => e.Rooms) // Eager loading
                    .FirstOrDefaultAsync(e => e.Id == hotelId);
            }

            return await _dbContext.Hotels.FirstOrDefaultAsync(e => e.Id == hotelId);
        }

        public async Task<IEnumerable<Hotel>> GetHotelsAsync()
        {
            return await _dbContext.Hotels.OrderBy(e => e.Name).ToListAsync(); // LINQ
        }

        public async Task<IEnumerable<Hotel>> GetHotelsByCompanyIdAsync(int companyId)
        {
            return await _dbContext.Hotels.OrderBy(e => e.Name)
                .Where(e => e.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> CheckHotelExists(int hotelId)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(e => e.Id == hotelId);

            return hotel != null;
        }

        public async Task<bool> CheckCompanyExists(int companyId)
        {
            var company = await _dbContext.Companies.FirstOrDefaultAsync(e => e.Id == companyId);

            return company != null;
        }

        public async Task<Company> GetCompanyByIdAsync(int companyId, bool includeHotels)
        {
            if (includeHotels)
            {
                return await _dbContext.Companies.Include(e => e.Hotels) // Eager loading
                    .FirstOrDefaultAsync(e => e.Id == companyId);
            }

            return await _dbContext.Companies.FirstOrDefaultAsync(e => e.Id == companyId);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
