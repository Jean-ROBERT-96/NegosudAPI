using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Data;
using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        IPurchaseOrderRepository _repository;

        public PurchaseOrderController(IPurchaseOrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PurchaseOrder>>> Get()
        {
            return Ok(await _repository.GetAllPurchaseOrder());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<PurchaseOrder>>> Get(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<PurchaseOrder>>> Get(int id)
        {
            return Ok(await _repository.GetPurchaseOrderById(id));
        }

        [HttpPost]
        public async Task<ActionResult<PurchaseOrder>> Post(PurchaseOrder purchaseOrder)
        {
            return Ok(await _repository.PostPurchaseOrder(purchaseOrder));
        }

        [HttpPut]
        public async Task<ActionResult<PurchaseOrder>> Put(int id, PurchaseOrder purchaseOrder)
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
