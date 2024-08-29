// Controllers/ProductsController.cs
using BranchesConflictTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace BranchesConflictTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok("Modified product details in feature/products branch");
        }
    }
}
