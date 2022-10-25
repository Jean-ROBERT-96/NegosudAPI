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
        private readonly IDataRepository<Vendor> _repository;

        public VendorController(IDataRepository<Vendor> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vendor>>> Get()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Vendor>>> Get(string search)
        {
            return Ok(await _repository.Get(search));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Vendor>>> Get(int id)
        {
            return Ok(await _repository.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<Vendor>> Post(Vendor vendor)
        {
            return CreatedAtAction("Post" ,await _repository.Post(vendor));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Vendor>> Put(int id, Vendor vendor)
        {
            return Ok(await _repository.Put(id, vendor));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Vendor>> Delete(int id)
        {
            return Ok(await _repository.Delete(id));
        }
    }
}
