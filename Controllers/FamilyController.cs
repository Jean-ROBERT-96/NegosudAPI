using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Data;
using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        private readonly IDataRepository<Family> _repository;

        public FamilyController(IDataRepository<Family> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Family>>> Get()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Family>>> Get(string search)
        {
            return Ok(await _repository.Get(search));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Family>> Get(int id)
        {
            return Ok(await _repository.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<Family>> Post(Family family)
        {
            return CreatedAtAction("Post", await _repository.Post(family));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Family>> Put(int id, Family family)
        {
            return Ok(await _repository.Put(id, family));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Family>> Delete(int id)
        {
            return Ok(await _repository.Delete(id));
        }
    }
}
