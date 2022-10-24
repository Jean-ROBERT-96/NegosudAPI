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
        IArticleRepository _repository;

        public ArticleController(IArticleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Article>>> Get()
        {
            return Ok(await _repository.GetAllArticles());
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Article>>> Get(string search)
        {
            return Ok(await _repository.GetArticle(search));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(int id)
        {
            return Ok(await _repository.GetArticleById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Article>> Post(Article article)
        {
            return CreatedAtAction("Post", await _repository.PostArticle(article));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Article>> Put(int id, Article article)
        {
            return Ok(await _repository.PutArticle(id, article));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Article>> Delete(int id)
        {
            return Ok(await _repository.DeleteArticle(id));
        }
    }
}
