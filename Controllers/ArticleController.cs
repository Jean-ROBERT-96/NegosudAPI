using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Data;
using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IDataRepository<Article> _repository;

        public ArticleController(IDataRepository<Article> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Article>>> Get()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Article>>> Get(string search)
        {
            return Ok(await _repository.Get(search));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Article>> Get(int id)
        {
            return Ok(await _repository.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<Article>> Post(Article article)
        {
            return CreatedAtAction("Post", await _repository.Post(article));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Article>> Put(int id, Article article)
        {
            return Ok(await _repository.Put(id, article));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Article>> Delete(int id)
        {
            return Ok(await _repository.Delete(id));
        }
    }
}
