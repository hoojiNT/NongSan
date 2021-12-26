using NongSan.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.OrderDetailService;

namespace NongSan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService OrderDetailService;
        public OrderDetailController(IOrderDetailService OrderDetailService)
        {
            this.OrderDetailService = OrderDetailService;
        }
        [HttpGet(nameof(GetOrderDetail))]
        public IActionResult GetOrderDetail(string id)
        {
            var result = OrderDetailService.GetOrderDetail(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpGet(nameof(GetAllOrderDetail))]
        public IActionResult GetAllOrderDetail()
        {
            var result = OrderDetailService.GetAllOrderDetails();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpPost(nameof(InsertOrderDetail))]
        public IActionResult InsertOrderDetail(OrderDetail OrderDetail)
        {
            OrderDetailService.InsertOrderDetail(OrderDetail);
            return Ok("Insert success!");
        }
        [HttpPut(nameof(UpdateOrderDetail))]
        public IActionResult UpdateOrderDetail(OrderDetail OrderDetail)
        {
            OrderDetailService.UpdateOrderDetail(OrderDetail);
            return Ok("Update success!");
        }
        [HttpDelete(nameof(DeleteOrderDetail))]
        public IActionResult DeleteOrderDetail(string id)
        {
            OrderDetailService.DeleteOrderDetail(id);
            return Ok("Delete success!");
        }
    }
}
