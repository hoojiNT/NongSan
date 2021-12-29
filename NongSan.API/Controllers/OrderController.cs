using NongSan.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.OrderService;

namespace NongSan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService OrderService;
        public OrderController(IOrderService OrderService)
        {
            this.OrderService = OrderService;
        }
        [HttpGet(nameof(GetOrder))]
        public IActionResult GetOrder(int id)
        {
            var result = OrderService.GetOrder(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpGet(nameof(GetAllOrder))]
        public IActionResult GetAllOrder()
        {
            var result = OrderService.GetAllOrders();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpPost(nameof(InsertOrder))]
        public IActionResult InsertOrder(Order Order)
        {
            OrderService.InsertOrder(Order);
            return Ok("Insert success!");
        }
        [HttpPut(nameof(UpdateOrder))]
        public IActionResult UpdateOrder(Order Order)
        {
            OrderService.UpdateOrder(Order);
            return Ok("Update success!");
        }
        [HttpDelete(nameof(DeleteOrder))]
        public IActionResult DeleteOrder(int id)
        {
            OrderService.DeleteOrder(id);
            return Ok("Delete success!");
        }
    }
}
