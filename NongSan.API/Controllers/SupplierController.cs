using AutoMapper;
using NongSan.API.DTOs;
using NongSan.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SupplierService;

namespace NongSan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService SupplierService;
        private readonly IMapper _mapper;
        public SupplierController(ISupplierService SupplierService, IMapper mapper)
        {
            this.SupplierService = SupplierService;
            this._mapper = mapper;
        }
        [HttpGet(nameof(GetSupplier))]
        public IActionResult GetSupplier(string id)
        {
            var supplier = SupplierService.GetSupplier(id);
            var result = _mapper.Map<SupplierDTO>(supplier);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpGet(nameof(GetAllSupplier))]
        public IActionResult GetAllSupplier()
        {
            var result = SupplierService.GetAllSuppliers();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No found");
        }
        [HttpPost(nameof(InsertSupplier))]
        public IActionResult InsertSupplier(SupplierDTO Supplier)
        {
            var item = _mapper.Map<Supplier>(Supplier);
            SupplierService.InsertSupplier(item);
            return Ok("Insert success!");
        }
        [HttpPut(nameof(UpdateSupplier))]
        public IActionResult UpdateSupplier(SupplierDTO Supplier)
        {

            SupplierService.UpdateSupplier(_mapper.Map<Supplier>(Supplier));
            return Ok("Update success!");
        }
        [HttpDelete(nameof(DeleteSupplier))]
        public IActionResult DeleteSupplier(string id)
        {
            SupplierService.DeleteSupplier(id);
            return Ok("Delete success!");
        }
    }
}
