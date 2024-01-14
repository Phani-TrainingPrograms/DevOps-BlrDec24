using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApi.Data;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly OnlineShopDbContext _context;

        public ProductsController(OnlineShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
