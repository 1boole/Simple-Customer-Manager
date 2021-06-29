using Bussines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //CustomerCode, CustomerName, CustomerCity, Type, Filter
        [HttpPost("Type0")]
        public IActionResult Add(Customer customer ,string CustomerCode, string CustomerName, string CustomerCity)
        {
            customer.Code = CustomerCode;
            customer.Name = CustomerName;
            customer.City = CustomerCity;
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("Type1")]
        public IActionResult Update(Customer customer, int id, string CustomerCode, string CustomerName, string CustomerCity)
        {
            customer.Id = id;
            customer.Code = CustomerCode;
            customer.Name = CustomerName;
            customer.City = CustomerCity;
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("Type2")]
        public IActionResult Delete(Customer customer, int id)
        {
            customer.Id = id;
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("Type3")]
        public IActionResult GetFilter(string filter)
        {
            var result = _customerService.GetAll();
            if (filter != "*")
            {
                result = _customerService.GetByCity(filter);
            }
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
