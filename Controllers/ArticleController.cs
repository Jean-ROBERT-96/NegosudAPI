using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Article>>> Get()
        {
            return Ok();
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<List<Article>>> Get(string search)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Article>> Post(Article article)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Article>> Put(int id, Article article)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<Article>> Delete(int id)
        {
            return Ok();
        }
    }
}
