using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Data;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientRepository _repository;

        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> Get()
        {
            return Ok();
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Client>>> Get(string search)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Client>> Post(Client article)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Client>> Put(int id, Client article)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<Client>> Delete(int id)
        {
            return Ok();
        }
    }
}
