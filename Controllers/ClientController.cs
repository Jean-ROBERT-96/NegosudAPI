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
        private readonly IDataRepository<Client> _repository;

        public ClientController(IDataRepository<Client> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> Get()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Client>>> Get(string search)
        {
            return Ok(await _repository.Get(search));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Client>> Get(int id)
        {
            return Ok(await _repository.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<Client>> Post(Client client)
        {
            return CreatedAtAction("Post", await _repository.Post(client));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Client>> Put(int id, Client client)
        {
            return Ok(await _repository.Put(id, client));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> Delete(int id)
        {
            return Ok(await _repository.Delete(id));
        }
    }
}
