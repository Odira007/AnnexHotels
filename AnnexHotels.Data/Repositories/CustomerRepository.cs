using AnnexHotels.Data.Interfaces;
using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnexHotels.Utilities;
using AnnexHotels.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace AnnexHotels.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AnnexHotelsDbContext _dbContext;

        public CustomerRepository(AnnexHotelsDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Customer> RegisterAsync(Customer customer)
        {
            customer.Salt = SaltAndHash.Salt();
            customer.SaltHashedPassword = SaltAndHash.SaltHashedPassword(customer.Password, customer.Salt);
            var newCustomer = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Password = null,
                Salt = customer.Salt,
                ConfirmPassword = null,
                CreatedAt = customer.CreatedAt,
                PhoneNumber = customer.PhoneNumber,
                SaltHashedPassword = customer.SaltHashedPassword
        };

            await _dbContext.Customers.AddAsync(newCustomer);

            return newCustomer;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _dbContext.Customers.OrderBy(e => e.LastName).ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int customerId, bool includeBookings)
        {
            if (includeBookings)
            {
                return await _dbContext.Customers.Include(e => e.Bookings)
                    .Where(e => e.Id == customerId).FirstOrDefaultAsync();
            }
            return await _dbContext.Customers
                .Where(e => e.Id == customerId).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
