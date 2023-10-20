using AnnexHotels.Core.Interfaces;
using AnnexHotels.Data.Interfaces;
using AnnexHotels.Dtos.CustomerDtos;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper, ILogger<CustomerService> logger)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<CustomerDto> Register(CustomerCreationDto customer)
        {
            var customerToBeCreated = _mapper.Map<Customer>(customer);

            await _customerRepository.RegisterAsync(customerToBeCreated);
            await _customerRepository.SaveChangesAsync();

            var response = _mapper.Map<CustomerDto>(customerToBeCreated);

            return response;
        }

        public async Task<IEnumerable<CustomerDto>> GetCustomers()
        {
            var customers = await _customerRepository.GetCustomersAsync();
            var customerDtos = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return customerDtos;
        }

        public async Task<CustomerDto> GetCustomerById(int customerId, bool includeBookings)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(customerId, includeBookings);

            if (customer == null)
            {
                _logger.LogInformation($"The customer with the Id: {customerId} could not be found");
            }

            var customerDto = _mapper.Map<CustomerDto>(customer);
            _logger.LogInformation($"The customer with the id: {customer.Id} and was fetched");

            return customerDto;
        }

        public async Task UpdateCustomerAsync(int customerId, CustomerUpdateDto customer)
        {
            var customerEntity = await _customerRepository.GetCustomerByIdAsync(customerId, false);

            if (customerEntity == null)
            {
                _logger.LogInformation($"The hotel with the Id: {customerId} could not be found");
            }

            _mapper.Map(customer, customerEntity);

            await _customerRepository.SaveChangesAsync();
        }

        public async Task UpdatePartialCustomerAsync(int customerId, JsonPatchDocument<CustomerUpdateDto> patchDocument)
        {
            var customerEntity = await _customerRepository.GetCustomerByIdAsync(customerId, false);
            if (customerEntity == null)
            {
                _logger.LogInformation($"The hotel with the Id: {customerId} could not be found");
            }

            var customerToPatch = _mapper.Map<CustomerUpdateDto>(customerEntity);
            patchDocument.ApplyTo(customerToPatch);

            _mapper.Map(customerToPatch, customerEntity);

            await _customerRepository.SaveChangesAsync();
        }
    }
}
