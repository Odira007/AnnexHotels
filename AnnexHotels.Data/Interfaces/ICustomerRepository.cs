using AnnexHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> RegisterAsync(Customer customer);
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int customerId, bool includeBookings);
        Task<bool> SaveChangesAsync();
    }
}
