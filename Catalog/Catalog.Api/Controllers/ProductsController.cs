using Catalog.Infrasctructure.Products;
using Catalog.Infrasctructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _productService.GetAllAsync();

            return Json(users);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProduct command)
        {
            await _productService.CreateAsync(command.Code, command.Name, command.Price);

            return Created();
        }
    }
}