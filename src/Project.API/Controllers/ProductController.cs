using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces;
using Project.Domain.Model;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productRepo;

        public ProductController(IProductService productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _productRepo.GetAllProductsAsync();
            return Ok(result);
        }

    }
}
