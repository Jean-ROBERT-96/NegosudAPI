using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Data;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        IVendorRepository _repository;

        public VendorController(IVendorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vendor>>> Get()
        {
            return Ok(await _repository.GetAllVendor());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Vendor>>> Get(string search)
        {
            return Ok(await _repository.GetVendor(search));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Vendor>>> Get(int id)
        {
            return Ok(await _repository.GetVendorById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Vendor>> Post(Vendor vendor)
        {
            return Ok(await _repository.PostVendor(vendor));
        }

        [HttpPut]
        public async Task<ActionResult<Vendor>> Put(int id, Vendor vendor)
        {
            return Ok(await _repository.PutVendor(id, vendor));
        }

        [HttpDelete]
        public async Task<ActionResult<Vendor>> Delete(int id)
        {
            return Ok(await _repository.DeleteVendor(id));
        }
    }
}
