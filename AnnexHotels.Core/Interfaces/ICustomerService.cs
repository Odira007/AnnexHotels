using AnnexHotels.Dtos.CustomerDtos;
using AnnexHotels.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Core.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerDto> Register(CustomerCreationDto customer);
        Task<IEnumerable<CustomerDto>> GetCustomers();
        Task<CustomerDto> GetCustomerById(int customerId, bool includeBookings);
        Task UpdateCustomerAsync(int customerId, CustomerUpdateDto customer);
        Task UpdatePartialCustomerAsync(int customerId, JsonPatchDocument<CustomerUpdateDto> patchDocument);
    }
}
