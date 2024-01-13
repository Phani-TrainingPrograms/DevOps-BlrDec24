using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerDbContext _customerDbContext;
        public CustomersController(CustomerDbContext context)
        {
            _customerDbContext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers() => _customerDbContext.Customers;

        [HttpGet("{id:int}")]

        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            return await _customerDbContext.Customers.FindAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Customer cst)
        {
            await _customerDbContext.Customers.AddAsync(cst);
            await _customerDbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(Customer cst)
        {
            _customerDbContext.Customers.Update(cst);
            await _customerDbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{customerId:int}")]
        public async Task<ActionResult> Delete(int customerId)
        {
            var cst = await _customerDbContext.Customers.FindAsync(customerId);
            if (cst == null)
            {
                return BadRequest("Customer not found to delete");
            }
            _customerDbContext.Customers.Remove(cst);
            await _customerDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
