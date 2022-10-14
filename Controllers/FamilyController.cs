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
            return Ok();
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Family>>> Get(string search)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Family>> Post(Family article)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Family>> Put(int id, Family article)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<Family>> Delete(int id)
        {
            return Ok();
        }
    }
}
