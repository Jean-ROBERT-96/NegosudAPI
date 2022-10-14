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
            return Ok(await _repository.GetAllClient());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Client>>> Get(string search)
        {
            return Ok(await _repository.GetClient(search));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> Get(int id)
        {
            return Ok(await _repository.GetClientById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Client>> Post(Client client)
        {
            return Ok(await _repository.PostClient(client));
        }

        [HttpPut]
        public async Task<ActionResult<Client>> Put(int id, Client client)
        {
            return Ok(await _repository.PutClient(id, client));
        }

        [HttpDelete]
        public async Task<ActionResult<Client>> Delete(int id)
        {
            return Ok(await _repository.DeleteClient(id));
        }
    }
}
