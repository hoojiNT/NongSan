using NongSan.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.UserService;

namespace NongSan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;
        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }
        [HttpGet(nameof(GetUser))]
        public IActionResult GetUser(int id)
        {
            var result = UserService.GetUser(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpGet(nameof(GetAllUser))]
        public IActionResult GetAllUser()
        {
            var result = UserService.GetAllUsers();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpPost(nameof(InsertUser))]
        public IActionResult InsertUser(User User)
        {
            UserService.InsertUser(User);
            return Ok("Insert success!");
        }
        [HttpPut(nameof(UpdateUser))]
        public IActionResult UpdateUser(User User)
        {
            UserService.UpdateUser(User);
            return Ok("Update success!");
        }
        [HttpDelete(nameof(DeleteUser))]
        public IActionResult DeleteUser(int id)
        {
            UserService.DeleteUser(id);
            return Ok("Delete success!");
        }
    }
}
