using NongSan.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductService;

namespace NongSan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService ProductService;
        public ProductController(IProductService ProductService)
        {
            this.ProductService = ProductService;
        }
        [HttpGet(nameof(GetProduct))]
        public IActionResult GetProduct(int id)
        {
            var result = ProductService.GetProduct(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpGet(nameof(GetAllProduct))]
        public IActionResult GetAllProduct()
        {
            var result = ProductService.GetAllProducts();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(Product Product)
        {
            ProductService.InsertProduct(Product);
            return Ok("Insert success!");
        }
        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product Product)
        {
            ProductService.UpdateProduct(Product);
            return Ok("Update success!");
        }
        [HttpDelete(nameof(DeleteProduct))]
        public IActionResult DeleteProduct(int id)
        {
            ProductService.DeleteProduct(id);
            return Ok("Delete success!");
        }
    }
}
