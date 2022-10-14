using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PurchaseOrder>>> Get()
        {
            return Ok();
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<PurchaseOrder>>> Get(string search)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<PurchaseOrder>> Post(PurchaseOrder article)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<PurchaseOrder>> Put(int id, PurchaseOrder article)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<PurchaseOrder>> Delete(int id)
        {
            return Ok();
        }
    }
}
