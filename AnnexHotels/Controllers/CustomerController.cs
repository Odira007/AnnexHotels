using AnnexHotels.Core.Interfaces;
using AnnexHotels.Dtos.CustomerDtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnexHotels.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
        {
            return Ok(await _customerService.GetCustomers());
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<CustomerDto>> GetCustomerById(int customerId, bool includeBookings)
        {
            var customer = await _customerService.GetCustomerById(customerId, false);

            if (customer == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return customer;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDto>> Register(CustomerCreationDto customer)
        {
            var response = await _customerService.Register(customer);
           
            return Ok(response);
        }



        [HttpPut("{customerId}")]
        public async Task<ActionResult> UpdateHotel(int customerId, CustomerUpdateDto customer)
        {
            try
            {
                await _customerService.UpdateCustomerAsync(customerId, customer);
            }
            catch (ArgumentNullException)
            {
                return BadRequest(ModelState);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPatch("{customerId}")]
        public async Task<ActionResult> UpdatePartialCustomer(int customerId, JsonPatchDocument<CustomerUpdateDto> patchDocument)
        {
            try
            {
                await _customerService.UpdatePartialCustomerAsync(customerId, patchDocument);
            }
            catch (ArgumentNullException)
            {
                return BadRequest(ModelState);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
