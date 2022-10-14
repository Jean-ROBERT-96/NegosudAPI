using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Vendor>>> Get()
        {
            return Ok();
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Vendor>>> Get(string search)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Vendor>> Post(Vendor article)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Vendor>> Put(int id, Vendor article)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<Vendor>> Delete(int id)
        {
            return Ok();
        }
    }
}
