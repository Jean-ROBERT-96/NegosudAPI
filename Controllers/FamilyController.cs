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
        IFamilyRepository _repository;

        public FamilyController(IFamilyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Family>>> Get()
        {
            return Ok(await _repository.GetAllFamilies());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Family>>> Get(string search)
        {
            return Ok(await _repository.GetFamily(search));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Family>> Get(int id)
        {
            return Ok(await _repository.GetFamilyById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Family>> Post(Family family)
        {
            return Ok(await _repository.PostFamily(family));
        }

        [HttpPut]
        public async Task<ActionResult<Family>> Put(int id, Family family)
        {
            return Ok(await _repository.PutFamily(id, family));
        }

        [HttpDelete]
        public async Task<ActionResult<Family>> Delete(int id)
        {
            return Ok(await _repository.DeleteFamily(id));
        }
    }
}
